using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlVentas.PresentationLayer
{
    class BackgroundPanel : System.Windows.Forms.Panel
    {
        private MaskedTextBoxesTelephone maskedText;
        public BackgroundPanel() : base()
        {
            BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            //TODO revisar la caja
            maskedText = new MaskedTextBoxesTelephone();
            Controls.Add(maskedText);
            Dock = System.Windows.Forms.DockStyle.Top;
            Size = new System.Drawing.Size(144, 24);
        }

        public MaskedTextBoxesTelephone MaskedText { get { return maskedText; } }
    }
}
