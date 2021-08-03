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
    public partial class FormReminder : Form
    {
        private List<IBusinessObject> orders;
        private Form formParent = null;

        public FormReminder()
        {
            InitializeComponent();
            autocompleteComboBoxCustomer();
            orders = new List<IBusinessObject>();
        }
        public FormReminder(List<IBusinessObject> orders) : this()
        {
            this.orders = orders;
            fillDataGridView(this.orders.Cast<LOrder>().ToList());
        }

        public FormReminder(List<IBusinessObject> orders, Form parent) : this()
        {
            this.orders = orders;
            this.formParent = parent;

            buttonBack.Visible = true;
            buttonMenu.Visible = false;
            fillDataGridView(this.orders.Cast<LOrder>().ToList());
        }

        private void autocompleteComboBoxCustomer()
        {
            List<LCustomer> customersList = new LCustomer().select().Cast<LCustomer>().ToList();
            comboBoxCustomer.DataSource = customersList;
            comboBoxCustomer.DisplayMember = "Name";
            comboBoxCustomer.AutoCompleteCustomSource.Clear();
            customersList.ForEach(customer => comboBoxCustomer.AutoCompleteCustomSource.Add(((LCustomer)customer).Name));
        }

        private void fillDataGridView(List<LOrder> orderList)
        {
            List<LOrder> sortedList = orderList.OrderBy(order => order.Date).Cast<LOrder>().ToList();
            dataGridViewOrders.Rows.Clear();
            foreach (LOrder order in sortedList)
            {
                dataGridViewOrders.Rows.Add(order, order.Date.ToShortDateString(), order.Customer.Name, order.Description);
            }
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

            LOrder order = (LOrder)dataGridViewOrders.SelectedCells[ColumnOrder.Index].Value;
            if (dataGridViewOrders.CurrentCell.ColumnIndex == ColumnEdit.Index)
            {
                setOrderToEdit(order);
            }
            else if (dataGridViewOrders.CurrentCell.ColumnIndex == ColumnDelete.Index)
            {
                DialogResult result = MessageBox.Show($"Desea eliminar al pedido del cliente {order.Customer.Name}?", "Eliminando pedido", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    deleteOrder(order);
                    if(this.formParent != null)
                    {
                        FormMain.updateOrdersFromReminders();
                    }
                }
            }
        }

        private LOrder orderSelectedToEdit;
        private bool editingProcess = false;
        private void setOrderToEdit(LOrder order)
        {
            comboBoxCustomer.SelectedItem = order.Customer;
            textBoxDescription.Text = order.Description;
            dateTimePickerReminderDate.Value = order.Date;
            editingProcess = true;
            buttonSave.Text = "Guardar cambios";
            this.orderSelectedToEdit = order;
            showPanelSide();
        }

        private void deleteOrder(LOrder order)
        {
            if (order.delete())
            {
                this.orders.Remove(order);
                if (this.editingProcess && this.orderSelectedToEdit.Equals(order))
                {
                    this.editingProcess = false;
                    buttonSave.Text = "Guardar";
                }
                fillDataGridView(this.orders.Cast<LOrder>().ToList());
            }
            else
            {
                MessageBox.Show($"Error al eliminar al pedido {order.Description}");
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (areTextBoxesClean())
            {
                MessageBox.Show("Complete todos los campos");
                return;
            }

            LCustomer customer = (LCustomer)comboBoxCustomer.SelectedItem;
            string description = textBoxDescription.Text;
            DateTime date = dateTimePickerReminderDate.Value.Date;
            LOrder newOrder = new LOrder(editingProcess ? this.orderSelectedToEdit.ID : 0, description, date, customer);
            if (newOrder.Date.CompareTo(DateTime.Now.Date) < 0)
            {
                MessageBox.Show("Utilice una fecha mayor o igual a la actual");
                return;
            }

            if (this.editingProcess)
            {
                updateOrder(newOrder);
                if (this.formParent != null)
                {
                    FormMain.updateOrdersFromReminders();
                    panelSide.Visible = false;
                }
                return;
            }

            if (newOrder.insert())
            {
                this.orders.Add(newOrder);
                defaultValues();
                fillDataGridView(this.orders.Cast<LOrder>().ToList());
            }
            else
            {
                MessageBox.Show("Ocurrio un error");
            }
        }

        private void updateOrder(LOrder newOrder)
        {
            if (!newOrder.Equals(this.orderSelectedToEdit))
            {
                if (this.orderSelectedToEdit.update(newOrder))
                {
                    this.orders.Remove(this.orderSelectedToEdit);
                    this.orders.Add(newOrder);
                    fillDataGridView(this.orders.Cast<LOrder>().ToList());
                }
                else
                {
                    MessageBox.Show($"Error al modificar el pedido del cliente {this.orderSelectedToEdit.Customer.Name}");
                    return;
                }
            }
            defaultValues();
            this.editingProcess = false;
            buttonSave.Text = "Guardar";
        }

        private bool areTextBoxesClean()
        {
            return string.IsNullOrEmpty(textBoxDescription.Text);
        }

        private void defaultValues()
        {
            comboBoxCustomer.SelectedIndex = 0;
            textBoxDescription.Clear();
            dateTimePickerReminderDate.Value = DateTime.Now;
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            panelSide.Visible = !panelSide.Visible;
        }

        private void showPanelSide()
        {
            if (!panelSide.Visible)
            {
                panelSide.Visible = true;
            }
        }

        private void buttonMenu_MouseHover(object sender, EventArgs e)
        {
            changeButtonColorWithoutBorder(true, buttonMenu);
        }

        private void buttonMenu_MouseLeave(object sender, EventArgs e)
        {
            changeButtonColorWithoutBorder(false, buttonMenu);
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

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string searcher = textBoxSearch.Text;
            if (string.IsNullOrEmpty(searcher))
            {
                fillDataGridView(this.orders.Cast<LOrder>().ToList());
                return;
            }
            if (this.formParent != null)
            {
                fillDataGridView(LOrder.searcher(searcher).Where(order => this.orders.Contains(order))
                    .Cast<LOrder>().ToList());
            }
            else
            {
                fillDataGridView(LOrder.searcher(searcher).Cast<LOrder>().ToList());
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormMain.setFormToPanel(this.formParent);
            this.Dispose();
        }

        private void buttonBack_MouseHover(object sender, EventArgs e)
        {
            changeButtonColorWithoutBorder(true, (Button)sender);
        }

        private void buttonBack_MouseLeave(object sender, EventArgs e)
        {
            changeButtonColorWithoutBorder(false, (Button)sender);
        }

        private void dataGridViewOrders_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewOrders.Rows.Count == 0)
            {
                return;
            }
            LOrder selectedOrder = (LOrder) dataGridViewOrders.SelectedCells[ColumnOrder.Index].Value;
            FormMain.setFormToPanel(new FormToSell(selectedOrder));
            this.Dispose();
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
                    customerName = FormNewCustomer.newCustomer(customerNameNotFound);
                    if (!string.IsNullOrEmpty(customerName))
                    {
                        autocompleteComboBoxCustomer();
                        comboBoxCustomer.Text = customerName;
                        return;
                    }
                }
                if (dialog != DialogResult.Yes || string.IsNullOrEmpty(customerName))
                {
                    string generalSale = "VENTA GENERAL";
                    comboBoxCustomer.Text = generalSale;
                }
            }
        }
    }
}
