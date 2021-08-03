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
    public partial class FormEndSale : Form
    {
        private decimal totalAmount;
        private List<LOrder> orderList = null;
        private static FormEndSale formEndSale;
        private static bool sucess;
        private const string generalSale = "VENTA GENERAL";
        private bool isGeneralSale = false;
        public FormEndSale()
        {
            InitializeComponent();
        }

        public FormEndSale(List<LOrder> orderList) : this()
        {
            this.orderList = orderList;
            this.totalAmount = getTotalAmount();
            labelTotalAmount.Text = totalAmount.ToString("C2");
            textBoxChange.Text = decimal.Zero.ToString("C2");
        }

        private decimal getTotalAmount()
        {
            decimal totalAmount = 0;
            foreach (var order in this.orderList)
            {
                if (order.Customer.Name.Equals(generalSale))
                {
                    isGeneralSale = true;
                }
                totalAmount += order.OrderDetail.Amount;
            }
            return totalAmount;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            sucess = false;
            this.Dispose();
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
                decimal change = decimal.Parse(textAmountReceived) - totalAmount;
                labelChange.Text = change < 0 ? "Resto:" : "Cambio:";
                change = change < 0 ? change *= -1 : change;
                textBoxChange.Text = change.ToString("C2");
            }
        }

        private void buttonEndSale_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textAmountReceived))
            {
                MessageBox.Show("Complete todos los campos");
                return;
            }

            if (processOrder())
            {
                sucess = true;
            }

            this.Dispose();
        }

        private bool processOrder()
        {
            decimal temp = decimal.Parse(textAmountReceived);
            if (isGeneralSale && temp < this.totalAmount)
            {
                MessageBox.Show($"No se puede pagar menos del importe total en una {generalSale}");
                return false;
            }
            foreach (LOrder order in orderList)
            {
                if (order.ID != 0)
                {
                    if (!order.update(new LOrder(order)))
                    {
                        MessageBox.Show("Error al procesar compra\nIntente nuevamente");
                        return false;
                    }
                }
                else
                {
                    if (!order.insert())
                    {
                        MessageBox.Show("Error al procesar compra\nIntente nuevamente");
                        return false;
                    }
                }
                if (temp >= order.OrderDetail.Amount)
                {
                    temp -= order.OrderDetail.Amount;
                }
                else
                {
                    new LUnpaidOrder(order, (order.OrderDetail.Amount - temp)).insert();
                    LCustomer newCustomer = new LCustomer(order.Customer);
                    newCustomer.Debtor = true;
                    order.Customer.update(newCustomer);
                    temp -= temp;
                }
            }
            return true;
        }

        public static bool endSale(List<LOrder> orderList)
        {
            formEndSale = new FormEndSale(orderList);
            formEndSale.ShowDialog();

            return sucess;
        }
    }
}
