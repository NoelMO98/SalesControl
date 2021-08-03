
namespace ControlVentas.PresentationLayer
{
    partial class FormSalesControl
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
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelData = new System.Windows.Forms.Panel();
            this.dataGridViewOrders = new System.Windows.Forms.DataGridView();
            this.ColumnUnpaidOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.radioButtonAll = new System.Windows.Forms.RadioButton();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.buttonBack = new System.Windows.Forms.Button();
            this.panelMain.SuspendLayout();
            this.panelData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).BeginInit();
            this.panelSide.SuspendLayout();
            this.panelFilteredDates.SuspendLayout();
            this.panelMonthCalendar.SuspendLayout();
            this.panelRadioButtons.SuspendLayout();
            this.panelSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.AutoScroll = true;
            this.panelMain.AutoSize = true;
            this.panelMain.Controls.Add(this.panelData);
            this.panelMain.Controls.Add(this.panelSearch);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(660, 409);
            this.panelMain.TabIndex = 12;
            // 
            // panelData
            // 
            this.panelData.AutoScroll = true;
            this.panelData.AutoSize = true;
            this.panelData.BackColor = System.Drawing.Color.White;
            this.panelData.Controls.Add(this.dataGridViewOrders);
            this.panelData.Controls.Add(this.panelSide);
            this.panelData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelData.Location = new System.Drawing.Point(0, 37);
            this.panelData.Margin = new System.Windows.Forms.Padding(0);
            this.panelData.Name = "panelData";
            this.panelData.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.panelData.Size = new System.Drawing.Size(660, 372);
            this.panelData.TabIndex = 14;
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
            this.ColumnUnpaidOrder,
            this.ColumnDate,
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
            this.dataGridViewOrders.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOrders.EnableHeadersVisualStyles = false;
            this.dataGridViewOrders.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(46)))), ((int)(((byte)(50)))));
            this.dataGridViewOrders.Location = new System.Drawing.Point(0, 10);
            this.dataGridViewOrders.MultiSelect = false;
            this.dataGridViewOrders.Name = "dataGridViewOrders";
            this.dataGridViewOrders.ReadOnly = true;
            this.dataGridViewOrders.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewOrders.RowHeadersVisible = false;
            this.dataGridViewOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOrders.Size = new System.Drawing.Size(386, 362);
            this.dataGridViewOrders.TabIndex = 8;
            // 
            // ColumnUnpaidOrder
            // 
            this.ColumnUnpaidOrder.HeaderText = "Order";
            this.ColumnUnpaidOrder.Name = "ColumnUnpaidOrder";
            this.ColumnUnpaidOrder.ReadOnly = true;
            this.ColumnUnpaidOrder.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnDate
            // 
            this.ColumnDate.HeaderText = "Fecha";
            this.ColumnDate.Name = "ColumnDate";
            this.ColumnDate.ReadOnly = true;
            this.ColumnDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
            this.panelSide.Location = new System.Drawing.Point(386, 10);
            this.panelSide.Margin = new System.Windows.Forms.Padding(0);
            this.panelSide.Name = "panelSide";
            this.panelSide.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.panelSide.Size = new System.Drawing.Size(274, 362);
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
            this.panelFilteredDates.Size = new System.Drawing.Size(254, 362);
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
            this.label8.Size = new System.Drawing.Size(248, 51);
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
            this.panelMonthCalendar.Location = new System.Drawing.Point(3, 99);
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
            // 
            // panelRadioButtons
            // 
            this.panelRadioButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(46)))), ((int)(((byte)(50)))));
            this.panelFilteredDates.SetColumnSpan(this.panelRadioButtons, 2);
            this.panelRadioButtons.Controls.Add(this.radioButtonByDay);
            this.panelRadioButtons.Controls.Add(this.radioButtonByWeek);
            this.panelRadioButtons.Controls.Add(this.radioButtonAll);
            this.panelRadioButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRadioButtons.ForeColor = System.Drawing.Color.White;
            this.panelRadioButtons.Location = new System.Drawing.Point(3, 54);
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
            // 
            // radioButtonAll
            // 
            this.radioButtonAll.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonAll.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radioButtonAll.Checked = true;
            this.radioButtonAll.Dock = System.Windows.Forms.DockStyle.Left;
            this.radioButtonAll.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.radioButtonAll.FlatAppearance.BorderSize = 10;
            this.radioButtonAll.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.radioButtonAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.radioButtonAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.radioButtonAll.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.radioButtonAll.ForeColor = System.Drawing.Color.White;
            this.radioButtonAll.Location = new System.Drawing.Point(0, 0);
            this.radioButtonAll.Name = "radioButtonAll";
            this.radioButtonAll.Size = new System.Drawing.Size(68, 39);
            this.radioButtonAll.TabIndex = 0;
            this.radioButtonAll.TabStop = true;
            this.radioButtonAll.Text = "Todas";
            this.radioButtonAll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonAll.UseVisualStyleBackColor = false;
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
            // 
            // FormSalesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(660, 409);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSalesControl";
            this.Text = "FormToSell";
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panelData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).EndInit();
            this.panelSide.ResumeLayout(false);
            this.panelFilteredDates.ResumeLayout(false);
            this.panelFilteredDates.PerformLayout();
            this.panelMonthCalendar.ResumeLayout(false);
            this.panelRadioButtons.ResumeLayout(false);
            this.panelSearch.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelData;
        private System.Windows.Forms.DataGridView dataGridViewOrders;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUnpaidOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRemainder;
        private System.Windows.Forms.Panel panelSide;
        private System.Windows.Forms.TableLayoutPanel panelFilteredDates;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panelMonthCalendar;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.Panel panelRadioButtons;
        private System.Windows.Forms.RadioButton radioButtonByDay;
        private System.Windows.Forms.RadioButton radioButtonByWeek;
        private System.Windows.Forms.RadioButton radioButtonAll;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.Button buttonBack;
    }
}