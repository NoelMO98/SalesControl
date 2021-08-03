
namespace ControlVentas.PresentationLayer
{
    partial class FormAccumulatedAmounts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAccumulatedAmounts));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelCustomers = new System.Windows.Forms.Panel();
            this.panelDataGridView = new System.Windows.Forms.Panel();
            this.dataGridViewAccumulatedAmounts = new System.Windows.Forms.DataGridView();
            this.ColumnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAccumulatedAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelControls = new System.Windows.Forms.TableLayoutPanel();
            this.labelPriceKilo = new System.Windows.Forms.Label();
            this.labelChange = new System.Windows.Forms.Label();
            this.panelName = new System.Windows.Forms.Panel();
            this.textBoxAmountReceived = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxChange = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.labelRemainder = new System.Windows.Forms.Label();
            this.buttonCredit = new Guna.UI.WinForms.GunaButton();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.buttonBack = new System.Windows.Forms.Button();
            this.panelMain.SuspendLayout();
            this.panelCustomers.SuspendLayout();
            this.panelDataGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAccumulatedAmounts)).BeginInit();
            this.panelControls.SuspendLayout();
            this.panelName.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Editar";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn1.Width = 94;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "Eliminar";
            this.dataGridViewImageColumn2.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn2.Image")));
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 94;
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.HeaderText = "Eliminar";
            this.dataGridViewImageColumn3.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn3.Image")));
            this.dataGridViewImageColumn3.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            this.dataGridViewImageColumn3.Width = 82;
            // 
            // panelMain
            // 
            this.panelMain.AutoScroll = true;
            this.panelMain.AutoSize = true;
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(36)))), ((int)(((byte)(33)))));
            this.panelMain.Controls.Add(this.panelCustomers);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(660, 409);
            this.panelMain.TabIndex = 1;
            // 
            // panelCustomers
            // 
            this.panelCustomers.AutoScroll = true;
            this.panelCustomers.AutoSize = true;
            this.panelCustomers.Controls.Add(this.panelDataGridView);
            this.panelCustomers.Controls.Add(this.panelSearch);
            this.panelCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCustomers.Location = new System.Drawing.Point(0, 0);
            this.panelCustomers.Name = "panelCustomers";
            this.panelCustomers.Size = new System.Drawing.Size(660, 409);
            this.panelCustomers.TabIndex = 11;
            // 
            // panelDataGridView
            // 
            this.panelDataGridView.AutoScroll = true;
            this.panelDataGridView.BackColor = System.Drawing.Color.White;
            this.panelDataGridView.Controls.Add(this.dataGridViewAccumulatedAmounts);
            this.panelDataGridView.Controls.Add(this.panelControls);
            this.panelDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDataGridView.Location = new System.Drawing.Point(0, 37);
            this.panelDataGridView.Margin = new System.Windows.Forms.Padding(0);
            this.panelDataGridView.Name = "panelDataGridView";
            this.panelDataGridView.Size = new System.Drawing.Size(660, 372);
            this.panelDataGridView.TabIndex = 11;
            // 
            // dataGridViewAccumulatedAmounts
            // 
            this.dataGridViewAccumulatedAmounts.AllowUserToAddRows = false;
            this.dataGridViewAccumulatedAmounts.AllowUserToDeleteRows = false;
            this.dataGridViewAccumulatedAmounts.AllowUserToResizeRows = false;
            this.dataGridViewAccumulatedAmounts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAccumulatedAmounts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(46)))), ((int)(((byte)(50)))));
            this.dataGridViewAccumulatedAmounts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewAccumulatedAmounts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewAccumulatedAmounts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(49)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(49)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAccumulatedAmounts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewAccumulatedAmounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAccumulatedAmounts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnDate,
            this.ColumnAccumulatedAmount});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(58)))), ((int)(((byte)(71)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(146)))), ((int)(((byte)(164)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewAccumulatedAmounts.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewAccumulatedAmounts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewAccumulatedAmounts.EnableHeadersVisualStyles = false;
            this.dataGridViewAccumulatedAmounts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(46)))), ((int)(((byte)(50)))));
            this.dataGridViewAccumulatedAmounts.Location = new System.Drawing.Point(0, 135);
            this.dataGridViewAccumulatedAmounts.MultiSelect = false;
            this.dataGridViewAccumulatedAmounts.Name = "dataGridViewAccumulatedAmounts";
            this.dataGridViewAccumulatedAmounts.ReadOnly = true;
            this.dataGridViewAccumulatedAmounts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewAccumulatedAmounts.RowHeadersVisible = false;
            this.dataGridViewAccumulatedAmounts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAccumulatedAmounts.Size = new System.Drawing.Size(660, 237);
            this.dataGridViewAccumulatedAmounts.TabIndex = 8;
            // 
            // ColumnDate
            // 
            this.ColumnDate.HeaderText = "Fecha";
            this.ColumnDate.Name = "ColumnDate";
            this.ColumnDate.ReadOnly = true;
            this.ColumnDate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnAccumulatedAmount
            // 
            this.ColumnAccumulatedAmount.HeaderText = "Cantidad acumulada";
            this.ColumnAccumulatedAmount.Name = "ColumnAccumulatedAmount";
            this.ColumnAccumulatedAmount.ReadOnly = true;
            this.ColumnAccumulatedAmount.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnAccumulatedAmount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // panelControls
            // 
            this.panelControls.AutoSize = true;
            this.panelControls.BackColor = System.Drawing.Color.White;
            this.panelControls.ColumnCount = 4;
            this.panelControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.panelControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.panelControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.panelControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.panelControls.Controls.Add(this.labelPriceKilo, 0, 1);
            this.panelControls.Controls.Add(this.labelChange, 2, 1);
            this.panelControls.Controls.Add(this.panelName, 1, 1);
            this.panelControls.Controls.Add(this.panel1, 3, 1);
            this.panelControls.Controls.Add(this.label5, 0, 2);
            this.panelControls.Controls.Add(this.labelRemainder, 1, 2);
            this.panelControls.Controls.Add(this.buttonCredit, 3, 2);
            this.panelControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControls.Location = new System.Drawing.Point(0, 0);
            this.panelControls.Name = "panelControls";
            this.panelControls.Padding = new System.Windows.Forms.Padding(0, 15, 15, 0);
            this.panelControls.RowCount = 4;
            this.panelControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.panelControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.panelControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.panelControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.panelControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panelControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panelControls.Size = new System.Drawing.Size(660, 135);
            this.panelControls.TabIndex = 12;
            // 
            // labelPriceKilo
            // 
            this.labelPriceKilo.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelPriceKilo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelPriceKilo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(36)))), ((int)(((byte)(33)))));
            this.labelPriceKilo.Location = new System.Drawing.Point(3, 25);
            this.labelPriceKilo.Name = "labelPriceKilo";
            this.labelPriceKilo.Size = new System.Drawing.Size(155, 30);
            this.labelPriceKilo.TabIndex = 5;
            this.labelPriceKilo.Tag = "textBox1";
            this.labelPriceKilo.Text = "Cantidad recibida:";
            this.labelPriceKilo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelChange
            // 
            this.labelChange.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelChange.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelChange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(36)))), ((int)(((byte)(33)))));
            this.labelChange.Location = new System.Drawing.Point(325, 25);
            this.labelChange.Name = "labelChange";
            this.labelChange.Size = new System.Drawing.Size(155, 30);
            this.labelChange.TabIndex = 8;
            this.labelChange.Tag = "textBox1";
            this.labelChange.Text = "Cambio:";
            this.labelChange.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelName
            // 
            this.panelName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.panelName.Controls.Add(this.textBoxAmountReceived);
            this.panelName.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelName.Location = new System.Drawing.Point(164, 28);
            this.panelName.Name = "panelName";
            this.panelName.Size = new System.Drawing.Size(155, 24);
            this.panelName.TabIndex = 19;
            // 
            // textBoxAmountReceived
            // 
            this.textBoxAmountReceived.BackColor = System.Drawing.Color.White;
            this.textBoxAmountReceived.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAmountReceived.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxAmountReceived.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBoxAmountReceived.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(36)))), ((int)(((byte)(33)))));
            this.textBoxAmountReceived.Location = new System.Drawing.Point(0, 0);
            this.textBoxAmountReceived.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxAmountReceived.MaxLength = 15;
            this.textBoxAmountReceived.Name = "textBoxAmountReceived";
            this.textBoxAmountReceived.Size = new System.Drawing.Size(155, 22);
            this.textBoxAmountReceived.TabIndex = 4;
            this.textBoxAmountReceived.Tag = "";
            this.textBoxAmountReceived.TextChanged += new System.EventHandler(this.textBoxAmountReceived_TextChanged);
            this.textBoxAmountReceived.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAmountReceived_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.panel1.Controls.Add(this.textBoxChange);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(486, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(156, 24);
            this.panel1.TabIndex = 20;
            // 
            // textBoxChange
            // 
            this.textBoxChange.BackColor = System.Drawing.Color.White;
            this.textBoxChange.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxChange.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxChange.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBoxChange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(36)))), ((int)(((byte)(33)))));
            this.textBoxChange.Location = new System.Drawing.Point(0, 0);
            this.textBoxChange.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxChange.Name = "textBoxChange";
            this.textBoxChange.ReadOnly = true;
            this.textBoxChange.Size = new System.Drawing.Size(156, 22);
            this.textBoxChange.TabIndex = 4;
            this.textBoxChange.Tag = "";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(110)))), ((int)(((byte)(185)))));
            this.label5.Location = new System.Drawing.Point(3, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 50);
            this.label5.TabIndex = 4;
            this.label5.Tag = "textBox1";
            this.label5.Text = "Resto:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelRemainder
            // 
            this.panelControls.SetColumnSpan(this.labelRemainder, 2);
            this.labelRemainder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelRemainder.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRemainder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(120)))), ((int)(((byte)(210)))));
            this.labelRemainder.Location = new System.Drawing.Point(164, 75);
            this.labelRemainder.Name = "labelRemainder";
            this.labelRemainder.Size = new System.Drawing.Size(316, 50);
            this.labelRemainder.TabIndex = 14;
            this.labelRemainder.Tag = "textBox1";
            this.labelRemainder.Text = "$ 123456789";
            this.labelRemainder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonCredit
            // 
            this.buttonCredit.AnimationHoverSpeed = 0.07F;
            this.buttonCredit.AnimationSpeed = 0.03F;
            this.buttonCredit.BackColor = System.Drawing.Color.Transparent;
            this.buttonCredit.BaseColor = System.Drawing.Color.Transparent;
            this.buttonCredit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(146)))), ((int)(((byte)(164)))));
            this.buttonCredit.BorderSize = 1;
            this.buttonCredit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.buttonCredit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCredit.FocusedColor = System.Drawing.Color.Empty;
            this.buttonCredit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCredit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(36)))), ((int)(((byte)(33)))));
            this.buttonCredit.Image = null;
            this.buttonCredit.ImageSize = new System.Drawing.Size(20, 20);
            this.buttonCredit.Location = new System.Drawing.Point(486, 78);
            this.buttonCredit.Name = "buttonCredit";
            this.buttonCredit.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.buttonCredit.OnHoverBorderColor = System.Drawing.Color.White;
            this.buttonCredit.OnHoverForeColor = System.Drawing.Color.White;
            this.buttonCredit.OnHoverImage = null;
            this.buttonCredit.OnPressedColor = System.Drawing.Color.Black;
            this.buttonCredit.Radius = 5;
            this.buttonCredit.Size = new System.Drawing.Size(156, 44);
            this.buttonCredit.TabIndex = 17;
            this.buttonCredit.Text = "Abonar";
            this.buttonCredit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.buttonCredit.Click += new System.EventHandler(this.buttonCredit_Click);
            // 
            // panelSearch
            // 
            this.panelSearch.BackColor = System.Drawing.Color.White;
            this.panelSearch.Controls.Add(this.buttonBack);
            this.panelSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearch.Location = new System.Drawing.Point(0, 0);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(660, 37);
            this.panelSearch.TabIndex = 9;
            // 
            // buttonBack
            // 
            this.buttonBack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonBack.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonBack.FlatAppearance.BorderSize = 0;
            this.buttonBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.buttonBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(36)))), ((int)(((byte)(33)))));
            this.buttonBack.Location = new System.Drawing.Point(0, 0);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(40, 37);
            this.buttonBack.TabIndex = 18;
            this.buttonBack.Text = "❮";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            this.buttonBack.MouseLeave += new System.EventHandler(this.buttonBack_MouseLeave);
            this.buttonBack.MouseHover += new System.EventHandler(this.buttonBack_MouseHover);
            // 
            // FormAccumulatedAmounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(660, 409);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAccumulatedAmounts";
            this.Text = "FormToSell";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAccumulatedAmounts_FormClosing);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panelCustomers.ResumeLayout(false);
            this.panelDataGridView.ResumeLayout(false);
            this.panelDataGridView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAccumulatedAmounts)).EndInit();
            this.panelControls.ResumeLayout(false);
            this.panelName.ResumeLayout(false);
            this.panelName.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelSearch.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelCustomers;
        private System.Windows.Forms.Panel panelDataGridView;
        private System.Windows.Forms.DataGridView dataGridViewAccumulatedAmounts;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAccumulatedAmount;
        private System.Windows.Forms.TableLayoutPanel panelControls;
        private System.Windows.Forms.Label labelPriceKilo;
        private System.Windows.Forms.Label labelChange;
        private System.Windows.Forms.Panel panelName;
        private System.Windows.Forms.TextBox textBoxAmountReceived;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxChange;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelRemainder;
        private Guna.UI.WinForms.GunaButton buttonCredit;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.Button buttonBack;
    }
}