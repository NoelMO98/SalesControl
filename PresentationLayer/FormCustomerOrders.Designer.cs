
namespace ControlVentas.PresentationLayer
{
    partial class FormCustomerOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCustomerOrders));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panelBack = new System.Windows.Forms.Panel();
            this.buttonBack = new System.Windows.Forms.Button();
            this.panelControls = new System.Windows.Forms.TableLayoutPanel();
            this.labelPriceKilo = new System.Windows.Forms.Label();
            this.labelChange = new System.Windows.Forms.Label();
            this.panelName = new System.Windows.Forms.Panel();
            this.textBoxAmountReceived = new System.Windows.Forms.TextBox();
            this.panelChange = new System.Windows.Forms.Panel();
            this.textBoxChange = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.labelTotalRemainder = new System.Windows.Forms.Label();
            this.buttonCredit = new Guna.UI.WinForms.GunaButton();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelData = new System.Windows.Forms.Panel();
            this.dataGridViewCustomerOrders = new System.Windows.Forms.DataGridView();
            this.ColumnOrderOrDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCustomerNameOrGain = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRemainder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelSide = new System.Windows.Forms.Panel();
            this.panelFilteredDates = new System.Windows.Forms.TableLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.panelMonthCalendar = new System.Windows.Forms.Panel();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.panelRadioButtons = new System.Windows.Forms.Panel();
            this.radioButtonByDay = new System.Windows.Forms.RadioButton();
            this.radioButtonByWeek = new System.Windows.Forms.RadioButton();
            this.radioButtonByYearOrAll = new System.Windows.Forms.RadioButton();
            this.panelBack.SuspendLayout();
            this.panelControls.SuspendLayout();
            this.panelName.SuspendLayout();
            this.panelChange.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomerOrders)).BeginInit();
            this.panelSide.SuspendLayout();
            this.panelFilteredDates.SuspendLayout();
            this.panelMonthCalendar.SuspendLayout();
            this.panelRadioButtons.SuspendLayout();
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
            // panelBack
            // 
            this.panelBack.BackColor = System.Drawing.Color.White;
            this.panelBack.Controls.Add(this.buttonBack);
            this.panelBack.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBack.Location = new System.Drawing.Point(0, 0);
            this.panelBack.Name = "panelBack";
            this.panelBack.Size = new System.Drawing.Size(660, 37);
            this.panelBack.TabIndex = 9;
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
            // panelControls
            // 
            this.panelControls.AutoSize = true;
            this.panelControls.BackColor = System.Drawing.Color.White;
            this.panelControls.ColumnCount = 4;
            this.panelControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.panelControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.panelControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.panelControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.panelControls.Controls.Add(this.labelPriceKilo, 0, 0);
            this.panelControls.Controls.Add(this.labelChange, 2, 0);
            this.panelControls.Controls.Add(this.panelName, 1, 0);
            this.panelControls.Controls.Add(this.panelChange, 3, 0);
            this.panelControls.Controls.Add(this.label5, 0, 1);
            this.panelControls.Controls.Add(this.labelTotalRemainder, 1, 1);
            this.panelControls.Controls.Add(this.buttonCredit, 3, 1);
            this.panelControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControls.Location = new System.Drawing.Point(0, 37);
            this.panelControls.Name = "panelControls";
            this.panelControls.Padding = new System.Windows.Forms.Padding(0, 15, 15, 0);
            this.panelControls.RowCount = 3;
            this.panelControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.panelControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.panelControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.panelControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panelControls.Size = new System.Drawing.Size(660, 125);
            this.panelControls.TabIndex = 12;
            // 
            // labelPriceKilo
            // 
            this.labelPriceKilo.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelPriceKilo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelPriceKilo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(36)))), ((int)(((byte)(33)))));
            this.labelPriceKilo.Location = new System.Drawing.Point(3, 15);
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
            this.labelChange.Location = new System.Drawing.Point(325, 15);
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
            this.panelName.Location = new System.Drawing.Point(164, 18);
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
            // panelChange
            // 
            this.panelChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.panelChange.Controls.Add(this.textBoxChange);
            this.panelChange.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelChange.Location = new System.Drawing.Point(486, 18);
            this.panelChange.Name = "panelChange";
            this.panelChange.Size = new System.Drawing.Size(156, 24);
            this.panelChange.TabIndex = 20;
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
            this.label5.Location = new System.Drawing.Point(3, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 50);
            this.label5.TabIndex = 4;
            this.label5.Tag = "textBox1";
            this.label5.Text = "Resto total:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelTotalRemainder
            // 
            this.panelControls.SetColumnSpan(this.labelTotalRemainder, 2);
            this.labelTotalRemainder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTotalRemainder.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalRemainder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(120)))), ((int)(((byte)(210)))));
            this.labelTotalRemainder.Location = new System.Drawing.Point(164, 65);
            this.labelTotalRemainder.Name = "labelTotalRemainder";
            this.labelTotalRemainder.Size = new System.Drawing.Size(316, 50);
            this.labelTotalRemainder.TabIndex = 14;
            this.labelTotalRemainder.Tag = "textBox1";
            this.labelTotalRemainder.Text = "$ 123456789";
            this.labelTotalRemainder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.buttonCredit.Location = new System.Drawing.Point(486, 68);
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
            // panelMain
            // 
            this.panelMain.AutoScroll = true;
            this.panelMain.AutoSize = true;
            this.panelMain.Controls.Add(this.panelData);
            this.panelMain.Controls.Add(this.panelControls);
            this.panelMain.Controls.Add(this.panelBack);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(660, 409);
            this.panelMain.TabIndex = 11;
            // 
            // panelData
            // 
            this.panelData.AutoScroll = true;
            this.panelData.AutoSize = true;
            this.panelData.BackColor = System.Drawing.Color.White;
            this.panelData.Controls.Add(this.dataGridViewCustomerOrders);
            this.panelData.Controls.Add(this.panelSide);
            this.panelData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelData.Location = new System.Drawing.Point(0, 162);
            this.panelData.Margin = new System.Windows.Forms.Padding(0);
            this.panelData.Name = "panelData";
            this.panelData.Size = new System.Drawing.Size(660, 247);
            this.panelData.TabIndex = 14;
            // 
            // dataGridViewCustomerOrders
            // 
            this.dataGridViewCustomerOrders.AllowUserToAddRows = false;
            this.dataGridViewCustomerOrders.AllowUserToDeleteRows = false;
            this.dataGridViewCustomerOrders.AllowUserToResizeRows = false;
            this.dataGridViewCustomerOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCustomerOrders.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(46)))), ((int)(((byte)(50)))));
            this.dataGridViewCustomerOrders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewCustomerOrders.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewCustomerOrders.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(49)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(49)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCustomerOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCustomerOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomerOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnOrderOrDate,
            this.ColumnDate,
            this.ColumnCustomerNameOrGain,
            this.ColumnDescription,
            this.ColumnAmount,
            this.ColumnRemainder});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(58)))), ((int)(((byte)(71)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(146)))), ((int)(((byte)(164)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewCustomerOrders.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewCustomerOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewCustomerOrders.EnableHeadersVisualStyles = false;
            this.dataGridViewCustomerOrders.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(46)))), ((int)(((byte)(50)))));
            this.dataGridViewCustomerOrders.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewCustomerOrders.MultiSelect = false;
            this.dataGridViewCustomerOrders.Name = "dataGridViewCustomerOrders";
            this.dataGridViewCustomerOrders.ReadOnly = true;
            this.dataGridViewCustomerOrders.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewCustomerOrders.RowHeadersVisible = false;
            this.dataGridViewCustomerOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCustomerOrders.Size = new System.Drawing.Size(386, 247);
            this.dataGridViewCustomerOrders.TabIndex = 8;
            this.dataGridViewCustomerOrders.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCustomerOrders_CellDoubleClick);
            // 
            // ColumnOrderOrDate
            // 
            this.ColumnOrderOrDate.HeaderText = "Order/Date";
            this.ColumnOrderOrDate.Name = "ColumnOrderOrDate";
            this.ColumnOrderOrDate.ReadOnly = true;
            this.ColumnOrderOrDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnDate
            // 
            this.ColumnDate.HeaderText = "Fecha";
            this.ColumnDate.Name = "ColumnDate";
            this.ColumnDate.ReadOnly = true;
            this.ColumnDate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnCustomerNameOrGain
            // 
            this.ColumnCustomerNameOrGain.HeaderText = "Cliente/Ganancia";
            this.ColumnCustomerNameOrGain.Name = "ColumnCustomerNameOrGain";
            this.ColumnCustomerNameOrGain.ReadOnly = true;
            this.ColumnCustomerNameOrGain.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnCustomerNameOrGain.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnDescription
            // 
            this.ColumnDescription.HeaderText = "Descripción";
            this.ColumnDescription.Name = "ColumnDescription";
            this.ColumnDescription.ReadOnly = true;
            this.ColumnDescription.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnDescription.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnAmount
            // 
            this.ColumnAmount.HeaderText = "Importe";
            this.ColumnAmount.Name = "ColumnAmount";
            this.ColumnAmount.ReadOnly = true;
            this.ColumnAmount.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnAmount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnRemainder
            // 
            this.ColumnRemainder.HeaderText = "Resto";
            this.ColumnRemainder.Name = "ColumnRemainder";
            this.ColumnRemainder.ReadOnly = true;
            this.ColumnRemainder.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnRemainder.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // panelSide
            // 
            this.panelSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(46)))), ((int)(((byte)(50)))));
            this.panelSide.Controls.Add(this.panelFilteredDates);
            this.panelSide.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelSide.Location = new System.Drawing.Point(386, 0);
            this.panelSide.Margin = new System.Windows.Forms.Padding(0);
            this.panelSide.Name = "panelSide";
            this.panelSide.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.panelSide.Size = new System.Drawing.Size(274, 247);
            this.panelSide.TabIndex = 10;
            // 
            // panelFilteredDates
            // 
            this.panelFilteredDates.AutoScroll = true;
            this.panelFilteredDates.ColumnCount = 2;
            this.panelFilteredDates.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelFilteredDates.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelFilteredDates.Controls.Add(this.label8, 0, 0);
            this.panelFilteredDates.Controls.Add(this.panelMonthCalendar, 0, 2);
            this.panelFilteredDates.Controls.Add(this.panelRadioButtons, 0, 1);
            this.panelFilteredDates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFilteredDates.Location = new System.Drawing.Point(10, 0);
            this.panelFilteredDates.Margin = new System.Windows.Forms.Padding(0);
            this.panelFilteredDates.Name = "panelFilteredDates";
            this.panelFilteredDates.RowCount = 3;
            this.panelFilteredDates.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.24314F));
            this.panelFilteredDates.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelFilteredDates.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.75687F));
            this.panelFilteredDates.Size = new System.Drawing.Size(254, 247);
            this.panelFilteredDates.TabIndex = 7;
            // 
            // label8
            // 
            this.panelFilteredDates.SetColumnSpan(this.label8, 2);
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(248, 32);
            this.label8.TabIndex = 20;
            this.label8.Tag = "textBox1";
            this.label8.Text = "Mostrar";
            this.label8.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // panelMonthCalendar
            // 
            this.panelMonthCalendar.AutoSize = true;
            this.panelMonthCalendar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.panelFilteredDates.SetColumnSpan(this.panelMonthCalendar, 2);
            this.panelMonthCalendar.Controls.Add(this.monthCalendar);
            this.panelMonthCalendar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMonthCalendar.Location = new System.Drawing.Point(3, 80);
            this.panelMonthCalendar.Name = "panelMonthCalendar";
            this.panelMonthCalendar.Size = new System.Drawing.Size(248, 162);
            this.panelMonthCalendar.TabIndex = 18;
            // 
            // monthCalendar
            // 
            this.monthCalendar.Dock = System.Windows.Forms.DockStyle.Top;
            this.monthCalendar.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.monthCalendar.Location = new System.Drawing.Point(0, 0);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.ShowTodayCircle = false;
            this.monthCalendar.TabIndex = 0;
            this.monthCalendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar_DateSelected);
            // 
            // panelRadioButtons
            // 
            this.panelRadioButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(46)))), ((int)(((byte)(50)))));
            this.panelFilteredDates.SetColumnSpan(this.panelRadioButtons, 2);
            this.panelRadioButtons.Controls.Add(this.radioButtonByDay);
            this.panelRadioButtons.Controls.Add(this.radioButtonByWeek);
            this.panelRadioButtons.Controls.Add(this.radioButtonByYearOrAll);
            this.panelRadioButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRadioButtons.ForeColor = System.Drawing.Color.White;
            this.panelRadioButtons.Location = new System.Drawing.Point(3, 35);
            this.panelRadioButtons.Name = "panelRadioButtons";
            this.panelRadioButtons.Size = new System.Drawing.Size(248, 39);
            this.panelRadioButtons.TabIndex = 19;
            // 
            // radioButtonByDay
            // 
            this.radioButtonByDay.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonByDay.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radioButtonByDay.Dock = System.Windows.Forms.DockStyle.Left;
            this.radioButtonByDay.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.radioButtonByDay.FlatAppearance.BorderSize = 10;
            this.radioButtonByDay.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.radioButtonByDay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.radioButtonByDay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.radioButtonByDay.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.radioButtonByDay.ForeColor = System.Drawing.Color.White;
            this.radioButtonByDay.Location = new System.Drawing.Point(178, 0);
            this.radioButtonByDay.Name = "radioButtonByDay";
            this.radioButtonByDay.Size = new System.Drawing.Size(70, 39);
            this.radioButtonByDay.TabIndex = 2;
            this.radioButtonByDay.Text = "Por día";
            this.radioButtonByDay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonByDay.UseVisualStyleBackColor = false;
            this.radioButtonByDay.Click += new System.EventHandler(this.radioButtonByDay_Click);
            // 
            // radioButtonByWeek
            // 
            this.radioButtonByWeek.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonByWeek.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radioButtonByWeek.Dock = System.Windows.Forms.DockStyle.Left;
            this.radioButtonByWeek.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.radioButtonByWeek.FlatAppearance.BorderSize = 10;
            this.radioButtonByWeek.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.radioButtonByWeek.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.radioButtonByWeek.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.radioButtonByWeek.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.radioButtonByWeek.ForeColor = System.Drawing.Color.White;
            this.radioButtonByWeek.Location = new System.Drawing.Point(68, 0);
            this.radioButtonByWeek.Name = "radioButtonByWeek";
            this.radioButtonByWeek.Size = new System.Drawing.Size(110, 39);
            this.radioButtonByWeek.TabIndex = 1;
            this.radioButtonByWeek.Text = "Por semana";
            this.radioButtonByWeek.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonByWeek.UseVisualStyleBackColor = false;
            this.radioButtonByWeek.Click += new System.EventHandler(this.radioButtonByWeek_Click);
            // 
            // radioButtonByYearOrAll
            // 
            this.radioButtonByYearOrAll.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonByYearOrAll.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radioButtonByYearOrAll.Checked = true;
            this.radioButtonByYearOrAll.Dock = System.Windows.Forms.DockStyle.Left;
            this.radioButtonByYearOrAll.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.radioButtonByYearOrAll.FlatAppearance.BorderSize = 10;
            this.radioButtonByYearOrAll.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.radioButtonByYearOrAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.radioButtonByYearOrAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.radioButtonByYearOrAll.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.radioButtonByYearOrAll.ForeColor = System.Drawing.Color.White;
            this.radioButtonByYearOrAll.Location = new System.Drawing.Point(0, 0);
            this.radioButtonByYearOrAll.Name = "radioButtonByYearOrAll";
            this.radioButtonByYearOrAll.Size = new System.Drawing.Size(68, 39);
            this.radioButtonByYearOrAll.TabIndex = 0;
            this.radioButtonByYearOrAll.TabStop = true;
            this.radioButtonByYearOrAll.Text = "Todas";
            this.radioButtonByYearOrAll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonByYearOrAll.UseVisualStyleBackColor = false;
            this.radioButtonByYearOrAll.Click += new System.EventHandler(this.radioButtonByYearOrAll_Click);
            // 
            // FormCustomerOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(660, 409);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCustomerOrders";
            this.Text = "FormToSell";
            this.panelBack.ResumeLayout(false);
            this.panelControls.ResumeLayout(false);
            this.panelName.ResumeLayout(false);
            this.panelName.PerformLayout();
            this.panelChange.ResumeLayout(false);
            this.panelChange.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panelData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomerOrders)).EndInit();
            this.panelSide.ResumeLayout(false);
            this.panelFilteredDates.ResumeLayout(false);
            this.panelFilteredDates.PerformLayout();
            this.panelMonthCalendar.ResumeLayout(false);
            this.panelRadioButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.Panel panelBack;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.TableLayoutPanel panelControls;
        private System.Windows.Forms.Label labelPriceKilo;
        private System.Windows.Forms.Label labelChange;
        private System.Windows.Forms.Panel panelName;
        private System.Windows.Forms.TextBox textBoxAmountReceived;
        private System.Windows.Forms.Panel panelChange;
        private System.Windows.Forms.TextBox textBoxChange;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelTotalRemainder;
        private Guna.UI.WinForms.GunaButton buttonCredit;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelData;
        private System.Windows.Forms.DataGridView dataGridViewCustomerOrders;
        private System.Windows.Forms.Panel panelSide;
        private System.Windows.Forms.TableLayoutPanel panelFilteredDates;
        private System.Windows.Forms.Panel panelRadioButtons;
        private System.Windows.Forms.RadioButton radioButtonByDay;
        private System.Windows.Forms.RadioButton radioButtonByWeek;
        private System.Windows.Forms.RadioButton radioButtonByYearOrAll;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panelMonthCalendar;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnOrderOrDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCustomerNameOrGain;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRemainder;
    }
}