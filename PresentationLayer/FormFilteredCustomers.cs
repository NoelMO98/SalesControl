using ControlVentas.BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlVentas.PresentationLayer
{
    public partial class FormFilteredCustomers : Form
    {
        private List<IBusinessObject> filteredCustomers = null;
        private bool areDebtors = false;
        public FormFilteredCustomers()
        {
            InitializeComponent();
        }

        public FormFilteredCustomers(List<IBusinessObject> filteredCustomers)
            : this()
        {
            this.filteredCustomers = filteredCustomers;
            if (filteredCustomers.Count != 0)
            {
                this.areDebtors = ((LCustomer)this.filteredCustomers.First()).Debtor;
                fillDataGridView(this.filteredCustomers);
            }
        }

        private void fillDataGridView(List<IBusinessObject> filteredCustomers)
        {
            dataGridViewFilteredCustomers.Rows.Clear();
            foreach (LCustomer customer in filteredCustomers)
            {
                dataGridViewFilteredCustomers.Rows.Add(customer, customer.Name, customer.Address, customer.getFormattedTelephoneNumbers());
            }
        }

        private void dataGridViewFilteredCustomers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewFilteredCustomers.Rows.Count == 0)
                return;
            LCustomer customer = (LCustomer)dataGridViewFilteredCustomers.SelectedCells[ColumnCustomer.Index].Value;
            FormMain.setFormToPanel(new FormCustomerOrders(customer, this));
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (this.filteredCustomers.Count == 0)
            {
                return;
            }
            string searcher = textBoxSearch.Text;
            if (string.IsNullOrEmpty(searcher))
            {
                fillDataGridView(new LCustomer().select(areDebtors));
                return;
            }
            List<IBusinessObject> searches = LCustomer.searcher(searcher, false);
            fillDataGridView(searches.Where(search => ((LCustomer)search).Debtor == areDebtors).Cast<IBusinessObject>().ToList());
        }
    }
}
