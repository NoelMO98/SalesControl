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
    public partial class FormAccumulatedAmounts : Form
    {
        private Form formParent = null;
        private LUnpaidOrder unpaidOrder;
        public FormAccumulatedAmounts()
        {
            InitializeComponent();
        }
        public FormAccumulatedAmounts(LUnpaidOrder unpaidOrder, Form parent) : this()
        {
            this.unpaidOrder = unpaidOrder;
            this.formParent = parent;
            this.labelRemainder.Text = this.unpaidOrder.Remainder.ToString("C2");
            fillDataGridView(this.unpaidOrder.AccumulatedAmounts);
            textBoxChange.Text = decimal.Zero.ToString("C2");
        }

        private void fillDataGridView(List<LAccumulatedAmount> accumulatedAmounts)
        {
            dataGridViewAccumulatedAmounts.Rows.Clear();
            foreach (LAccumulatedAmount accumulatedAmount in accumulatedAmounts)
            {
                dataGridViewAccumulatedAmounts.Rows.Add(accumulatedAmount.Date, accumulatedAmount.Amount.ToString("C2"));
            }
        }

        private void textBoxAmountReceived_KeyPress(object sender, KeyPressEventArgs e)
        {
            char input = e.KeyChar;
            if (!char.IsControl(input) && !char.IsDigit(input) && (input != '.'))
            {
                e.Handled = true;
            }

            bool existingPoint = ((TextBox)sender).Text.IndexOf('.') > -1;

            if ((input == '.') && existingPoint)
            {
                e.Handled = true;
            }
        }

        private string textAmountReceived;
        private void textBoxAmountReceived_TextChanged(object sender, EventArgs e)
        {
            textBoxChange.Text = decimal.Zero.ToString("C2");
            textAmountReceived = textBoxAmountReceived.Text;
            if (!string.IsNullOrEmpty(textAmountReceived))
            {
                if (textAmountReceived == ".")
                {
                    return;
                }
                
                decimal change = decimal.Parse(textAmountReceived) - this.unpaidOrder.Remainder;
                labelChange.Text = change < 0 ? "Resto:" : "Cambio:";
                change = change < 0 ? change *= -1 : change;
                textBoxChange.Text = change.ToString("C2");

            }
        }

        private void buttonCredit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textAmountReceived))
            {
                MessageBox.Show("Complete todos los campos");
                return;
            }

            processOrder();
        }

        private void processOrder()
        {
            decimal temp = decimal.Parse(textAmountReceived);

            if (temp >= this.unpaidOrder.Remainder)
            {
                if (unpaidOrder.delete())
                {
                    FormMain.setFormToPanel(((FormCustomerOrders)formParent).getFormUpdated());
                }
                return;
            }
            LAccumulatedAmount accumulatedAmount = new LAccumulatedAmount(unpaidOrder.ID, temp, DateTime.Now);
            if (accumulatedAmount.insert())
            {
                unpaidOrder.AccumulatedAmounts.Add(accumulatedAmount);
                LUnpaidOrder updatedUnpaidOrder = new LUnpaidOrder(unpaidOrder);
                updatedUnpaidOrder.Remainder -= accumulatedAmount.Amount;
                if (unpaidOrder.update(updatedUnpaidOrder))
                {
                    dataGridViewAccumulatedAmounts.Rows.Add(accumulatedAmount.Date, accumulatedAmount.Amount.ToString("C2"));
                }
                this.labelRemainder.Text = this.unpaidOrder.Remainder.ToString("C2");
                textBoxAmountReceived.Clear();
            }
            else
            {
                MessageBox.Show("Error al procesar compra\nIntente nuevamente");
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormMain.setFormToPanel(this.formParent);
            this.Close();
        }

        private void buttonBack_MouseHover(object sender, EventArgs e)
        {
            changeButtonColorWithoutBorder(true, (Button)sender);
        }

        private void buttonBack_MouseLeave(object sender, EventArgs e)
        {
            changeButtonColorWithoutBorder(false, (Button)sender);
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

        private void FormAccumulatedAmounts_FormClosing(object sender, FormClosingEventArgs e)
        {
            ((FormCustomerOrders)formParent).updateDataGridViewUnpaidOrders();
        }
    }
}
