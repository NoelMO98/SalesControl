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
    public partial class FormMain : Form
    {
        private static List<IBusinessObject> orders;
        public FormMain()
        {
            InitializeComponent();
            hideSubMenus();
            orders = new LOrder().select();
            activatedButtonColors(buttonToSell);
            openChildForm(new FormToSell());
        }

        private void buttonToSell_Click(object sender, EventArgs e)
        {
            hideSubMenus();
            activatedButtonColors(buttonToSell);
            openChildForm(new FormToSell());
        }

        private void buttonReminders_Click(object sender, EventArgs e)
        {
            hideSubMenus();
            activatedButtonColors(buttonReminders);
            openChildForm(new FormReminder(orders = new LOrder().select()));
        }

        private void buttonCustomers_Click(object sender, EventArgs e)
        {
            defaultButtonColors();
            defaultChildButtonColors();
            showSubMenu(panelCustomers);
            activatedButtonColors(buttonCustomers);
            openChildForm(new FormCustomers());
        }

        private void buttonSales_Click(object sender, EventArgs e)
        {
            hideSubMenus();
            activatedButtonColors(buttonSales);
            openChildForm(new FormCustomerOrders(new LOrder().selectOrdersPaid(), this));
        }

        private void buttonRegularCustomers_Click(object sender, EventArgs e)
        {
            defaultChildButtonColors();
            activatedChildButtonColors(buttonRegularCustomers);
            openChildForm(new FormFilteredCustomers(new LCustomer().select(false)));
        }

        private void buttonIrregularCustomers_Click(object sender, EventArgs e)
        {
            defaultChildButtonColors();
            activatedChildButtonColors(buttonIrregularCustomers);
            openChildForm(new FormFilteredCustomers(new LCustomer().select(true)));
        }

        private void showSubMenu(ContainerControl subMenuPanel)
        {
            subMenuPanel.Visible = true;
        }

        private void hideSubMenus()
        {
            panelCustomers.Visible = false;
            defaultButtonColors();
            defaultChildButtonColors();
        }

        private void defaultButtonColors()
        {
            Color baseColor1 = Color.FromArgb(31, 40, 39);
            Color baseColor2 = Color.FromArgb(31, 36, 33);

            buttonToSell.BaseColor1 = baseColor1;
            buttonToSell.BaseColor2 = baseColor2;
            buttonReminders.BaseColor1 = baseColor1;
            buttonReminders.BaseColor2 = baseColor2;
            buttonCustomers.BaseColor1 = baseColor1;
            buttonCustomers.BaseColor2 = baseColor2;
            buttonSales.BaseColor1 = baseColor1;
            buttonSales.BaseColor2 = baseColor2;
        }

        private void defaultChildButtonColors()
        {
            Color baseChildColor1 = Color.FromArgb(29, 49, 55);
            Color baseChildColor2 = Color.FromArgb(30, 46, 50);

            buttonRegularCustomers.BaseColor1 = baseChildColor1;
            buttonRegularCustomers.BaseColor2 = baseChildColor2;
            buttonIrregularCustomers.BaseColor1 = baseChildColor1;
            buttonIrregularCustomers.BaseColor2 = baseChildColor2;
        }

        private void activatedButtonColors(Guna.UI.WinForms.GunaGradientButton button)
        {
            Color baseColor1 = Color.FromArgb(27, 61, 76);
            Color baseColor2 = Color.FromArgb(30, 46, 50);

            button.BaseColor1 = baseColor1;
            button.BaseColor2 = baseColor2;
        }

        private void activatedChildButtonColors(Guna.UI.WinForms.GunaGradientButton button)
        {
            Color baseColor = Color.FromArgb(80, 125, 116);

            button.BaseColor1 = baseColor;
            button.BaseColor2 = baseColor;
        }

        private static Form contentForm = null;
        private static void openChildForm(Form childForm)
        {
            if (contentForm != null)
            {
                contentForm.Close();
            }
            contentForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelContent.Controls.Add(childForm);
            panelContent.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        public static void setFormToPanel(Form form)
        {
            contentForm = null;
            openChildForm(form);
        }

        private void timerDateTime_Tick(object sender, EventArgs e)
        {
            labelDate.Text = DateTime.Now.ToShortDateString();
            labelTime.Text = DateTime.Now.ToShortTimeString();
            int numberOfUpcomingDates = upcomingDates().Count;
            labelNotification.Text = numberOfUpcomingDates != 0 ? $"{numberOfUpcomingDates} pedidos próximos" : "Sin pedidos próximos";
        }

        private List<IBusinessObject> upcomingDates()
        {
            List<IBusinessObject> orders = new List<IBusinessObject>();
            foreach (LOrder order in FormMain.orders)
            {
                DateTime nextDate = DateTime.Now.Date.AddDays(1);
                if (order.Date.Date.CompareTo(nextDate) <= 0 && order.Date.Date.CompareTo(DateTime.Now.Date) >= 0)
                {
                    orders.Add(order);
                }
            }
            return orders;
        }

        private void labelNotification_Click(object sender, EventArgs e)
        {
            setFormToPanel(new FormReminder(upcomingDates(), contentForm));
        }

        public static void updateOrdersFromReminders()
        {
            FormMain.orders = new LOrder().select();
        }
    }
}
