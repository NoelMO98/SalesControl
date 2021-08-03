
namespace ControlVentas.PresentationLayer
{
    partial class FormEditOrder
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
            this.panelControls = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxPriceKilo = new System.Windows.Forms.TextBox();
            this.labelPriceKilo = new System.Windows.Forms.Label();
            this.checkBoxExactAmount = new Guna.UI.WinForms.GunaCheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxWeight = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelIndividualAmount = new System.Windows.Forms.Label();
            this.buttonCancel = new Guna.UI.WinForms.GunaButton();
            this.buttonSave = new Guna.UI.WinForms.GunaButton();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.panelC = new System.Windows.Forms.Panel();
            this.panelControls.SuspendLayout();
            this.panelC.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControls
            // 
            this.panelControls.AutoSize = true;
            this.panelControls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(33)))), ((int)(((byte)(30)))));
            this.panelControls.ColumnCount = 4;
            this.panelControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.panelControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.panelControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.25F));
            this.panelControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.25F));
            this.panelControls.Controls.Add(this.textBoxPriceKilo, 1, 0);
            this.panelControls.Controls.Add(this.labelPriceKilo, 0, 0);
            this.panelControls.Controls.Add(this.checkBoxExactAmount, 2, 0);
            this.panelControls.Controls.Add(this.label3, 0, 1);
            this.panelControls.Controls.Add(this.textBoxWeight, 1, 1);
            this.panelControls.Controls.Add(this.textBoxDescription, 1, 2);
            this.panelControls.Controls.Add(this.label4, 0, 2);
            this.panelControls.Controls.Add(this.label5, 1, 3);
            this.panelControls.Controls.Add(this.labelIndividualAmount, 2, 3);
            this.panelControls.Controls.Add(this.buttonCancel, 3, 2);
            this.panelControls.Controls.Add(this.buttonSave, 3, 1);
            this.panelControls.Controls.Add(this.textBoxAmount, 2, 1);
            this.panelControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControls.Location = new System.Drawing.Point(0, 0);
            this.panelControls.Name = "panelControls";
            this.panelControls.Padding = new System.Windows.Forms.Padding(0, 15, 15, 0);
            this.panelControls.RowCount = 4;
            this.panelControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.panelControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.panelControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.panelControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.panelControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panelControls.Size = new System.Drawing.Size(662, 215);
            this.panelControls.TabIndex = 5;
            // 
            // textBoxPriceKilo
            // 
            this.textBoxPriceKilo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(33)))), ((int)(((byte)(30)))));
            this.textBoxPriceKilo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPriceKilo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxPriceKilo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBoxPriceKilo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.textBoxPriceKilo.Location = new System.Drawing.Point(132, 18);
            this.textBoxPriceKilo.Margin = new System.Windows.Forms.Padding(3, 3, 30, 3);
            this.textBoxPriceKilo.MaxLength = 8;
            this.textBoxPriceKilo.Name = "textBoxPriceKilo";
            this.textBoxPriceKilo.Size = new System.Drawing.Size(161, 29);
            this.textBoxPriceKilo.TabIndex = 6;
            this.textBoxPriceKilo.Tag = "";
            this.textBoxPriceKilo.TextChanged += new System.EventHandler(this.textBoxPriceKilo_TextChanged);
            this.textBoxPriceKilo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPriceKilo_KeyPress);
            // 
            // labelPriceKilo
            // 
            this.labelPriceKilo.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelPriceKilo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelPriceKilo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.labelPriceKilo.Location = new System.Drawing.Point(3, 15);
            this.labelPriceKilo.Name = "labelPriceKilo";
            this.labelPriceKilo.Size = new System.Drawing.Size(123, 30);
            this.labelPriceKilo.TabIndex = 5;
            this.labelPriceKilo.Tag = "textBox1";
            this.labelPriceKilo.Text = "Precio por Kg:";
            this.labelPriceKilo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // checkBoxExactAmount
            // 
            this.checkBoxExactAmount.BaseColor = System.Drawing.Color.White;
            this.checkBoxExactAmount.CheckedOffColor = System.Drawing.Color.Gray;
            this.checkBoxExactAmount.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.checkBoxExactAmount.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkBoxExactAmount.FillColor = System.Drawing.Color.White;
            this.checkBoxExactAmount.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxExactAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.checkBoxExactAmount.Location = new System.Drawing.Point(326, 18);
            this.checkBoxExactAmount.Name = "checkBoxExactAmount";
            this.checkBoxExactAmount.Radius = 3;
            this.checkBoxExactAmount.Size = new System.Drawing.Size(140, 24);
            this.checkBoxExactAmount.TabIndex = 7;
            this.checkBoxExactAmount.Text = "Cantidad exacta";
            this.checkBoxExactAmount.CheckedChanged += new System.EventHandler(this.checkBoxExactAmount_CheckedChanged);
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.label3.Location = new System.Drawing.Point(3, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 30);
            this.label3.TabIndex = 8;
            this.label3.Tag = "textBox1";
            this.label3.Text = "Peso:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(33)))), ((int)(((byte)(30)))));
            this.textBoxWeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxWeight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxWeight.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBoxWeight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.textBoxWeight.Location = new System.Drawing.Point(132, 68);
            this.textBoxWeight.Margin = new System.Windows.Forms.Padding(3, 3, 30, 3);
            this.textBoxWeight.MaxLength = 5;
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.Size = new System.Drawing.Size(161, 29);
            this.textBoxWeight.TabIndex = 9;
            this.textBoxWeight.Tag = "";
            this.textBoxWeight.TextChanged += new System.EventHandler(this.textBoxWeight_TextChanged);
            this.textBoxWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxWeight_KeyPress);
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(33)))), ((int)(((byte)(30)))));
            this.textBoxDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelControls.SetColumnSpan(this.textBoxDescription, 2);
            this.textBoxDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxDescription.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBoxDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.textBoxDescription.Location = new System.Drawing.Point(132, 118);
            this.textBoxDescription.Margin = new System.Windows.Forms.Padding(3, 3, 30, 3);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(322, 29);
            this.textBoxDescription.TabIndex = 10;
            this.textBoxDescription.Tag = "";
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.label4.Location = new System.Drawing.Point(3, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 30);
            this.label4.TabIndex = 11;
            this.label4.Tag = "textBox1";
            this.label4.Text = "Descripción:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.label5.Location = new System.Drawing.Point(132, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 50);
            this.label5.TabIndex = 4;
            this.label5.Tag = "textBox1";
            this.label5.Text = "Importe individual:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelIndividualAmount
            // 
            this.labelIndividualAmount.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelIndividualAmount.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIndividualAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(161)))), ((int)(((byte)(187)))));
            this.labelIndividualAmount.Location = new System.Drawing.Point(326, 165);
            this.labelIndividualAmount.Name = "labelIndividualAmount";
            this.labelIndividualAmount.Size = new System.Drawing.Size(155, 50);
            this.labelIndividualAmount.TabIndex = 14;
            this.labelIndividualAmount.Tag = "textBox1";
            this.labelIndividualAmount.Text = "$ 0";
            this.labelIndividualAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.buttonCancel.Location = new System.Drawing.Point(487, 118);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.buttonCancel.OnHoverBorderColor = System.Drawing.Color.White;
            this.buttonCancel.OnHoverForeColor = System.Drawing.Color.White;
            this.buttonCancel.OnHoverImage = null;
            this.buttonCancel.OnPressedColor = System.Drawing.Color.Black;
            this.buttonCancel.Radius = 5;
            this.buttonCancel.Size = new System.Drawing.Size(157, 44);
            this.buttonCancel.TabIndex = 18;
            this.buttonCancel.Text = "Cancelar";
            this.buttonCancel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.AnimationHoverSpeed = 0.07F;
            this.buttonSave.AnimationSpeed = 0.03F;
            this.buttonSave.BackColor = System.Drawing.Color.Transparent;
            this.buttonSave.BaseColor = System.Drawing.Color.Transparent;
            this.buttonSave.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(146)))), ((int)(((byte)(164)))));
            this.buttonSave.BorderSize = 1;
            this.buttonSave.DialogResult = System.Windows.Forms.DialogResult.None;
            this.buttonSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSave.FocusedColor = System.Drawing.Color.Empty;
            this.buttonSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.ForeColor = System.Drawing.Color.White;
            this.buttonSave.Image = null;
            this.buttonSave.ImageSize = new System.Drawing.Size(20, 20);
            this.buttonSave.Location = new System.Drawing.Point(487, 68);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.buttonSave.OnHoverBorderColor = System.Drawing.Color.White;
            this.buttonSave.OnHoverForeColor = System.Drawing.Color.White;
            this.buttonSave.OnHoverImage = null;
            this.buttonSave.OnPressedColor = System.Drawing.Color.Black;
            this.buttonSave.Radius = 5;
            this.buttonSave.Size = new System.Drawing.Size(157, 44);
            this.buttonSave.TabIndex = 17;
            this.buttonSave.Text = "Guardar cambios";
            this.buttonSave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(33)))), ((int)(((byte)(30)))));
            this.textBoxAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAmount.Location = new System.Drawing.Point(326, 68);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(100, 13);
            this.textBoxAmount.TabIndex = 19;
            this.textBoxAmount.Visible = false;
            // 
            // panelC
            // 
            this.panelC.AutoSize = true;
            this.panelC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(170)))), ((int)(((byte)(161)))));
            this.panelC.Controls.Add(this.panelControls);
            this.panelC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelC.Location = new System.Drawing.Point(0, 0);
            this.panelC.Name = "panelC";
            this.panelC.Size = new System.Drawing.Size(662, 218);
            this.panelC.TabIndex = 7;
            // 
            // FormEditOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 218);
            this.Controls.Add(this.panelC);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEditOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormEditOrder";
            this.panelControls.ResumeLayout(false);
            this.panelControls.PerformLayout();
            this.panelC.ResumeLayout(false);
            this.panelC.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel panelControls;
        private System.Windows.Forms.TextBox textBoxPriceKilo;
        private System.Windows.Forms.Label labelPriceKilo;
        private Guna.UI.WinForms.GunaCheckBox checkBoxExactAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxWeight;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelIndividualAmount;
        private Guna.UI.WinForms.GunaButton buttonCancel;
        private Guna.UI.WinForms.GunaButton buttonSave;
        private System.Windows.Forms.Panel panelC;
        private System.Windows.Forms.TextBox textBoxAmount;
    }
}