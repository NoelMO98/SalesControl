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
    public partial class FormCustomers : Form
    {
        private List<string> telephoneNumbersList = new List<string>();
        private const string generalSale = "VENTA GENERAL";
        public FormCustomers()
        {
            InitializeComponent();
            fillDataGridView(new LCustomer().select());
            setTelephoneNumbersToList();
            maskedTextBoxTelephone.TelephoneNumbers = telephoneNumbersList;
        }

        private void fillDataGridView(List<IBusinessObject> customersList)
        {
            dataGridViewCustomers.Rows.Clear();
            foreach (LCustomer customer in customersList)
            {
                dataGridViewCustomers.Rows.Add(customer, customer.Name, customer.Address, customer.getFormattedTelephoneNumbers(), customer.Debtor);
            }

        }
        private void setTelephoneNumbersToList()
        {
            telephoneNumbersList.Clear();
            new LCustomer().select().ForEach(customer =>
            {
                telephoneNumbersList.AddRange(((LCustomer)customer).getTelephoneNumbers());
            });
        }

        private void dataGridViewCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewCustomers.Rows.Count == 0 || 
                ((ColumnEdit.Index == e.ColumnIndex|| ColumnDelete.Index == e.ColumnIndex) &&
                ((LCustomer)dataGridViewCustomers.SelectedCells[ColumnCustomer.Index].Value).Name.Equals(generalSale)))
            {
                return;
            }

            if (dataGridViewCustomers.CurrentCell.ColumnIndex != ColumnEdit.Index && dataGridViewCustomers.CurrentCell.ColumnIndex != ColumnDelete.Index)
            {
                dataGridViewCustomers.CurrentCell.Selected = true;
                return;
            }

            LCustomer customer = (LCustomer)dataGridViewCustomers.SelectedCells[ColumnCustomer.Index].Value;

            if (dataGridViewCustomers.CurrentCell.ColumnIndex == ColumnEdit.Index)
            {
                setTelephoneNumbersToList();
                setCustomerToEdit(customer);
            }
            else if (dataGridViewCustomers.CurrentCell.ColumnIndex == ColumnDelete.Index)
            {
                DialogResult result = MessageBox.Show($"Desea eliminar al cliente {customer.Name}?", "Eliminando cliente", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    deleteCustomer(customer);
                }
            }
        }

        private bool editingProcess = false;
        private LCustomer customerSelectedToEdit;
        private void setCustomerToEdit(LCustomer customer)
        {
            defaultValues();
            deleteCustomerTelephoneNumbers(customer);
            textBoxCustomer.Text = customer.Name;
            textBoxAddress.Text = customer.Address;
            fillMasksWithCustomerTelephoneNumbers(customer);
            editingProcess = true;
            buttonSave.Text = "Guardar cambios";
            this.customerSelectedToEdit = customer;
            showPanelSide();
        }

        private void deleteCustomer(LCustomer customer)
        {
            if (customer.delete())
            {
                deleteCustomerTelephoneNumbers(customer);
                if (this.editingProcess && this.customerSelectedToEdit.Equals(customer))
                {
                    editingProcess = false;
                    buttonSave.Text = "Guardar";
                }
                fillDataGridView(new LCustomer().select());
                FormMain.updateOrdersFromReminders();
            }
            else
            {
                MessageBox.Show($"Error al eliminar al usuario {customer.Name}");
            }
        }

        private void deleteCustomerTelephoneNumbers(LCustomer customer)
        {
            List<string> telephoneNumbers = customer.getTelephoneNumbers();

            foreach (var number in telephoneNumbers)
            {
                int indexTelephoneNumber = this.telephoneNumbersList.IndexOf(number);
                if(indexTelephoneNumber != -1)
                {
                    this.telephoneNumbersList.RemoveAt(indexTelephoneNumber);
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (areTextBoxesClean())
            {
                MessageBox.Show("Complete todos los campos");
                return;
            }

            string name = textBoxCustomer.Text;
            string address = textBoxAddress.Text;
            string telephone = (maskedTextBoxTelephone.MaskFull) ? maskedTextBoxTelephone.Text : null;

            LCustomer newCustomer = new LCustomer(name, address, editingProcess ? this.customerSelectedToEdit.Debtor : false);
            addTelephoneNumbersToCustomer(newCustomer, telephone);

            if (editingProcess)
            {
                updateCustomer(newCustomer);
                return;
            }
            if (newCustomer.insert())
            {
                setTelephoneNumbersToList();
                fillDataGridView(new LCustomer().select());
                defaultValues();
            }
            else
            {
                MessageBox.Show("Ocurrio un error");
            }
        }

        private void updateCustomer(LCustomer newCustomer)
        {
            if (!newCustomer.Equals(this.customerSelectedToEdit))
            {
                if (this.customerSelectedToEdit.update(newCustomer))
                {
                    setTelephoneNumbersToList();
                    fillDataGridView(new LCustomer().select());
                }
                else
                {
                    MessageBox.Show($"Error al modificar al cliente {newCustomer.Name}");
                    return;
                }
            }
            defaultValues();
            this.editingProcess = false;
            buttonSave.Text = "Guardar";
        }

        private bool areTextBoxesClean()
        {
            string customer = textBoxCustomer.Text;
            string address = textBoxAddress.Text;
            return string.IsNullOrEmpty(customer) || string.IsNullOrEmpty(address);
        }


        private void addTelephoneNumbersToCustomer(LCustomer customer, string telephoneNumber1)
        {
            customer.addTelephone(telephoneNumber1);

            TableLayoutControlCollection panelCollection = tableLayoutPanelTelephone.Controls;

            foreach (var item in panelCollection)
            {

                if (item.GetType().Name.Equals("BackgroundPanel"))
                {
                    foreach (var value in ((BackgroundPanel)item).Controls)
                    {
                        if (value.GetType().Name.Equals("MaskedTextBoxesTelephone"))
                        {
                            customer.addTelephone(((MaskedTextBoxesTelephone)value).MaskFull ? ((MaskedTextBoxesTelephone)value).Text : null);
                        }
                    }
                }
            }
        }

        private void defaultValues()
        {
            textBoxCustomer.Clear();
            textBoxAddress.Clear();
            maskedTextBoxTelephone.Clear();
            tableLayoutPanelTelephone.Controls.Clear();
            tableLayoutPanelTelephone.RowCount = 0;
            tableLayoutPanelTelephone.RowStyles.Clear();
            telephones = 1;
            column = 0;
            row = 0;
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            panelSide.Visible = !panelSide.Visible;
        }

        private void buttonMenu_MouseHover(object sender, EventArgs e)
        {
            changeButtonColorWithoutBorder(true, buttonMenu);
        }

        private void buttonMenu_MouseLeave(object sender, EventArgs e)
        {
            changeButtonColorWithoutBorder(false, buttonMenu);
        }

        private int column = 0, row = 0;
        private void buttonNewTelephone_Click(object sender, EventArgs e)
        {
            if (areFullRowsInTableLayoutPanelTelephone() || tableLayoutPanelTelephone.Controls.Count == 0)
            {
                addStyleToTableLayoutPanelTelephone();
            }
            addLabelToTableLayoutPanelTelephone();
            MaskedTextBox temp = addMaskedTextBoxToTableLayoutPanelTelephone();
            if (column == 2)
            {
                row += 2;
                column = 0;
            }
            temp.Focus();
        }
        private void fillMasksWithCustomerTelephoneNumbers(LCustomer customer)
        {
            List<string> telephoneNumbers = customer.getTelephoneNumbers();

            for (int i = 0; i < telephoneNumbers.Count; i++)
            {
                if (i == 0)
                {
                    maskedTextBoxTelephone.Text = telephoneNumbers[0];
                }
                else
                {
                    if (areFullRowsInTableLayoutPanelTelephone() || tableLayoutPanelTelephone.Controls.Count == 0)
                    {
                        addStyleToTableLayoutPanelTelephone();
                    }
                    addLabelToTableLayoutPanelTelephone();
                    MaskedTextBox temp = addMaskedTextBoxToTableLayoutPanelTelephone();
                    temp.Text = telephoneNumbers[i];
                }
            }
        }
        private bool areFullRowsInTableLayoutPanelTelephone()
        {
            return tableLayoutPanelTelephone.Controls.Count % 4 == 0;
        }

        private void addStyleToTableLayoutPanelTelephone()
        {
            this.tableLayoutPanelTelephone.RowCount += 2;
            this.panelControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.panelControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
        }
        private int telephones = 1;
        public void addLabelToTableLayoutPanelTelephone()
        {
            LabelsTelephone label = new LabelsTelephone();
            label.SetText(++telephones);
            this.tableLayoutPanelTelephone.Controls.Add(label, column, row);
        }
        private MaskedTextBox addMaskedTextBoxToTableLayoutPanelTelephone()
        {
            BackgroundPanel panel = new BackgroundPanel();
            this.tableLayoutPanelTelephone.Controls.Add(panel, column++, row + 1);
            return panel.MaskedText;
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string searcher = textBoxSearch.Text;
            if (string.IsNullOrEmpty(searcher))
            {
                fillDataGridView(new LCustomer().select());
               return;
            }
            fillDataGridView(LCustomer.searcher(searcher, true));
        }
        private void showPanelSide()
        {
            if (!panelSide.Visible)
            {
                panelSide.Visible = true;
            }
        }

        private void buttonNewTelephone_MouseLeave(object sender, EventArgs e)
        {
            changeButtonColorWithoutBorder(false, buttonNewTelephone);
        }

        private void buttonNewTelephone_MouseHover(object sender, EventArgs e)
        {
            changeButtonColorWithoutBorder(true, buttonNewTelephone);
        }

        private void dataGridViewCustomers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewCustomers.Rows.Count == 0)
                return;

            LCustomer customer = (LCustomer)dataGridViewCustomers.SelectedCells[ColumnCustomer.Index].Value;
            FormMain.setFormToPanel(new FormCustomerOrders(customer, this));
        }

        private void changeButtonColorWithoutBorder(bool isOnButton, Button button)
        {
            if (isOnButton)
            {
                button.ForeColor = Color.FromArgb(34, 146, 164);
            }
            else
            {
                button.ForeColor = Color.FromArgb(31, 36, 33);
            }
        }
    }
}
