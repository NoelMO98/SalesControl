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
    public partial class FormNewCustomer : Form
    {
        private List<IBusinessObject> customersList = new List<IBusinessObject>();
        private List<string> telephoneNumbers = new List<string>();
        private static string name;
        public FormNewCustomer(string customerNameNotFoundname)
        {
            InitializeComponent();
            customersList = new LCustomer().select();
            setTelephoneNumbers();
            maskedTextBoxTelephone.TelephoneNumbers = telephoneNumbers;
            textBoxCustomer.Text = customerNameNotFoundname;
        }

        private void setTelephoneNumbers()
        {
            telephoneNumbers.Clear();
            customersList.ForEach(customer =>
            {
                telephoneNumbers.AddRange(((LCustomer)customer).getTelephoneNumbers());
            });
        }

        private void buttonNewTelephone_MouseLeave(object sender, EventArgs e)
        {
            changeButtonColorWithoutBorder(false, buttonNewTelephone);
        }

        private void buttonNewTelephone_MouseHover(object sender, EventArgs e)
        {
            changeButtonColorWithoutBorder(true, buttonNewTelephone);
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

        private int telephones = 1, column = 0, row = 0;
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

            LCustomer customer = new LCustomer(name, address, false);
            addTelephoneNumbersToCustomer(customer, telephone);
            if (customer.insert())
            {
                FormNewCustomer.name = name;
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Ocurrio un error");
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            name = string.Empty;
            this.Dispose();
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

                if (item.GetType().Name.Equals("BackgroundPanel"))//MaskedTextBoxesTelephone"))
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
        private static FormNewCustomer form;
        public static string newCustomer(string customerNameNotFound)
        {
            form = new FormNewCustomer(customerNameNotFound);
            form.ShowDialog();
            return name;
        }
    }
}
