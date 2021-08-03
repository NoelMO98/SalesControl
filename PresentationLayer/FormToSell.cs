using ControlVentas.BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlVentas.PresentationLayer
{
    public partial class FormToSell : Form
    {
        private const string generalSale = "VENTA GENERAL";
        private List<IBusinessObject> orders = new List<IBusinessObject>();
        private LOrder reminderOrder; 
        public FormToSell()
        {
            InitializeComponent();
            textBoxAmount.Text = decimal.Zero.ToString();
            autocompleteComboBoxCustomer();
            comboBoxCustomer.Text = generalSale;
            comboBoxCustomer.Focus();
        }

        public FormToSell(LOrder order) : this()
        {
            this.reminderOrder = order;
            comboBoxCustomer.SelectedItem = order.Customer;
            textBoxDescription.Text = order.Description;
        }

        private void autocompleteComboBoxCustomer()
        {
            List<LCustomer> customers = new LCustomer().select().Cast<LCustomer>().ToList();
            comboBoxCustomer.DataSource = customers;
            comboBoxCustomer.DisplayMember = "Name";
            comboBoxCustomer.AutoCompleteCustomSource.Clear();
            customers.ForEach(customer => comboBoxCustomer.AutoCompleteCustomSource.Add(((LCustomer)customer).Name));
        }

        private void buttonEndSale_Click(object sender, EventArgs e)
        {
            int rows = dataGridViewOrders.Rows.Count;
            if (areTextBoxesClean() && rows == 0)
            {
                MessageBox.Show("Agregue algún pedido");
                return;
            }
            if (!areTextBoxesClean())
            {
                addOrderedOrderToList(createOrder());
                fillDataGridView(this.orders);
                cleanTextBoxesAndCheckBox();
            }
            bool successfulSale = FormEndSale.endSale(this.orders.Cast<LOrder>().ToList());
            if (successfulSale)
            {
                defaultValues();
                if (this.reminderOrder != null)
                {
                    FormMain.updateOrdersFromReminders();
                }
            }
            comboBoxCustomer.Focus();
        }

        private void buttonAddOrder_Click(object sender, EventArgs e)
        {
            if (areTextBoxesClean())
            {
                MessageBox.Show("Complete todos los campos");
                return;
            }
            addOrderedOrderToList(createOrder());
            fillDataGridView(this.orders);
            cleanTextBoxesAndCheckBox();
        }

        private bool areTextBoxesClean()
        {
            string customer = comboBoxCustomer.Text;
            string description = textBoxDescription.Text;
            bool amount = decimal.Parse(textBoxAmount.Text) == 0;
            return string.IsNullOrEmpty(customer) || string.IsNullOrEmpty(description) || amount;
        }

        private LOrder createOrder()
        {
            decimal priceKilo = decimal.Parse(textBoxPriceKilo.Text);
            decimal weight = checkBoxExactAmount.Checked ? 0 : decimal.Parse(textBoxWeight.Text);
            bool isExactAmount = checkBoxExactAmount.Checked;
            decimal amount = decimal.Parse(textBoxAmount.Text);
            LOrderDetail orderDetail = new LOrderDetail(priceKilo, weight, isExactAmount, amount);
            LCustomer customer = (LCustomer)comboBoxCustomer.SelectedItem;
            DateTime today = DateTime.Now;
            string description = textBoxDescription.Text;

            if(this.reminderOrder != null)
            {
                return new LOrder(this.reminderOrder.ID,description,today,customer,orderDetail);
            }
            else
            {
                return new LOrder(description, today, customer, orderDetail);
            }
        }

        public void addOrderedOrderToList(LOrder order)
        {
            if (dataGridViewOrders.Rows.Count == 0)
            {
                this.orders.Insert(0, order);
            }
            else
            {
                int orderCount = this.orders.Count;

                for (int i = 0; i < orderCount; i++)
                {
                    if (order.OrderDetail.Amount <= ((LOrder)this.orders[i]).OrderDetail.Amount)
                    {
                        this.orders.Insert(i, order);
                        break;
                    }
                    else if (i == orderCount - 1)
                    {
                        this.orders.Add(order);
                    }
                }
            }
        }

        private void fillDataGridView(List<IBusinessObject> orders)
        {
            decimal totalAmount = 0;
            dataGridViewOrders.Rows.Clear();
            foreach (LOrder order in orders)
            {
                int rowIndex = dataGridViewOrders.Rows.Add();
                DataGridViewRow row = dataGridViewOrders.Rows[rowIndex];
                row.Cells[ColumnOrder.Name].Value = order;
                row.Cells[ColumnDescription.Name].Value = order.Description;
                row.Cells[ColumnPriceKilo.Name].Value = order.OrderDetail.PriceKilo;
                row.Cells[ColumnWeight.Name].Value = order.OrderDetail.Weight;
                row.Cells[ColumnExactAmount.Name].Value = order.OrderDetail.ExactAmount;
                row.Cells[ColumnAmount.Name].Value = order.OrderDetail.Amount;
                totalAmount += order.OrderDetail.Amount;
            }
            labelTotalAmount.Text = totalAmount.ToString("C2");
        }

        private void defaultValues()
        {
            dataGridViewOrders.Rows.Clear();
            this.orders = new List<IBusinessObject>();
            comboBoxCustomer.Text = generalSale;
            labelTotalAmount.Text = decimal.Zero.ToString("C2");
            cleanTextBoxesAndCheckBox();
        }

        private void cleanTextBoxesAndCheckBox()
        {
            textBoxPriceKilo.Clear();
            textBoxWeight.Clear();
            checkBoxExactAmount.Checked = false;
            textBoxDescription.Clear();
        }

        private void dataGridViewOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewOrders.Rows.Count == 0)
            {
                return;
            }
            if (dataGridViewOrders.CurrentCell.ColumnIndex != ColumnEdit.Index && dataGridViewOrders.CurrentCell.ColumnIndex != ColumnDelete.Index)
            {
                dataGridViewOrders.CurrentCell.Selected = true;
                return;
            }

            LOrder selectedOrder = (LOrder)dataGridViewOrders.SelectedCells[ColumnOrder.Index].Value;

            if (dataGridViewOrders.CurrentCell.ColumnIndex == ColumnEdit.Index)
            {
                FormEditOrder.editOrder(selectedOrder);
            }

            if (dataGridViewOrders.CurrentCell.ColumnIndex == ColumnDelete.Index)
            {
                this.orders.Remove(selectedOrder);
            }
            fillDataGridView(this.orders);
        }

        private void textBoxPriceKilo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = onlyNumbers(sender, e.KeyChar);
        }

        private void textBoxWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = onlyNumbers(sender, e.KeyChar);
        }

        private bool onlyNumbers(object sender, char input)
        {
            if (!char.IsControl(input) && !char.IsDigit(input) && (input != '.'))
            {
                return true;
            }

            bool existingPoint = ((TextBox)sender).Text.IndexOf('.') > -1;
            if ((input == '.') && existingPoint)
            {
                return true;
            }

            return false;
        }

        private void textBoxPriceKilo_TextChanged(object sender, EventArgs e)
        {
            if (checkBoxExactAmount.Checked)
            {
                string amount = textBoxAmount.Text = textBoxPriceKilo.Text;
                labelIndividualAmount.Text = (string.IsNullOrEmpty(amount)) ? decimal.Zero.ToString("C2") : decimal.Parse(amount).ToString("C2");
            }
            else
            {
                calculateIndividualAmount();
            }
        }

        private void textBoxWeight_TextChanged(object sender, EventArgs e)
        {
            calculateIndividualAmount();
        }

        private void calculateIndividualAmount()
        {
            textBoxAmount.Text = decimal.Zero.ToString("N2");
            labelIndividualAmount.Text = decimal.Parse(textBoxAmount.Text).ToString("C2");

            string textPriceKilo = textBoxPriceKilo.Text;
            string textWeight = textBoxWeight.Text;
            string decimalPoint = ".";
            if (textPriceKilo.Equals(decimalPoint) || textWeight.Equals(decimalPoint))
            {
                return;
            }

            if (!string.IsNullOrWhiteSpace(textPriceKilo) && !string.IsNullOrWhiteSpace(textWeight))
            {
                decimal individualAmount = decimal.Parse(textPriceKilo) * decimal.Parse(textWeight);
                textBoxAmount.Text = individualAmount.ToString("N2");
                labelIndividualAmount.Text = individualAmount.ToString("C2", CultureInfo.CurrentCulture);
            }
        }

        private void checkBoxExactAmount_CheckedChanged(object sender, EventArgs e)
        {
            string notChecked = "Precio por Kg:", isChecked = "Cantidad:";
            if (checkBoxExactAmount.Checked)
            {
                labelPriceKilo.Text = isChecked;
                textBoxWeight.Clear();
                textBoxWeight.Enabled = false;

                string amount = textBoxPriceKilo.Text;
                textBoxAmount.Text = string.IsNullOrEmpty(amount) ? decimal.Zero.ToString("N2") : amount;
                labelIndividualAmount.Text = decimal.Parse(textBoxAmount.Text).ToString("C2");
            }
            else
            {
                labelPriceKilo.Text = notChecked;
                textBoxWeight.Enabled = true;
                calculateIndividualAmount();
            }
        }

        private void comboBoxCustomer_Validated(object sender, EventArgs e)
        {
            if (comboBoxCustomer.SelectedIndex == -1)
            {
                string customerNameNotFound = comboBoxCustomer.Text;
                DialogResult dialog = MessageBox.Show($"Cliente no encontrado\n¿Desea registrar a \"{ customerNameNotFound }\" como nuevo cliente?",
                    "Error", MessageBoxButtons.YesNo);
                string customerName = string.Empty;
                if (dialog == DialogResult.Yes)
                {
                    comboBoxCustomer.Text = customerName = FormNewCustomer.newCustomer(customerNameNotFound);
                }
                if (!string.IsNullOrEmpty(customerName))
                {
                    autocompleteComboBoxCustomer();
                    comboBoxCustomer.Text = customerName;
                    return;
                }
                if (dialog != DialogResult.Yes || string.IsNullOrEmpty(customerName))
                {
                    MessageBox.Show($"La venta será registrada como {generalSale}");
                    comboBoxCustomer.Text = generalSale;
                }
            }
        }
    }
}
