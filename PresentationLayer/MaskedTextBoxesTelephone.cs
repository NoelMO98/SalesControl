using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlVentas.PresentationLayer
{
    class MaskedTextBoxesTelephone : MaskedTextBox
    {

        public MaskedTextBoxesTelephone() : base()
        {
            BackColor = System.Drawing.Color.White;
            BorderStyle = System.Windows.Forms.BorderStyle.None;
            Dock = System.Windows.Forms.DockStyle.Fill;
            Font = new System.Drawing.Font("Segoe UI", 12F);
            ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(36)))), ((int)(((byte)(33)))));
            Margin = new System.Windows.Forms.Padding(3, 3, 30, 3);
            Mask = "000-000-00-00";
            Size = new System.Drawing.Size(160, 29);
        }
        private static List<string> telephoneNumbers;
        public List<string> TelephoneNumbers { get { return telephoneNumbers; } set { telephoneNumbers = value; } }
        protected override void OnTextChanged(EventArgs e)
        {
            if((MaskFull && !telephoneNumbers.Contains(Text)) || Text.Equals("___-___-__-__"))
            {
                ForeColor = System.Drawing.Color.FromArgb(31, 36, 33);
            }
            else
            {
                ForeColor = System.Drawing.Color.FromArgb(214, 40, 40);
            }
        }

    }
}
