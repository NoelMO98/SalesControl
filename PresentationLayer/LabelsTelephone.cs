using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlVentas.PresentationLayer
{
    class LabelsTelephone: Label
    {
        public LabelsTelephone() : base()
        {
            Dock = System.Windows.Forms.DockStyle.Fill;
            Font = new System.Drawing.Font("Segoe UI", 12F);
            ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            Size = new System.Drawing.Size(150, 45);
            TextAlign = System.Drawing.ContentAlignment.BottomLeft;
        }

        public void SetText(int number) {
            Text = "Télefono "+number+":";
        }
    }
}
