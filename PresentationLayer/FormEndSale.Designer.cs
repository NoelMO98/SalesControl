
namespace ControlVentas.PresentationLayer
{
    partial class FormEndSale
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelC = new System.Windows.Forms.Panel();
            this.panelControls = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.labelTotalAmount = new System.Windows.Forms.Label();
            this.buttonEndSale = new Guna.UI.WinForms.GunaButton();
            this.buttonCancel = new Guna.UI.WinForms.GunaButton();
            this.textBoxAmountReceived = new System.Windows.Forms.TextBox();
            this.labelPriceKilo = new System.Windows.Forms.Label();
            this.labelChange = new System.Windows.Forms.Label();
            this.textBoxChange = new System.Windows.Forms.TextBox();
            this.panelC.SuspendLayout();
            this.panelControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelC
            // 
            this.panelC.AutoSize = true;
            this.panelC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(170)))), ((int)(((byte)(161)))));
            this.panelC.Controls.Add(this.panelControls);
            this.panelC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelC.Location = new System.Drawing.Point(0, 0);
            this.panelC.Name = "panelC";
            this.panelC.Size = new System.Drawing.Size(639, 183);
            this.panelC.TabIndex = 7;
            // 
            // panelControls
            // 
            this.panelControls.AutoSize = true;
            this.panelControls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(33)))), ((int)(((byte)(30)))));
            this.panelControls.ColumnCount = 4;
            this.panelControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.panelControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.panelControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.panelControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.panelControls.Controls.Add(this.label5, 1, 2);
            this.panelControls.Controls.Add(this.labelTotalAmount, 2, 2);
            this.panelControls.Controls.Add(this.buttonEndSale, 1, 4);
            this.panelControls.Controls.Add(this.buttonCancel, 2, 4);
            this.panelControls.Controls.Add(this.textBoxAmountReceived, 1, 1);
            this.panelControls.Controls.Add(this.labelPriceKilo, 0, 1);
            this.panelControls.Controls.Add(this.labelChange, 2, 1);
            this.panelControls.Controls.Add(this.textBoxChange, 3, 1);
            this.panelControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControls.Location = new System.Drawing.Point(0, 0);
            this.panelControls.Name = "panelControls";
            this.panelControls.Padding = new System.Windows.Forms.Padding(0, 15, 15, 0);
            this.panelControls.RowCount = 6;
            this.panelControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.panelControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.panelControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.panelControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.panelControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.panelControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.panelControls.Size = new System.Drawing.Size(639, 180);
            this.panelControls.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(110)))), ((int)(((byte)(185)))));
            this.label5.Location = new System.Drawing.Point(159, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 50);
            this.label5.TabIndex = 4;
            this.label5.Tag = "textBox1";
            this.label5.Text = "Importe total:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelTotalAmount
            // 
            this.panelControls.SetColumnSpan(this.labelTotalAmount, 2);
            this.labelTotalAmount.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelTotalAmount.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(120)))), ((int)(((byte)(210)))));
            this.labelTotalAmount.Location = new System.Drawing.Point(315, 75);
            this.labelTotalAmount.Name = "labelTotalAmount";
            this.labelTotalAmount.Size = new System.Drawing.Size(306, 50);
            this.labelTotalAmount.TabIndex = 14;
            this.labelTotalAmount.Tag = "textBox1";
            this.labelTotalAmount.Text = "$ 123456789";
            this.labelTotalAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonEndSale
            // 
            this.buttonEndSale.AnimationHoverSpeed = 0.07F;
            this.buttonEndSale.AnimationSpeed = 0.03F;
            this.buttonEndSale.BackColor = System.Drawing.Color.Transparent;
            this.buttonEndSale.BaseColor = System.Drawing.Color.Transparent;
            this.buttonEndSale.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(146)))), ((int)(((byte)(164)))));
            this.buttonEndSale.BorderSize = 1;
            this.buttonEndSale.DialogResult = System.Windows.Forms.DialogResult.None;
            this.buttonEndSale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonEndSale.FocusedColor = System.Drawing.Color.Empty;
            this.buttonEndSale.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEndSale.ForeColor = System.Drawing.Color.White;
            this.buttonEndSale.Image = null;
            this.buttonEndSale.ImageSize = new System.Drawing.Size(20, 20);
            this.buttonEndSale.Location = new System.Drawing.Point(159, 138);
            this.buttonEndSale.Name = "buttonEndSale";
            this.buttonEndSale.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.buttonEndSale.OnHoverBorderColor = System.Drawing.Color.White;
            this.buttonEndSale.OnHoverForeColor = System.Drawing.Color.White;
            this.buttonEndSale.OnHoverImage = null;
            this.buttonEndSale.OnPressedColor = System.Drawing.Color.Black;
            this.buttonEndSale.Radius = 5;
            this.buttonEndSale.Size = new System.Drawing.Size(150, 29);
            this.buttonEndSale.TabIndex = 17;
            this.buttonEndSale.Text = "Terminar";
            this.buttonEndSale.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.buttonEndSale.Click += new System.EventHandler(this.buttonEndSale_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.AnimationHoverSpeed = 0.07F;
            this.buttonCancel.AnimationSpeed = 0.03F;
            this.buttonCancel.BackColor = System.Drawing.Color.Transparent;
            this.buttonCancel.BaseColor = System.Drawing.Color.Transparent;
            this.buttonCancel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(146)))), ((int)(((byte)(164)))));
            this.buttonCancel.BorderSize = 1;
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.None;
            this.buttonCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCancel.FocusedColor = System.Drawing.Color.Empty;
            this.buttonCancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.ForeColor = System.Drawing.Color.White;
            this.buttonCancel.Image = null;
            this.buttonCancel.ImageSize = new System.Drawing.Size(20, 20);
            this.buttonCancel.Location = new System.Drawing.Point(315, 138);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.buttonCancel.OnHoverBorderColor = System.Drawing.Color.White;
            this.buttonCancel.OnHoverForeColor = System.Drawing.Color.White;
            this.buttonCancel.OnHoverImage = null;
            this.buttonCancel.OnPressedColor = System.Drawing.Color.Black;
            this.buttonCancel.Radius = 5;
            this.buttonCancel.Size = new System.Drawing.Size(150, 29);
            this.buttonCancel.TabIndex = 18;
            this.buttonCancel.Text = "Cancelar";
            this.buttonCancel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // textBoxAmountReceived
            // 
            this.textBoxAmountReceived.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(33)))), ((int)(((byte)(30)))));
            this.textBoxAmountReceived.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxAmountReceived.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxAmountReceived.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBoxAmountReceived.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.textBoxAmountReceived.Location = new System.Drawing.Point(159, 28);
            this.textBoxAmountReceived.Margin = new System.Windows.Forms.Padding(3, 3, 30, 3);
            this.textBoxAmountReceived.MaxLength = 8;
            this.textBoxAmountReceived.Name = "textBoxAmountReceived";
            this.textBoxAmountReceived.Size = new System.Drawing.Size(123, 29);
            this.textBoxAmountReceived.TabIndex = 6;
            this.textBoxAmountReceived.Tag = "";
            this.textBoxAmountReceived.TextChanged += new System.EventHandler(this.textBoxAmountReceived_TextChanged);
            this.textBoxAmountReceived.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAmountReceived_KeyPress);
            // 
            // labelPriceKilo
            // 
            this.labelPriceKilo.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelPriceKilo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelPriceKilo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.labelPriceKilo.Location = new System.Drawing.Point(3, 25);
            this.labelPriceKilo.Name = "labelPriceKilo";
            this.labelPriceKilo.Size = new System.Drawing.Size(150, 30);
            this.labelPriceKilo.TabIndex = 5;
            this.labelPriceKilo.Tag = "textBox1";
            this.labelPriceKilo.Text = "Cantidad recibida:";
            this.labelPriceKilo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelChange
            // 
            this.labelChange.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelChange.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelChange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.labelChange.Location = new System.Drawing.Point(315, 25);
            this.labelChange.Name = "labelChange";
            this.labelChange.Size = new System.Drawing.Size(150, 30);
            this.labelChange.TabIndex = 8;
            this.labelChange.Tag = "textBox1";
            this.labelChange.Text = "Cambio:";
            this.labelChange.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxChange
            // 
            this.textBoxChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(33)))), ((int)(((byte)(30)))));
            this.textBoxChange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxChange.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxChange.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBoxChange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.textBoxChange.Location = new System.Drawing.Point(471, 28);
            this.textBoxChange.Margin = new System.Windows.Forms.Padding(3, 3, 30, 3);
            this.textBoxChange.Name = "textBoxChange";
            this.textBoxChange.ReadOnly = true;
            this.textBoxChange.Size = new System.Drawing.Size(123, 29);
            this.textBoxChange.TabIndex = 9;
            this.textBoxChange.Tag = "";
            // 
            // FormEndSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 183);
            this.Controls.Add(this.panelC);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEndSale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormEditOrder";
            this.panelC.ResumeLayout(false);
            this.panelC.PerformLayout();
            this.panelControls.ResumeLayout(false);
            this.panelControls.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelC;
        private System.Windows.Forms.TableLayoutPanel panelControls;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelTotalAmount;
        private Guna.UI.WinForms.GunaButton buttonEndSale;
        private Guna.UI.WinForms.GunaButton buttonCancel;
        private System.Windows.Forms.TextBox textBoxAmountReceived;
        private System.Windows.Forms.Label labelPriceKilo;
        private System.Windows.Forms.Label labelChange;
        private System.Windows.Forms.TextBox textBoxChange;
    }
}