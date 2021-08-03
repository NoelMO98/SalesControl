
namespace ControlVentas.PresentationLayer
{
    partial class FormCustomers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCustomers));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panelSide = new System.Windows.Forms.Panel();
            this.tableLayoutPanelButtons = new System.Windows.Forms.TableLayoutPanel();
            this.buttonSave = new Guna.UI.WinForms.GunaButton();
            this.tableLayoutPanelTelephone = new System.Windows.Forms.TableLayoutPanel();
            this.panelControls = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelPriceKilo = new System.Windows.Forms.Label();
            this.buttonNewTelephone = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panelName = new System.Windows.Forms.Panel();
            this.textBoxCustomer = new System.Windows.Forms.TextBox();
            this.panelAddress = new System.Windows.Forms.Panel();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.panelTelephones = new System.Windows.Forms.Panel();
            this.maskedTextBoxTelephone = new ControlVentas.PresentationLayer.MaskedTextBoxesTelephone();
            this.panelCustomers = new System.Windows.Forms.Panel();
            this.panelDataGridView = new System.Windows.Forms.Panel();
            this.dataGridViewCustomers = new System.Windows.Forms.DataGridView();
            this.ColumnCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTelephoneNumbers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDebtor = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColumnEdit = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColumnDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelSearchTextBox = new System.Windows.Forms.Panel();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelSide.SuspendLayout();
            this.tableLayoutPanelButtons.SuspendLayout();
            this.panelControls.SuspendLayout();
            this.panelName.SuspendLayout();
            this.panelAddress.SuspendLayout();
            this.panelTelephones.SuspendLayout();
            this.panelCustomers.SuspendLayout();
            this.panelDataGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomers)).BeginInit();
            this.panelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelMain.SuspendLayout();
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
            // panelSide
            // 
            this.panelSide.AutoScroll = true;
            this.panelSide.BackColor = System.Drawing.Color.White;
            this.panelSide.Controls.Add(this.tableLayoutPanelButtons);
            this.panelSide.Controls.Add(this.tableLayoutPanelTelephone);
            this.panelSide.Controls.Add(this.panelControls);
            this.panelSide.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelSide.Location = new System.Drawing.Point(340, 0);
            this.panelSide.Margin = new System.Windows.Forms.Padding(0);
            this.panelSide.Name = "panelSide";
            this.panelSide.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.panelSide.Size = new System.Drawing.Size(320, 409);
            this.panelSide.TabIndex = 10;
            this.panelSide.Visible = false;
            // 
            // tableLayoutPanelButtons
            // 
            this.tableLayoutPanelButtons.AutoSize = true;
            this.tableLayoutPanelButtons.ColumnCount = 2;
            this.tableLayoutPanelButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelButtons.Controls.Add(this.buttonSave, 0, 0);
            this.tableLayoutPanelButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanelButtons.Location = new System.Drawing.Point(10, 225);
            this.tableLayoutPanelButtons.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelButtons.Name = "tableLayoutPanelButtons";
            this.tableLayoutPanelButtons.RowCount = 1;
            this.tableLayoutPanelButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanelButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanelButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanelButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanelButtons.Size = new System.Drawing.Size(300, 50);
            this.tableLayoutPanelButtons.TabIndex = 10;
            // 
            // buttonSave
            // 
            this.buttonSave.AnimationHoverSpeed = 0.07F;
            this.buttonSave.AnimationSpeed = 0.03F;
            this.buttonSave.BackColor = System.Drawing.Color.Transparent;
            this.buttonSave.BaseColor = System.Drawing.Color.Transparent;
            this.buttonSave.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(146)))), ((int)(((byte)(164)))));
            this.buttonSave.BorderSize = 1;
            this.tableLayoutPanelButtons.SetColumnSpan(this.buttonSave, 2);
            this.buttonSave.DialogResult = System.Windows.Forms.DialogResult.None;
            this.buttonSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSave.FocusedColor = System.Drawing.Color.Empty;
            this.buttonSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(36)))), ((int)(((byte)(33)))));
            this.buttonSave.Image = null;
            this.buttonSave.ImageSize = new System.Drawing.Size(20, 20);
            this.buttonSave.Location = new System.Drawing.Point(0, 0);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.buttonSave.OnHoverBorderColor = System.Drawing.Color.White;
            this.buttonSave.OnHoverForeColor = System.Drawing.Color.White;
            this.buttonSave.OnHoverImage = null;
            this.buttonSave.OnPressedColor = System.Drawing.Color.Black;
            this.buttonSave.Radius = 5;
            this.buttonSave.Size = new System.Drawing.Size(300, 50);
            this.buttonSave.TabIndex = 18;
            this.buttonSave.Text = "Guardar";
            this.buttonSave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // tableLayoutPanelTelephone
            // 
            this.tableLayoutPanelTelephone.AutoSize = true;
            this.tableLayoutPanelTelephone.ColumnCount = 2;
            this.tableLayoutPanelTelephone.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelTelephone.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelTelephone.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanelTelephone.Location = new System.Drawing.Point(10, 225);
            this.tableLayoutPanelTelephone.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelTelephone.Name = "tableLayoutPanelTelephone";
            this.tableLayoutPanelTelephone.Size = new System.Drawing.Size(300, 0);
            this.tableLayoutPanelTelephone.TabIndex = 9;
            // 
            // panelControls
            // 
            this.panelControls.AutoSize = true;
            this.panelControls.ColumnCount = 2;
            this.panelControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelControls.Controls.Add(this.label1, 0, 0);
            this.panelControls.Controls.Add(this.labelPriceKilo, 0, 2);
            this.panelControls.Controls.Add(this.buttonNewTelephone, 1, 5);
            this.panelControls.Controls.Add(this.label3, 0, 4);
            this.panelControls.Controls.Add(this.panelName, 0, 1);
            this.panelControls.Controls.Add(this.panelAddress, 0, 3);
            this.panelControls.Controls.Add(this.panelTelephones, 0, 5);
            this.panelControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControls.Location = new System.Drawing.Point(10, 0);
            this.panelControls.Margin = new System.Windows.Forms.Padding(0);
            this.panelControls.Name = "panelControls";
            this.panelControls.RowCount = 6;
            this.panelControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.panelControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.panelControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.panelControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.panelControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.panelControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.panelControls.Size = new System.Drawing.Size(300, 225);
            this.panelControls.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(36)))), ((int)(((byte)(33)))));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 45);
            this.label1.TabIndex = 3;
            this.label1.Tag = "textBox1";
            this.label1.Text = "Nombre:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // labelPriceKilo
            // 
            this.labelPriceKilo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelPriceKilo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelPriceKilo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(36)))), ((int)(((byte)(33)))));
            this.labelPriceKilo.Location = new System.Drawing.Point(0, 75);
            this.labelPriceKilo.Margin = new System.Windows.Forms.Padding(0);
            this.labelPriceKilo.Name = "labelPriceKilo";
            this.labelPriceKilo.Size = new System.Drawing.Size(150, 45);
            this.labelPriceKilo.TabIndex = 5;
            this.labelPriceKilo.Tag = "textBox1";
            this.labelPriceKilo.Text = "Dirección:";
            this.labelPriceKilo.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // buttonNewTelephone
            // 
            this.buttonNewTelephone.AutoSize = true;
            this.buttonNewTelephone.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonNewTelephone.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonNewTelephone.FlatAppearance.BorderSize = 0;
            this.buttonNewTelephone.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonNewTelephone.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonNewTelephone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNewTelephone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonNewTelephone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(36)))), ((int)(((byte)(33)))));
            this.buttonNewTelephone.Location = new System.Drawing.Point(153, 198);
            this.buttonNewTelephone.Name = "buttonNewTelephone";
            this.buttonNewTelephone.Size = new System.Drawing.Size(144, 24);
            this.buttonNewTelephone.TabIndex = 17;
            this.buttonNewTelephone.Text = "Agregar otro teléfono";
            this.buttonNewTelephone.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonNewTelephone.UseVisualStyleBackColor = true;
            this.buttonNewTelephone.Click += new System.EventHandler(this.buttonNewTelephone_Click);
            this.buttonNewTelephone.MouseLeave += new System.EventHandler(this.buttonNewTelephone_MouseLeave);
            this.buttonNewTelephone.MouseHover += new System.EventHandler(this.buttonNewTelephone_MouseHover);
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(36)))), ((int)(((byte)(33)))));
            this.label3.Location = new System.Drawing.Point(0, 150);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 45);
            this.label3.TabIndex = 8;
            this.label3.Tag = "textBox1";
            this.label3.Text = "Télefono 1:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // panelName
            // 
            this.panelName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.panelControls.SetColumnSpan(this.panelName, 2);
            this.panelName.Controls.Add(this.textBoxCustomer);
            this.panelName.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelName.Location = new System.Drawing.Point(3, 48);
            this.panelName.Name = "panelName";
            this.panelName.Size = new System.Drawing.Size(294, 24);
            this.panelName.TabIndex = 18;
            // 
            // textBoxCustomer
            // 
            this.textBoxCustomer.BackColor = System.Drawing.Color.White;
            this.textBoxCustomer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxCustomer.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBoxCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(36)))), ((int)(((byte)(33)))));
            this.textBoxCustomer.Location = new System.Drawing.Point(0, 0);
            this.textBoxCustomer.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxCustomer.Name = "textBoxCustomer";
            this.textBoxCustomer.Size = new System.Drawing.Size(294, 22);
            this.textBoxCustomer.TabIndex = 4;
            this.textBoxCustomer.Tag = "";
            // 
            // panelAddress
            // 
            this.panelAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.panelControls.SetColumnSpan(this.panelAddress, 2);
            this.panelAddress.Controls.Add(this.textBoxAddress);
            this.panelAddress.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAddress.Location = new System.Drawing.Point(3, 123);
            this.panelAddress.Name = "panelAddress";
            this.panelAddress.Size = new System.Drawing.Size(294, 24);
            this.panelAddress.TabIndex = 18;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.BackColor = System.Drawing.Color.White;
            this.textBoxAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxAddress.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBoxAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(36)))), ((int)(((byte)(33)))));
            this.textBoxAddress.Location = new System.Drawing.Point(0, 0);
            this.textBoxAddress.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(294, 22);
            this.textBoxAddress.TabIndex = 4;
            this.textBoxAddress.Tag = "";
            // 
            // panelTelephones
            // 
            this.panelTelephones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.panelTelephones.Controls.Add(this.maskedTextBoxTelephone);
            this.panelTelephones.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTelephones.Location = new System.Drawing.Point(3, 198);
            this.panelTelephones.Name = "panelTelephones";
            this.panelTelephones.Size = new System.Drawing.Size(144, 24);
            this.panelTelephones.TabIndex = 18;
            // 
            // maskedTextBoxTelephone
            // 
            this.maskedTextBoxTelephone.BackColor = System.Drawing.Color.White;
            this.maskedTextBoxTelephone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maskedTextBoxTelephone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.maskedTextBoxTelephone.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.maskedTextBoxTelephone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(36)))), ((int)(((byte)(33)))));
            this.maskedTextBoxTelephone.Location = new System.Drawing.Point(0, 0);
            this.maskedTextBoxTelephone.Margin = new System.Windows.Forms.Padding(3, 3, 30, 3);
            this.maskedTextBoxTelephone.Mask = "000-000-00-00";
            this.maskedTextBoxTelephone.Name = "maskedTextBoxTelephone";
            this.maskedTextBoxTelephone.Size = new System.Drawing.Size(144, 22);
            this.maskedTextBoxTelephone.TabIndex = 4;
            this.maskedTextBoxTelephone.TelephoneNumbers = null;
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
            this.panelCustomers.Size = new System.Drawing.Size(340, 409);
            this.panelCustomers.TabIndex = 11;
            // 
            // panelDataGridView
            // 
            this.panelDataGridView.AutoScroll = true;
            this.panelDataGridView.BackColor = System.Drawing.Color.White;
            this.panelDataGridView.Controls.Add(this.dataGridViewCustomers);
            this.panelDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDataGridView.Location = new System.Drawing.Point(0, 40);
            this.panelDataGridView.Margin = new System.Windows.Forms.Padding(0);
            this.panelDataGridView.Name = "panelDataGridView";
            this.panelDataGridView.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.panelDataGridView.Size = new System.Drawing.Size(340, 369);
            this.panelDataGridView.TabIndex = 10;
            // 
            // dataGridViewCustomers
            // 
            this.dataGridViewCustomers.AllowUserToAddRows = false;
            this.dataGridViewCustomers.AllowUserToDeleteRows = false;
            this.dataGridViewCustomers.AllowUserToResizeRows = false;
            this.dataGridViewCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCustomers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(46)))), ((int)(((byte)(50)))));
            this.dataGridViewCustomers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewCustomers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewCustomers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(49)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(49)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCustomers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCustomer,
            this.ColumnName,
            this.ColumnAddress,
            this.ColumnTelephoneNumbers,
            this.ColumnDebtor,
            this.ColumnEdit,
            this.ColumnDelete});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(58)))), ((int)(((byte)(71)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(146)))), ((int)(((byte)(164)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewCustomers.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewCustomers.EnableHeadersVisualStyles = false;
            this.dataGridViewCustomers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(46)))), ((int)(((byte)(50)))));
            this.dataGridViewCustomers.Location = new System.Drawing.Point(0, 15);
            this.dataGridViewCustomers.MultiSelect = false;
            this.dataGridViewCustomers.Name = "dataGridViewCustomers";
            this.dataGridViewCustomers.ReadOnly = true;
            this.dataGridViewCustomers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewCustomers.RowHeadersVisible = false;
            this.dataGridViewCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCustomers.Size = new System.Drawing.Size(340, 354);
            this.dataGridViewCustomers.TabIndex = 8;
            this.dataGridViewCustomers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCustomers_CellContentClick);
            this.dataGridViewCustomers.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCustomers_CellDoubleClick);
            // 
            // ColumnCustomer
            // 
            this.ColumnCustomer.HeaderText = "Customer";
            this.ColumnCustomer.Name = "ColumnCustomer";
            this.ColumnCustomer.ReadOnly = true;
            this.ColumnCustomer.Visible = false;
            // 
            // ColumnName
            // 
            this.ColumnName.HeaderText = "Nombre";
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.ReadOnly = true;
            this.ColumnName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnAddress
            // 
            this.ColumnAddress.HeaderText = "Dirección";
            this.ColumnAddress.Name = "ColumnAddress";
            this.ColumnAddress.ReadOnly = true;
            this.ColumnAddress.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnAddress.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnTelephoneNumbers
            // 
            this.ColumnTelephoneNumbers.HeaderText = "Télefono(s)";
            this.ColumnTelephoneNumbers.Name = "ColumnTelephoneNumbers";
            this.ColumnTelephoneNumbers.ReadOnly = true;
            this.ColumnTelephoneNumbers.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnTelephoneNumbers.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnDebtor
            // 
            this.ColumnDebtor.HeaderText = "Deudor";
            this.ColumnDebtor.Name = "ColumnDebtor";
            this.ColumnDebtor.ReadOnly = true;
            this.ColumnDebtor.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ColumnEdit
            // 
            this.ColumnEdit.HeaderText = "Editar";
            this.ColumnEdit.Image = ((System.Drawing.Image)(resources.GetObject("ColumnEdit.Image")));
            this.ColumnEdit.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.ColumnEdit.Name = "ColumnEdit";
            this.ColumnEdit.ReadOnly = true;
            this.ColumnEdit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ColumnDelete
            // 
            this.ColumnDelete.HeaderText = "Eliminar";
            this.ColumnDelete.Image = ((System.Drawing.Image)(resources.GetObject("ColumnDelete.Image")));
            this.ColumnDelete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.ColumnDelete.Name = "ColumnDelete";
            this.ColumnDelete.ReadOnly = true;
            this.ColumnDelete.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // panelSearch
            // 
            this.panelSearch.AutoSize = true;
            this.panelSearch.BackColor = System.Drawing.Color.White;
            this.panelSearch.Controls.Add(this.pictureBox2);
            this.panelSearch.Controls.Add(this.panelSearchTextBox);
            this.panelSearch.Controls.Add(this.textBoxSearch);
            this.panelSearch.Controls.Add(this.buttonMenu);
            this.panelSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearch.Location = new System.Drawing.Point(0, 0);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(340, 40);
            this.panelSearch.TabIndex = 9;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(240, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // panelSearchTextBox
            // 
            this.panelSearchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSearchTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.panelSearchTextBox.Location = new System.Drawing.Point(26, 35);
            this.panelSearchTextBox.Name = "panelSearchTextBox";
            this.panelSearchTextBox.Size = new System.Drawing.Size(208, 2);
            this.panelSearchTextBox.TabIndex = 8;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearch.BackColor = System.Drawing.Color.White;
            this.textBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSearch.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBoxSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(36)))), ((int)(((byte)(33)))));
            this.textBoxSearch.Location = new System.Drawing.Point(26, 12);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(3, 3, 30, 3);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(208, 22);
            this.textBoxSearch.TabIndex = 5;
            this.textBoxSearch.Tag = "";
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // buttonMenu
            // 
            this.buttonMenu.AutoSize = true;
            this.buttonMenu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonMenu.FlatAppearance.BorderSize = 0;
            this.buttonMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMenu.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.buttonMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(36)))), ((int)(((byte)(33)))));
            this.buttonMenu.Location = new System.Drawing.Point(299, 0);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(41, 40);
            this.buttonMenu.TabIndex = 17;
            this.buttonMenu.Text = "☰";
            this.buttonMenu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonMenu.UseVisualStyleBackColor = true;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            this.buttonMenu.MouseLeave += new System.EventHandler(this.buttonMenu_MouseLeave);
            this.buttonMenu.MouseHover += new System.EventHandler(this.buttonMenu_MouseHover);
            // 
            // panelMain
            // 
            this.panelMain.AutoScroll = true;
            this.panelMain.AutoSize = true;
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(36)))), ((int)(((byte)(33)))));
            this.panelMain.Controls.Add(this.panelCustomers);
            this.panelMain.Controls.Add(this.panelSide);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(660, 409);
            this.panelMain.TabIndex = 1;
            // 
            // FormCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(660, 409);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCustomers";
            this.Text = "FormToSell";
            this.panelSide.ResumeLayout(false);
            this.panelSide.PerformLayout();
            this.tableLayoutPanelButtons.ResumeLayout(false);
            this.panelControls.ResumeLayout(false);
            this.panelControls.PerformLayout();
            this.panelName.ResumeLayout(false);
            this.panelName.PerformLayout();
            this.panelAddress.ResumeLayout(false);
            this.panelAddress.PerformLayout();
            this.panelTelephones.ResumeLayout(false);
            this.panelTelephones.PerformLayout();
            this.panelCustomers.ResumeLayout(false);
            this.panelCustomers.PerformLayout();
            this.panelDataGridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomers)).EndInit();
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.Panel panelSide;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelButtons;
        private Guna.UI.WinForms.GunaButton buttonSave;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelTelephone;
        private System.Windows.Forms.TableLayoutPanel panelControls;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelPriceKilo;
        private MaskedTextBoxesTelephone maskedTextBoxTelephone;
        private System.Windows.Forms.Button buttonNewTelephone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelName;
        private System.Windows.Forms.TextBox textBoxCustomer;
        private System.Windows.Forms.Panel panelAddress;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Panel panelCustomers;
        private System.Windows.Forms.DataGridView dataGridViewCustomers;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panelSearchTextBox;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonMenu;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelDataGridView;
        private System.Windows.Forms.Panel panelTelephones;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTelephoneNumbers;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnDebtor;
        private System.Windows.Forms.DataGridViewImageColumn ColumnEdit;
        private System.Windows.Forms.DataGridViewImageColumn ColumnDelete;
    }
}