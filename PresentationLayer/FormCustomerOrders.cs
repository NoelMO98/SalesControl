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
    public partial class FormCustomerOrders : Form
    {
        const string tagTotalGain = "GANANCIA TOTAL:", tagAll = "Todas", tagByYear = "Por año";
        private Form formParent = null;
        private LCustomer customer = null;
        private List<IBusinessObject> customerOrders = null;
        private decimal totalRemainder;
        private decimal totalGain;
        public FormCustomerOrders()
        {
            InitializeComponent();
            ColumnOrderOrDate.Visible = false;
        }
        public FormCustomerOrders(LCustomer customer, Form parent) : this()
        {
            this.customer = customer;
            this.formParent = parent;

            ColumnCustomerNameOrGain.Visible = false;

            if (this.customer.Debtor && this.formParent.GetType().Name.Equals("FormFilteredCustomers"))
            {
                this.customerOrders = new LUnpaidOrder().select(this.customer);
                fillDataGridView(this.customerOrders);
                radioButtonByYearOrAll.Text = tagAll;
            }
            else
            {
                this.customerOrders = new LOrder().selectOrdersPaid(this.customer);
                panelControls.Visible = false;
                ColumnRemainder.Visible = false;
                fillDataGridView(this.customerOrders
                .Where(order => ((LOrder)order).Date.Year == DateTime.Now.Year).Cast<IBusinessObject>().ToList());
                radioButtonByYearOrAll.Text = tagByYear;
            }
        }

        public FormCustomerOrders(List<IBusinessObject> paidOrders, Form formParent) : this()
        {
            this.customerOrders = paidOrders;
            this.formParent = formParent;
            panelControls.Visible = false;
            ColumnRemainder.Visible = false;
            radioButtonByYearOrAll.Text = tagByYear;

            if (formParent.GetType().Name.Equals("FormMain"))
            {
                buttonBack.Visible = false;
                ColumnDescription.Visible = false;
                ColumnAmount.Visible = false;
                ColumnCustomerNameOrGain.HeaderText = "Ganancia";
            }
            if (formParent.GetType() == this.GetType())
            {
                panelSide.Visible = false;
                ColumnCustomerNameOrGain.HeaderText = "Cliente";
            }
            fillDataGridView(this.customerOrders);
        }
        private void fillDataGridView(List<IBusinessObject> customerOrders)
        {
            dataGridViewCustomerOrders.Rows.Clear();
            if (customerOrders.Count == 0)
            {
                if (this.customer != null && this.customer.Debtor && this.formParent.GetType().Name.Equals("FormFilteredCustomers"))
                {
                    this.totalRemainder = decimal.Zero;
                    labelTotalRemainder.Text = totalRemainder.ToString("C2");
                }
                return;
            }

            if (this.customer == null)
            {
                if (this.FormParent.GetType().Name.Equals(this.GetType().Name))
                {
                    addCustomerOrders(customerOrders);
                    addGainRow();
                    return;
                }
                addDateGroup(customerOrders);
                addGainRow();
            }
            else
            {
                addCustomerOrders(customerOrders);
                if (this.customer.Debtor && this.formParent.GetType().Name.Equals("FormFilteredCustomers"))
                {
                    labelTotalRemainder.Text = totalRemainder.ToString("C2");
                }
                else
                {
                    addGainRow();
                }

            }
        }

        private void addCustomerOrders(List<IBusinessObject> customerOrders)
        {
            this.totalRemainder = this.totalGain = decimal.Zero;
            int indexRow;
            DataGridViewRow row;
            foreach (IBusinessObject order in customerOrders)
            {
                indexRow = dataGridViewCustomerOrders.Rows.Add();
                row = dataGridViewCustomerOrders.Rows[indexRow];
                if (order.GetType().Name.Equals("LUnpaidOrder"))
                {
                    row.Cells[ColumnOrderOrDate.Name].Value = order;
                    row.Cells[ColumnDate.Name].Value = ((LUnpaidOrder)order).Date.ToString("dd MMM yyyy h:mm tt");
                    row.Cells[ColumnDescription.Name].Value = ((LUnpaidOrder)order).Description;
                    row.Cells[ColumnAmount.Name].Value = ((LUnpaidOrder)order).OrderDetail.Amount.ToString("C2");
                    row.Cells[ColumnRemainder.Name].Value = ((LUnpaidOrder)order).Remainder.ToString("C2");

                    this.totalRemainder += ((LUnpaidOrder)order).Remainder;
                }
                else if (order.GetType().Name.Equals("LOrder"))
                {
                    row.Cells[ColumnOrderOrDate.Name].Value = order;
                    row.Cells[ColumnDate.Name].Value = ((LOrder)order).Date.ToString("dd MMM yyyy h:mm tt");
                    row.Cells[ColumnCustomerNameOrGain.Name].Value = ((LOrder)order).Customer.Name;
                    row.Cells[ColumnDescription.Name].Value = ((LOrder)order).Description;
                    row.Cells[ColumnAmount.Name].Value = ((LOrder)order).OrderDetail.Amount.ToString("C2");
                    this.totalGain += ((LOrder)order).OrderDetail.Amount;
                }
            }
        }

        private void addDateGroup(List<IBusinessObject> customerOrders)
        {
            this.totalGain = 0;
            var ordersGroups = customerOrders.GroupBy(order => ((LOrder)order).Date.Date);
            foreach (var group in ordersGroups)
            {
                decimal gainByDate = 0;
                foreach (LOrder order in group)
                {
                    gainByDate += order.OrderDetail.Amount;
                }
                int indexRow = dataGridViewCustomerOrders.Rows.Add();
                DataGridViewRow row = dataGridViewCustomerOrders.Rows[indexRow];
                row.Cells[ColumnDate.Name].Value = group.Key.ToShortDateString();
                row.Cells[ColumnOrderOrDate.Name].Value = group.Key;
                row.Cells[ColumnCustomerNameOrGain.Name].Value = gainByDate.ToString("C2");

                totalGain += gainByDate;
            }
        }

        private int gainRowIndex;
        private void addGainRow()
        {
            gainRowIndex = dataGridViewCustomerOrders.Rows.Add();
            DataGridViewRow row = dataGridViewCustomerOrders.Rows[gainRowIndex];
            if (this.customer != null
                || this.formParent.GetType() == this.GetType())
            {
                row.Cells[ColumnDescription.Name].Value = tagTotalGain;
                row.Cells[ColumnDescription.Name].Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                row.Cells[ColumnAmount.Name].Value = totalGain.ToString("C2");
            }
            else if (formParent.GetType().Name.Equals("FormMain"))
            {
                row.Cells[ColumnDate.Name].Value = tagTotalGain;
                row.Cells[ColumnDate.Name].Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                row.Cells[ColumnCustomerNameOrGain.Name].Value = totalGain.ToString("C2");
            }
        }

        public Form getFormUpdated()
        {
            if (this.customer.Debtor && new LUnpaidOrder().select(this.customer).Count == 0)
            {
                if (updateCustomerToRegularCustomer())
                {
                    if (formParent.GetType().Name.Equals("FormCustomers"))
                    {
                        return new FormCustomers();
                    }
                    if (formParent.GetType().Name.Equals("FormFilteredCustomers"))
                    {
                        return new FormFilteredCustomers(new LCustomer().select(true));
                    }
                }
            }
            return new FormCustomerOrders(this.customer, FormParent);
        }

        public Form FormParent { get { return this.formParent; } }

        private bool updateCustomerToRegularCustomer()
        {
            LCustomer updatedCustomer = new LCustomer(this.customer);
            updatedCustomer.Debtor = false;
            if (this.customer.update(updatedCustomer))
            {
                return true;
            }
            return false;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormMain.setFormToPanel(this.FormParent);
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

        public void updateDataGridViewUnpaidOrders()
        {
            fillDataGridView(customerOrders);
        }

        private void dataGridViewCustomerOrders_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewCustomerOrders.Rows.Count == 0
                || (this.customer != null && (!this.customer.Debtor || (this.customer.Debtor && this.formParent.GetType().Name.Equals("FormCustomers"))))
                || (dataGridViewCustomerOrders.CurrentCell.RowIndex == gainRowIndex && this.customer == null)
                || this.FormParent.GetType() == this.GetType())
                return;
            if (this.customer != null && this.customer.Debtor)
            {
                FormMain.setFormToPanel(new FormAccumulatedAmounts((LUnpaidOrder)dataGridViewCustomerOrders.SelectedCells[ColumnOrderOrDate.Index].Value, this));
            }
            if (this.customer == null)
            {
                DateTime date = (DateTime)dataGridViewCustomerOrders.SelectedCells[ColumnOrderOrDate.Index].Value;
                FormMain.setFormToPanel(new FormCustomerOrders(
                    this.customerOrders.Where(order => ((LOrder)order).Date.Date.CompareTo(date) == 0).Cast<IBusinessObject>().ToList(), this));
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

                decimal change = decimal.Parse(textAmountReceived) - totalRemainder;
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

            processUnpaidOrders();
        }

        private void processUnpaidOrders()
        {
            decimal amountReceived = decimal.Parse(textAmountReceived);
            if (amountReceived >= this.totalRemainder)
            {
                deleteAllUnpaidOrders();
                if (updateCustomerToRegularCustomer())
                {
                    if (formParent.GetType().Name.Equals("FormCustomers"))
                    {
                        FormMain.setFormToPanel(new FormCustomers());
                    }
                    if (formParent.GetType().Name.Equals("FormFilteredCustomers"))
                    {
                        FormMain.setFormToPanel(new FormFilteredCustomers(new LCustomer().select(true)));
                    }
                }
                return;
            }

            foreach (var unpaidOrder in this.customerOrders)
            {
                if (amountReceived >= ((LUnpaidOrder)unpaidOrder).Remainder)
                {
                    if (((LUnpaidOrder)unpaidOrder).delete())
                    {
                        amountReceived -= ((LUnpaidOrder)unpaidOrder).Remainder;
                    }
                }
                else
                {
                    LAccumulatedAmount accumulatedAmount = new LAccumulatedAmount(((LUnpaidOrder)unpaidOrder).ID, amountReceived, DateTime.Now);
                    if (accumulatedAmount.insert())
                    {
                        ((LUnpaidOrder)unpaidOrder).AccumulatedAmounts.Add(accumulatedAmount);
                        LUnpaidOrder updatedUnpaidOrder = new LUnpaidOrder(((LUnpaidOrder)unpaidOrder));
                        updatedUnpaidOrder.Remainder -= accumulatedAmount.Amount;
                        unpaidOrder.update(updatedUnpaidOrder);
                        textBoxAmountReceived.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Error al procesar compra\nIntente nuevamente");
                    }
                }
            }
            this.customerOrders = new LUnpaidOrder().select(this.customer);
            fillDataGridView(customerOrders);
        }

        private void deleteAllUnpaidOrders()
        {
            foreach (var unpaidOrder in customerOrders)
            {
                unpaidOrder.delete();
            }
            customerOrders.Clear();
        }


        private void radioButtonByYearOrAll_Click(object sender, EventArgs e)
        {
            monthCalendar.MaxSelectionCount = 1;
            monthCalendar.SelectionStart = DateTime.Now.Date;
            if (radioButtonByYearOrAll.Text.Equals(tagAll))
            {
                fillDataGridView(customerOrders);
            }
            if (radioButtonByYearOrAll.Text.Equals(tagByYear))
            {
                int monthCalendarYear = monthCalendar.SelectionStart.Year;
                fillDataGridView(customerOrders.Where(order => ((LOrder)order).Date.Year == monthCalendarYear)
                    .Cast<IBusinessObject>().ToList());
            }
            radioButtonByYearOrAll.Checked = true;
        }

        private void radioButtonByDay_Click(object sender, EventArgs e)
        {
            monthCalendar.MaxSelectionCount = 1;
            monthCalendar.SelectionStart = DateTime.Now.Date;
            fillDataGridView(customerOrders
                .Where(order => ((LOrder)order).Date.Date.CompareTo(monthCalendar.SelectionStart.Date) == 0)
                .Cast<IBusinessObject>().ToList());
        }

        private void radioButtonByWeek_Click(object sender, EventArgs e)
        {
            monthCalendar.MaxSelectionCount = 7;
            selectByWeek();
            fillDataGridView(this.customerOrders
                .Where(order => ((LOrder)order).Date.Date.CompareTo(monthCalendar.SelectionStart.Date) >= 0
                && ((LOrder)order).Date.Date.CompareTo(monthCalendar.SelectionEnd.Date) <= 0)
                .Cast<IBusinessObject>().ToList());
        }



        private void monthCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            if (radioButtonByYearOrAll.Checked)
            {
                //    monthCalendar.MaxSelectionCount = 1;
                //    radioButtonByDay.Checked = true;
                int monthCalendarYear = monthCalendar.SelectionStart.Year;
                fillDataGridView(customerOrders.Where(order => ((LOrder)order).Date.Year == monthCalendarYear)
                    .Cast<IBusinessObject>().ToList());
                return;
            }
            if (radioButtonByWeek.Checked)
            {
                selectByWeek();
            }
            fillDataGridView(this.customerOrders
                .Where(order => ((LOrder)order).Date.Date.CompareTo(monthCalendar.SelectionStart.Date) >= 0
                && ((LOrder)order).Date.Date.CompareTo(monthCalendar.SelectionEnd.Date) <= 0)
                .Cast<IBusinessObject>().ToList());
        }

        private void selectByWeek()
        {
            DateTime dateSelected = monthCalendar.SelectionStart.Date;
            DateTime dateStart = DateTime.Now.Date;
            DateTime dateEnd = DateTime.Now.Date;
            switch (dateSelected.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    dateStart = dateSelected;
                    dateEnd = dateSelected.AddDays((double)(7 - DayOfWeek.Monday));
                    break;
                case DayOfWeek.Tuesday:
                    dateStart = dateSelected.AddDays(((double)(DayOfWeek.Tuesday - DayOfWeek.Monday)) * -1);
                    dateEnd = dateSelected.AddDays((double)(7 - DayOfWeek.Tuesday));
                    break;
                case DayOfWeek.Wednesday:
                    dateStart = dateSelected.AddDays(((double)(DayOfWeek.Wednesday - DayOfWeek.Monday)) * -1);
                    dateEnd = dateSelected.AddDays((double)(7 - DayOfWeek.Wednesday));
                    break;
                case DayOfWeek.Thursday:
                    dateStart = dateSelected.AddDays(((double)(DayOfWeek.Thursday - DayOfWeek.Monday)) * -1);
                    dateEnd = dateSelected.AddDays((double)(7 - DayOfWeek.Thursday));
                    break;
                case DayOfWeek.Friday:
                    dateStart = dateSelected.AddDays(((double)(DayOfWeek.Friday - DayOfWeek.Monday)) * -1);
                    dateEnd = dateSelected.AddDays((double)(7 - DayOfWeek.Friday));
                    break;
                case DayOfWeek.Saturday:
                    dateStart = dateSelected.AddDays(((double)(DayOfWeek.Saturday - DayOfWeek.Monday)) * -1);
                    dateEnd = dateSelected.AddDays((double)(7 - DayOfWeek.Saturday));
                    break;
                case DayOfWeek.Sunday:
                    dateStart = dateSelected.AddDays((7 - ((double)DayOfWeek.Monday)) * -1);
                    dateEnd = dateSelected;
                    break;
            }
            SelectionRange range = new SelectionRange(dateStart, dateEnd);
            monthCalendar.SelectionRange = range;
        }
    }
}
