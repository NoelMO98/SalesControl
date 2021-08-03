using ControlVentas.BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlVentas.PresentationLayer
{
    public partial class FormEditOrder : Form
    {
        private static FormEditOrder formEditOrder;
        private static LOrder order;
        const string currencySymbol = "$ ", currencySymbolWithZero = "$ 0";
        public FormEditOrder()
        {
            InitializeComponent();
        }

        public FormEditOrder(LOrder order) : this()
        {
            FormEditOrder.order = order;
            textBoxPriceKilo.Text = FormEditOrder.order.OrderDetail.PriceKilo.ToString();
            textBoxWeight.Text = FormEditOrder.order.OrderDetail.Weight.ToString();
            textBoxDescription.Text = FormEditOrder.order.Description;
            checkBoxExactAmount.Checked = FormEditOrder.order.OrderDetail.ExactAmount;
            labelIndividualAmount.Text = currencySymbol + FormEditOrder.order.OrderDetail.Amount;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (areTextBoxesClean())
            {
                MessageBox.Show("Complete todos los campos");
                return;
            }
            FormEditOrder.order.Description = textBoxDescription.Text;
            FormEditOrder.order.OrderDetail.PriceKilo = decimal.Parse(textBoxPriceKilo.Text);
            FormEditOrder.order.OrderDetail.Weight = checkBoxExactAmount.Checked ? 0 : decimal.Parse(textBoxWeight.Text);
            FormEditOrder.order.OrderDetail.ExactAmount = checkBoxExactAmount.Checked;
            FormEditOrder.order.OrderDetail.Amount = decimal.Parse(textBoxAmount.Text);
            this.Dispose();
        }

        private bool areTextBoxesClean()
        {
            string description = textBoxDescription.Text;
            bool amount = decimal.Parse(labelIndividualAmount.Text.Substring(2)) == 0;


            return string.IsNullOrEmpty(description) || amount;
        }

        private void textBoxWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = onlyNumbers(sender, e.KeyChar);
        }

        private void textBoxPriceKilo_KeyPress(object sender, KeyPressEventArgs e)
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
                labelIndividualAmount.Text = (string.IsNullOrEmpty(amount)) ? currencySymbolWithZero :
                    currencySymbol + amount;
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
            labelIndividualAmount.Text = currencySymbolWithZero;

            string textPriceKilo = textBoxPriceKilo.Text;
            string textWeight = textBoxWeight.Text;
            if (textPriceKilo == "." || textWeight == ".")
            {
                return;
            }

            if (!string.IsNullOrWhiteSpace(textPriceKilo) && !string.IsNullOrWhiteSpace(textWeight))
            {
                decimal individualAmount = (decimal.Parse(textPriceKilo) * decimal.Parse(textWeight));
                textBoxAmount.Text = individualAmount.ToString();
                labelIndividualAmount.Text = currencySymbol + individualAmount;
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
            }
            else
            {
                labelPriceKilo.Text = notChecked;
                textBoxWeight.Enabled = true;
            }
            textBoxPriceKilo_TextChanged(textBoxPriceKilo, e);
        }

        public static void editOrder(LOrder order)
        {
            formEditOrder = new FormEditOrder(order);
            formEditOrder.ShowDialog();
        }
    }
}
