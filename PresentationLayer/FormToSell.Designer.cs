
namespace ControlVentas.PresentationLayer
{
    partial class FormToSell
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panelContent = new System.Windows.Forms.Panel();
            this.dataGridViewOrders = new System.Windows.Forms.DataGridView();
            this.ColumnOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPriceKilo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnExactAmount = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColumnAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEdit = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColumnDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.panelControls = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelPriceKilo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxExactAmount = new Guna.UI.WinForms.GunaCheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelIndividualAmount = new System.Windows.Forms.Label();
            this.labelTotalAmount = new System.Windows.Forms.Label();
            this.buttonAddOrder = new Guna.UI.WinForms.GunaButton();
            this.buttonEndSale = new Guna.UI.WinForms.GunaButton();
            this.panelCustomer = new System.Windows.Forms.Panel();
            this.comboBoxCustomer = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxPriceKilo = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBoxWeight = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelEditingForm = new System.Windows.Forms.Panel();
            this.panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).BeginInit();
            this.panelControls.SuspendLayout();
            this.panelCustomer.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Editar";
            this.dataGridViewImageColumn1.Image = global::ControlVentas.Properties.Resources.pencil;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn1.Width = 94;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "Eliminar";
            this.dataGridViewImageColumn2.Image = global::ControlVentas.Properties.Resources.bin;
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 94;
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.HeaderText = "Eliminar";
            this.dataGridViewImageColumn3.Image = global::ControlVentas.Properties.Resources.bin;
            this.dataGridViewImageColumn3.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            this.dataGridViewImageColumn3.Width = 82;
            // 
            // panelContent
            // 
            this.panelContent.AutoScroll = true;
            this.panelContent.AutoSize = true;
            this.panelContent.Controls.Add(this.dataGridViewOrders);
            this.panelContent.Controls.Add(this.panelControls);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(660, 409);
            this.panelContent.TabIndex = 6;
            // 
            // dataGridViewOrders
            // 
            this.dataGridViewOrders.AllowUserToAddRows = false;
            this.dataGridViewOrders.AllowUserToDeleteRows = false;
            this.dataGridViewOrders.AllowUserToResizeRows = false;
            this.dataGridViewOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewOrders.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(46)))), ((int)(((byte)(50)))));
            this.dataGridViewOrders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewOrders.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewOrders.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(49)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(49)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnOrder,
            this.ColumnDescription,
            this.ColumnPriceKilo,
            this.ColumnWeight,
            this.ColumnExactAmount,
            this.ColumnAmount,
            this.ColumnEdit,
            this.ColumnDelete});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(58)))), ((int)(((byte)(71)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(146)))), ((int)(((byte)(164)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewOrders.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOrders.EnableHeadersVisualStyles = false;
            this.dataGridViewOrders.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(46)))), ((int)(((byte)(50)))));
            this.dataGridViewOrders.Location = new System.Drawing.Point(0, 265);
            this.dataGridViewOrders.MultiSelect = false;
            this.dataGridViewOrders.Name = "dataGridViewOrders";
            this.dataGridViewOrders.ReadOnly = true;
            this.dataGridViewOrders.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewOrders.RowHeadersVisible = false;
            this.dataGridViewOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOrders.Size = new System.Drawing.Size(660, 144);
            this.dataGridViewOrders.TabIndex = 7;
            this.dataGridViewOrders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOrders_CellContentClick);
            // 
            // ColumnOrder
            // 
            this.ColumnOrder.HeaderText = "Pedido";
            this.ColumnOrder.Name = "ColumnOrder";
            this.ColumnOrder.ReadOnly = true;
            this.ColumnOrder.Visible = false;
            // 
            // ColumnDescription
            // 
            this.ColumnDescription.HeaderText = "Descripción";
            this.ColumnDescription.Name = "ColumnDescription";
            this.ColumnDescription.ReadOnly = true;
            this.ColumnDescription.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnDescription.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnPriceKilo
            // 
            this.ColumnPriceKilo.HeaderText = "Precio por Kg";
            this.ColumnPriceKilo.Name = "ColumnPriceKilo";
            this.ColumnPriceKilo.ReadOnly = true;
            this.ColumnPriceKilo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnPriceKilo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnWeight
            // 
            this.ColumnWeight.HeaderText = "Peso";
            this.ColumnWeight.Name = "ColumnWeight";
            this.ColumnWeight.ReadOnly = true;
            this.ColumnWeight.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnWeight.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnExactAmount
            // 
            this.ColumnExactAmount.HeaderText = "Cantidad exacta";
            this.ColumnExactAmount.Name = "ColumnExactAmount";
            this.ColumnExactAmount.ReadOnly = true;
            this.ColumnExactAmount.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ColumnAmount
            // 
            this.ColumnAmount.HeaderText = "Importe";
            this.ColumnAmount.Name = "ColumnAmount";
            this.ColumnAmount.ReadOnly = true;
            this.ColumnAmount.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnAmount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnEdit
            // 
            this.ColumnEdit.HeaderText = "Editar";
            this.ColumnEdit.Image = global::ControlVentas.Properties.Resources.pencil;
            this.ColumnEdit.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.ColumnEdit.Name = "ColumnEdit";
            this.ColumnEdit.ReadOnly = true;
            this.ColumnEdit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ColumnDelete
            // 
            this.ColumnDelete.HeaderText = "Eliminar";
            this.ColumnDelete.Image = global::ControlVentas.Properties.Resources.bin;
            this.ColumnDelete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.ColumnDelete.Name = "ColumnDelete";
            this.ColumnDelete.ReadOnly = true;
            this.ColumnDelete.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // panelControls
            // 
            this.panelControls.AutoSize = true;
            this.panelControls.BackColor = System.Drawing.Color.White;
            this.panelControls.ColumnCount = 4;
            this.panelControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.panelControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.panelControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.25F));
            this.panelControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.25F));
            this.panelControls.Controls.Add(this.label4, 0, 3);
            this.panelControls.Controls.Add(this.label3, 0, 2);
            this.panelControls.Controls.Add(this.labelPriceKilo, 0, 1);
            this.panelControls.Controls.Add(this.label1, 0, 0);
            this.panelControls.Controls.Add(this.checkBoxExactAmount, 2, 1);
            this.panelControls.Controls.Add(this.label6, 0, 4);
            this.panelControls.Controls.Add(this.label8, 2, 4);
            this.panelControls.Controls.Add(this.labelIndividualAmount, 1, 4);
            this.panelControls.Controls.Add(this.labelTotalAmount, 3, 4);
            this.panelControls.Controls.Add(this.buttonAddOrder, 3, 2);
            this.panelControls.Controls.Add(this.buttonEndSale, 3, 1);
            this.panelControls.Controls.Add(this.panelCustomer, 1, 0);
            this.panelControls.Controls.Add(this.panel2, 1, 1);
            this.panelControls.Controls.Add(this.panel3, 1, 2);
            this.panelControls.Controls.Add(this.panel4, 1, 3);
            this.panelControls.Controls.Add(this.textBoxAmount, 2, 2);
            this.panelControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControls.Location = new System.Drawing.Point(0, 0);
            this.panelControls.Name = "panelControls";
            this.panelControls.Padding = new System.Windows.Forms.Padding(0, 15, 15, 0);
            this.panelControls.RowCount = 5;
            this.panelControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.panelControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.panelControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.panelControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.panelControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.panelControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panelControls.Size = new System.Drawing.Size(660, 265);
            this.panelControls.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(36)))), ((int)(((byte)(33)))));
            this.label4.Location = new System.Drawing.Point(3, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 30);
            this.label4.TabIndex = 11;
            this.label4.Tag = "textBox1";
            this.label4.Text = "Descripción:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(36)))), ((int)(((byte)(33)))));
            this.label3.Location = new System.Drawing.Point(3, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 30);
            this.label3.TabIndex = 8;
            this.label3.Tag = "textBox1";
            this.label3.Text = "Peso:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelPriceKilo
            // 
            this.labelPriceKilo.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelPriceKilo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelPriceKilo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(36)))), ((int)(((byte)(33)))));
            this.labelPriceKilo.Location = new System.Drawing.Point(3, 65);
            this.labelPriceKilo.Name = "labelPriceKilo";
            this.labelPriceKilo.Size = new System.Drawing.Size(123, 30);
            this.labelPriceKilo.TabIndex = 5;
            this.labelPriceKilo.Tag = "textBox1";
            this.labelPriceKilo.Text = "Precio por Kg:";
            this.labelPriceKilo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(36)))), ((int)(((byte)(33)))));
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 30);
            this.label1.TabIndex = 3;
            this.label1.Tag = "";
            this.label1.Text = "Cliente:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // checkBoxExactAmount
            // 
            this.checkBoxExactAmount.BaseColor = System.Drawing.Color.White;
            this.checkBoxExactAmount.CheckedOffColor = System.Drawing.Color.Gray;
            this.checkBoxExactAmount.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.checkBoxExactAmount.Dock = System.Windows.Forms.DockStyle.Right;
            this.checkBoxExactAmount.FillColor = System.Drawing.Color.White;
            this.checkBoxExactAmount.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxExactAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(36)))), ((int)(((byte)(33)))));
            this.checkBoxExactAmount.Location = new System.Drawing.Point(340, 68);
            this.checkBoxExactAmount.Name = "checkBoxExactAmount";
            this.checkBoxExactAmount.Radius = 3;
            this.checkBoxExactAmount.Size = new System.Drawing.Size(140, 24);
            this.checkBoxExactAmount.TabIndex = 7;
            this.checkBoxExactAmount.Text = "Cantidad exacta";
            this.checkBoxExactAmount.CheckedChanged += new System.EventHandler(this.checkBoxExactAmount_CheckedChanged);
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(36)))), ((int)(((byte)(33)))));
            this.label6.Location = new System.Drawing.Point(3, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 30);
            this.label6.TabIndex = 13;
            this.label6.Tag = "textBox1";
            this.label6.Text = "Importe:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(36)))), ((int)(((byte)(33)))));
            this.label8.Location = new System.Drawing.Point(325, 215);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 30);
            this.label8.TabIndex = 15;
            this.label8.Tag = "textBox1";
            this.label8.Text = "Importe total:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelIndividualAmount
            // 
            this.labelIndividualAmount.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelIndividualAmount.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIndividualAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(161)))), ((int)(((byte)(187)))));
            this.labelIndividualAmount.Location = new System.Drawing.Point(132, 215);
            this.labelIndividualAmount.Name = "labelIndividualAmount";
            this.labelIndividualAmount.Size = new System.Drawing.Size(187, 29);
            this.labelIndividualAmount.TabIndex = 14;
            this.labelIndividualAmount.Tag = "textBox1";
            this.labelIndividualAmount.Text = "$0.00";
            this.labelIndividualAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTotalAmount
            // 
            this.labelTotalAmount.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTotalAmount.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(161)))), ((int)(((byte)(187)))));
            this.labelTotalAmount.Location = new System.Drawing.Point(486, 215);
            this.labelTotalAmount.Name = "labelTotalAmount";
            this.labelTotalAmount.Size = new System.Drawing.Size(156, 29);
            this.labelTotalAmount.TabIndex = 20;
            this.labelTotalAmount.Tag = "textBox1";
            this.labelTotalAmount.Text = "$0.00";
            this.labelTotalAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonAddOrder
            // 
            this.buttonAddOrder.AnimationHoverSpeed = 0.07F;
            this.buttonAddOrder.AnimationSpeed = 0.03F;
            this.buttonAddOrder.BackColor = System.Drawing.Color.Transparent;
            this.buttonAddOrder.BaseColor = System.Drawing.Color.Transparent;
            this.buttonAddOrder.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(146)))), ((int)(((byte)(164)))));
            this.buttonAddOrder.BorderSize = 1;
            this.buttonAddOrder.DialogResult = System.Windows.Forms.DialogResult.None;
            this.buttonAddOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAddOrder.FocusedColor = System.Drawing.Color.Empty;
            this.buttonAddOrder.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(36)))), ((int)(((byte)(33)))));
            this.buttonAddOrder.Image = null;
            this.buttonAddOrder.ImageSize = new System.Drawing.Size(20, 20);
            this.buttonAddOrder.Location = new System.Drawing.Point(498, 118);
            this.buttonAddOrder.Margin = new System.Windows.Forms.Padding(15, 3, 10, 3);
            this.buttonAddOrder.Name = "buttonAddOrder";
            this.buttonAddOrder.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.buttonAddOrder.OnHoverBorderColor = System.Drawing.Color.White;
            this.buttonAddOrder.OnHoverForeColor = System.Drawing.Color.White;
            this.buttonAddOrder.OnHoverImage = null;
            this.buttonAddOrder.OnPressedColor = System.Drawing.Color.Black;
            this.buttonAddOrder.Radius = 5;
            this.buttonAddOrder.Size = new System.Drawing.Size(137, 44);
            this.buttonAddOrder.TabIndex = 18;
            this.buttonAddOrder.Text = "Agregar pedido";
            this.buttonAddOrder.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.buttonAddOrder.Click += new System.EventHandler(this.buttonAddOrder_Click);
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
            this.buttonEndSale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(36)))), ((int)(((byte)(33)))));
            this.buttonEndSale.Image = null;
            this.buttonEndSale.ImageSize = new System.Drawing.Size(20, 20);
            this.buttonEndSale.Location = new System.Drawing.Point(498, 68);
            this.buttonEndSale.Margin = new System.Windows.Forms.Padding(15, 3, 10, 3);
            this.buttonEndSale.Name = "buttonEndSale";
            this.buttonEndSale.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.buttonEndSale.OnHoverBorderColor = System.Drawing.Color.White;
            this.buttonEndSale.OnHoverForeColor = System.Drawing.Color.White;
            this.buttonEndSale.OnHoverImage = null;
            this.buttonEndSale.OnPressedColor = System.Drawing.Color.Black;
            this.buttonEndSale.Radius = 5;
            this.buttonEndSale.Size = new System.Drawing.Size(137, 44);
            this.buttonEndSale.TabIndex = 17;
            this.buttonEndSale.Text = "Terminar venta";
            this.buttonEndSale.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.buttonEndSale.Click += new System.EventHandler(this.buttonEndSale_Click);
            // 
            // panelCustomer
            // 
            this.panelCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.panelControls.SetColumnSpan(this.panelCustomer, 2);
            this.panelCustomer.Controls.Add(this.comboBoxCustomer);
            this.panelCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCustomer.Location = new System.Drawing.Point(132, 18);
            this.panelCustomer.Name = "panelCustomer";
            this.panelCustomer.Size = new System.Drawing.Size(348, 31);
            this.panelCustomer.TabIndex = 22;
            // 
            // comboBoxCustomer
            // 
            this.comboBoxCustomer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxCustomer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.comboBoxCustomer.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxCustomer.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.comboBoxCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(36)))), ((int)(((byte)(33)))));
            this.comboBoxCustomer.FormattingEnabled = true;
            this.comboBoxCustomer.Location = new System.Drawing.Point(0, 0);
            this.comboBoxCustomer.Name = "comboBoxCustomer";
            this.comboBoxCustomer.Size = new System.Drawing.Size(348, 29);
            this.comboBoxCustomer.TabIndex = 23;
            this.comboBoxCustomer.Validated += new System.EventHandler(this.comboBoxCustomer_Validated);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.panel2.Controls.Add(this.textBoxPriceKilo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(132, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(187, 24);
            this.panel2.TabIndex = 22;
            // 
            // textBoxPriceKilo
            // 
            this.textBoxPriceKilo.BackColor = System.Drawing.Color.White;
            this.textBoxPriceKilo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPriceKilo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxPriceKilo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBoxPriceKilo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(36)))), ((int)(((byte)(33)))));
            this.textBoxPriceKilo.Location = new System.Drawing.Point(0, 0);
            this.textBoxPriceKilo.Margin = new System.Windows.Forms.Padding(3, 3, 30, 3);
            this.textBoxPriceKilo.MaxLength = 8;
            this.textBoxPriceKilo.Name = "textBoxPriceKilo";
            this.textBoxPriceKilo.Size = new System.Drawing.Size(187, 22);
            this.textBoxPriceKilo.TabIndex = 6;
            this.textBoxPriceKilo.Tag = "";
            this.textBoxPriceKilo.TextChanged += new System.EventHandler(this.textBoxPriceKilo_TextChanged);
            this.textBoxPriceKilo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPriceKilo_KeyPress);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.panel3.Controls.Add(this.textBoxWeight);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(132, 118);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(187, 24);
            this.panel3.TabIndex = 22;
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.BackColor = System.Drawing.Color.White;
            this.textBoxWeight.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxWeight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxWeight.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBoxWeight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(36)))), ((int)(((byte)(33)))));
            this.textBoxWeight.Location = new System.Drawing.Point(0, 0);
            this.textBoxWeight.Margin = new System.Windows.Forms.Padding(3, 3, 30, 3);
            this.textBoxWeight.MaxLength = 5;
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.Size = new System.Drawing.Size(187, 22);
            this.textBoxWeight.TabIndex = 9;
            this.textBoxWeight.Tag = "";
            this.textBoxWeight.TextChanged += new System.EventHandler(this.textBoxWeight_TextChanged);
            this.textBoxWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxWeight_KeyPress);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.panelControls.SetColumnSpan(this.panel4, 2);
            this.panel4.Controls.Add(this.textBoxDescription);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(132, 168);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(348, 24);
            this.panel4.TabIndex = 22;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.BackColor = System.Drawing.Color.White;
            this.textBoxDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxDescription.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBoxDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(36)))), ((int)(((byte)(33)))));
            this.textBoxDescription.Location = new System.Drawing.Point(0, 0);
            this.textBoxDescription.Margin = new System.Windows.Forms.Padding(3, 3, 30, 3);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(348, 22);
            this.textBoxDescription.TabIndex = 10;
            this.textBoxDescription.Tag = "";
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxAmount.Location = new System.Drawing.Point(325, 118);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(155, 20);
            this.textBoxAmount.TabIndex = 23;
            this.textBoxAmount.Visible = false;
            // 
            // panelMain
            // 
            this.panelMain.AutoScroll = true;
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(36)))), ((int)(((byte)(33)))));
            this.panelMain.Controls.Add(this.panelEditingForm);
            this.panelMain.Controls.Add(this.panelContent);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(660, 409);
            this.panelMain.TabIndex = 1;
            // 
            // panelEditingForm
            // 
            this.panelEditingForm.AutoSize = true;
            this.panelEditingForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelEditingForm.Location = new System.Drawing.Point(0, 0);
            this.panelEditingForm.Name = "panelEditingForm";
            this.panelEditingForm.Size = new System.Drawing.Size(0, 409);
            this.panelEditingForm.TabIndex = 7;
            // 
            // FormToSell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 409);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormToSell";
            this.Text = "FormToSell";
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).EndInit();
            this.panelControls.ResumeLayout(false);
            this.panelControls.PerformLayout();
            this.panelCustomer.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.TableLayoutPanel panelControls;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPriceKilo;
        private System.Windows.Forms.Label labelPriceKilo;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaCheckBox checkBoxExactAmount;
        private System.Windows.Forms.TextBox textBoxWeight;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelIndividualAmount;
        private System.Windows.Forms.Label labelTotalAmount;
        private Guna.UI.WinForms.GunaButton buttonAddOrder;
        private Guna.UI.WinForms.GunaButton buttonEndSale;
        private System.Windows.Forms.DataGridView dataGridViewOrders;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelEditingForm;
        private System.Windows.Forms.Panel panelCustomer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox comboBoxCustomer;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPriceKilo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnWeight;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnExactAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAmount;
        private System.Windows.Forms.DataGridViewImageColumn ColumnEdit;
        private System.Windows.Forms.DataGridViewImageColumn ColumnDelete;
    }
}