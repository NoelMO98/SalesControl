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
    public partial class FormSalesControl : Form
    {
        private decimal totalRemainder;
        private const string totalGain = "GANANCIA TOTAL";
        public FormSalesControl()
        {
            InitializeComponent();
        }

        private void fillDataGridView(List<LOrder> orderList)
        {
            totalRemainder = 0;
            dataGridViewOrders.Rows.Clear();
            var ordersGroups = orderList.GroupBy(order => ((LOrder)order).Date.Date);
            foreach (var group in ordersGroups)
            {
                object[] values;
                decimal gainByDate = 0;
                foreach (LOrder order in group)
                {
                    gainByDate += order.OrderDetail.Amount;
                }
                values = new object[] { group.Key, gainByDate, group.Count() };
                dataGridViewOrders.Rows.Add(values);
                totalRemainder += gainByDate;
            }
            dataGridViewOrders.Rows.Add(totalGain,totalRemainder);
            dataGridViewOrders.Rows[dataGridViewOrders.Rows.Count - 1].Cells[0].Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewOrders.Rows[dataGridViewOrders.Rows.Count - 1].Cells[1].Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
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

        private void radioButtonAll_Click(object sender, EventArgs e)
        {
            monthCalendar.MaxSelectionCount = 1;
            monthCalendar.SelectionStart = DateTime.Now.Date;
            fillDataGridView(new LOrder().selectOrdersPaid().Cast<LOrder>().ToList());
            radioButtonAll.Checked = true;
        }

        private void radioButtonWeek_Click(object sender, EventArgs e)
        {
            monthCalendar.MaxSelectionCount = 7;

            selectByWeek();
        }

        private void radioButtonDay_Click(object sender, EventArgs e)
        {
            monthCalendar.MaxSelectionCount = 1;
            DateTime now = DateTime.Now.Date;
            if (now.CompareTo(monthCalendar.SelectionStart)==0)
            {
                fillDataGridView(new LOrder().selectOrdersPaid()
                .Where(order => ((LOrder)order).Date.Date.CompareTo(monthCalendar.SelectionStart) == 0).Cast<LOrder>().ToList());
            }
            else
            {
                monthCalendar.SelectionStart = DateTime.Now.Date;
            }
        }
        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            if (radioButtonByWeek.Checked)
            {
                selectByWeek();
            }
            if (radioButtonAll.Checked)
            {
                monthCalendar.MaxSelectionCount = 1;
                radioButtonByDay.Checked = true;
            }
            fillDataGridView(new LOrder().selectOrdersPaid()
                .Where(order => ((LOrder)order).Date.Date.CompareTo(monthCalendar.SelectionStart) >= 0
                && ((LOrder)order).Date.Date.CompareTo(monthCalendar.SelectionEnd) <= 0).Cast<LOrder>().ToList());
        }

        private void dataGridViewOrders_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewOrders.Rows.Count == 0 || dataGridViewOrders.CurrentCell.RowIndex == dataGridViewOrders.Rows.Count-1)
            {
                return;
            }

            MessageBox.Show("Es otra menos la última fila");
        }
    }
}
