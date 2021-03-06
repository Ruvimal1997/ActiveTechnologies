﻿namespace Active_Technologies
{
    partial class Purchase_Order_Details
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Lbl_PurchaseID = new MetroFramework.Controls.MetroLabel();
            this.Txt_PurchaseID = new MetroFramework.Controls.MetroTextBox();
            this.Lbl_DueDate = new MetroFramework.Controls.MetroLabel();
            this.Dtp_DueDate = new MetroFramework.Controls.MetroDateTime();
            this.Rbn_Pending = new MetroFramework.Controls.MetroRadioButton();
            this.Rbn_Invoiced = new MetroFramework.Controls.MetroRadioButton();
            this.Rbn_Paid = new MetroFramework.Controls.MetroRadioButton();
            this.Rbn_Delivered = new MetroFramework.Controls.MetroRadioButton();
            this.Lbl_Item = new MetroFramework.Controls.MetroLabel();
            this.Txt_Item = new MetroFramework.Controls.MetroTextBox();
            this.Lbl_Qty = new MetroFramework.Controls.MetroLabel();
            this.Txt_Qty = new MetroFramework.Controls.MetroTextBox();
            this.Btn_Add = new MetroFramework.Controls.MetroButton();
            this.Btn_Remove = new MetroFramework.Controls.MetroButton();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lbl_Total = new MetroFramework.Controls.MetroLabel();
            this.Txt_Total = new MetroFramework.Controls.MetroTextBox();
            this.Btn_Save = new MetroFramework.Controls.MetroButton();
            this.Btn_Print = new MetroFramework.Controls.MetroButton();
            this.Btn_Exit = new MetroFramework.Controls.MetroButton();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.Rbn_Sales = new MetroFramework.Controls.MetroRadioButton();
            this.Rbn_Service = new MetroFramework.Controls.MetroRadioButton();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lbl_PurchaseID
            // 
            this.Lbl_PurchaseID.AutoSize = true;
            this.Lbl_PurchaseID.Location = new System.Drawing.Point(57, 99);
            this.Lbl_PurchaseID.Name = "Lbl_PurchaseID";
            this.Lbl_PurchaseID.Size = new System.Drawing.Size(77, 19);
            this.Lbl_PurchaseID.TabIndex = 0;
            this.Lbl_PurchaseID.Text = "Purchase ID";
            // 
            // Txt_PurchaseID
            // 
            // 
            // 
            // 
            this.Txt_PurchaseID.CustomButton.Image = null;
            this.Txt_PurchaseID.CustomButton.Location = new System.Drawing.Point(81, 1);
            this.Txt_PurchaseID.CustomButton.Name = "";
            this.Txt_PurchaseID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Txt_PurchaseID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Txt_PurchaseID.CustomButton.TabIndex = 1;
            this.Txt_PurchaseID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Txt_PurchaseID.CustomButton.UseSelectable = true;
            this.Txt_PurchaseID.CustomButton.Visible = false;
            this.Txt_PurchaseID.Enabled = false;
            this.Txt_PurchaseID.Lines = new string[0];
            this.Txt_PurchaseID.Location = new System.Drawing.Point(153, 95);
            this.Txt_PurchaseID.MaxLength = 32767;
            this.Txt_PurchaseID.Name = "Txt_PurchaseID";
            this.Txt_PurchaseID.PasswordChar = '\0';
            this.Txt_PurchaseID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Txt_PurchaseID.SelectedText = "";
            this.Txt_PurchaseID.SelectionLength = 0;
            this.Txt_PurchaseID.SelectionStart = 0;
            this.Txt_PurchaseID.ShortcutsEnabled = true;
            this.Txt_PurchaseID.Size = new System.Drawing.Size(103, 23);
            this.Txt_PurchaseID.TabIndex = 1;
            this.Txt_PurchaseID.UseSelectable = true;
            this.Txt_PurchaseID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Txt_PurchaseID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Lbl_DueDate
            // 
            this.Lbl_DueDate.AutoSize = true;
            this.Lbl_DueDate.Location = new System.Drawing.Point(57, 141);
            this.Lbl_DueDate.Name = "Lbl_DueDate";
            this.Lbl_DueDate.Size = new System.Drawing.Size(63, 19);
            this.Lbl_DueDate.TabIndex = 2;
            this.Lbl_DueDate.Text = "Due Date";
            // 
            // Dtp_DueDate
            // 
            this.Dtp_DueDate.Location = new System.Drawing.Point(153, 131);
            this.Dtp_DueDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.Dtp_DueDate.Name = "Dtp_DueDate";
            this.Dtp_DueDate.Size = new System.Drawing.Size(200, 29);
            this.Dtp_DueDate.TabIndex = 3;
            // 
            // Rbn_Pending
            // 
            this.Rbn_Pending.AutoSize = true;
            this.Rbn_Pending.Location = new System.Drawing.Point(57, 193);
            this.Rbn_Pending.Name = "Rbn_Pending";
            this.Rbn_Pending.Size = new System.Drawing.Size(67, 15);
            this.Rbn_Pending.TabIndex = 4;
            this.Rbn_Pending.Text = "Pending";
            this.Rbn_Pending.UseSelectable = true;
            // 
            // Rbn_Invoiced
            // 
            this.Rbn_Invoiced.AutoSize = true;
            this.Rbn_Invoiced.Location = new System.Drawing.Point(130, 193);
            this.Rbn_Invoiced.Name = "Rbn_Invoiced";
            this.Rbn_Invoiced.Size = new System.Drawing.Size(68, 15);
            this.Rbn_Invoiced.TabIndex = 5;
            this.Rbn_Invoiced.Text = "Invoiced";
            this.Rbn_Invoiced.UseSelectable = true;
            // 
            // Rbn_Paid
            // 
            this.Rbn_Paid.AutoSize = true;
            this.Rbn_Paid.Location = new System.Drawing.Point(204, 193);
            this.Rbn_Paid.Name = "Rbn_Paid";
            this.Rbn_Paid.Size = new System.Drawing.Size(46, 15);
            this.Rbn_Paid.TabIndex = 6;
            this.Rbn_Paid.Text = "Paid";
            this.Rbn_Paid.UseSelectable = true;
            // 
            // Rbn_Delivered
            // 
            this.Rbn_Delivered.AutoSize = true;
            this.Rbn_Delivered.Location = new System.Drawing.Point(256, 193);
            this.Rbn_Delivered.Name = "Rbn_Delivered";
            this.Rbn_Delivered.Size = new System.Drawing.Size(72, 15);
            this.Rbn_Delivered.TabIndex = 7;
            this.Rbn_Delivered.Text = "Delivered";
            this.Rbn_Delivered.UseSelectable = true;
            // 
            // Lbl_Item
            // 
            this.Lbl_Item.AutoSize = true;
            this.Lbl_Item.Location = new System.Drawing.Point(57, 229);
            this.Lbl_Item.Name = "Lbl_Item";
            this.Lbl_Item.Size = new System.Drawing.Size(35, 19);
            this.Lbl_Item.TabIndex = 8;
            this.Lbl_Item.Text = "Item";
            // 
            // Txt_Item
            // 
            // 
            // 
            // 
            this.Txt_Item.CustomButton.Image = null;
            this.Txt_Item.CustomButton.Location = new System.Drawing.Point(501, 1);
            this.Txt_Item.CustomButton.Name = "";
            this.Txt_Item.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Txt_Item.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Txt_Item.CustomButton.TabIndex = 1;
            this.Txt_Item.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Txt_Item.CustomButton.UseSelectable = true;
            this.Txt_Item.CustomButton.Visible = false;
            this.Txt_Item.Lines = new string[0];
            this.Txt_Item.Location = new System.Drawing.Point(153, 225);
            this.Txt_Item.MaxLength = 32767;
            this.Txt_Item.Name = "Txt_Item";
            this.Txt_Item.PasswordChar = '\0';
            this.Txt_Item.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Txt_Item.SelectedText = "";
            this.Txt_Item.SelectionLength = 0;
            this.Txt_Item.SelectionStart = 0;
            this.Txt_Item.ShortcutsEnabled = true;
            this.Txt_Item.Size = new System.Drawing.Size(523, 23);
            this.Txt_Item.TabIndex = 9;
            this.Txt_Item.UseSelectable = true;
            this.Txt_Item.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Txt_Item.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Lbl_Qty
            // 
            this.Lbl_Qty.AutoSize = true;
            this.Lbl_Qty.Location = new System.Drawing.Point(57, 273);
            this.Lbl_Qty.Name = "Lbl_Qty";
            this.Lbl_Qty.Size = new System.Drawing.Size(30, 19);
            this.Lbl_Qty.TabIndex = 10;
            this.Lbl_Qty.Text = "Qty";
            // 
            // Txt_Qty
            // 
            // 
            // 
            // 
            this.Txt_Qty.CustomButton.Image = null;
            this.Txt_Qty.CustomButton.Location = new System.Drawing.Point(58, 1);
            this.Txt_Qty.CustomButton.Name = "";
            this.Txt_Qty.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Txt_Qty.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Txt_Qty.CustomButton.TabIndex = 1;
            this.Txt_Qty.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Txt_Qty.CustomButton.UseSelectable = true;
            this.Txt_Qty.CustomButton.Visible = false;
            this.Txt_Qty.Lines = new string[] {
        " "};
            this.Txt_Qty.Location = new System.Drawing.Point(153, 269);
            this.Txt_Qty.MaxLength = 32767;
            this.Txt_Qty.Name = "Txt_Qty";
            this.Txt_Qty.PasswordChar = '\0';
            this.Txt_Qty.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Txt_Qty.SelectedText = "";
            this.Txt_Qty.SelectionLength = 0;
            this.Txt_Qty.SelectionStart = 0;
            this.Txt_Qty.ShortcutsEnabled = true;
            this.Txt_Qty.Size = new System.Drawing.Size(80, 23);
            this.Txt_Qty.TabIndex = 11;
            this.Txt_Qty.Text = " ";
            this.Txt_Qty.UseSelectable = true;
            this.Txt_Qty.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Txt_Qty.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Btn_Add
            // 
            this.Btn_Add.Location = new System.Drawing.Point(383, 269);
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Size = new System.Drawing.Size(75, 23);
            this.Btn_Add.TabIndex = 12;
            this.Btn_Add.Text = "Add";
            this.Btn_Add.UseSelectable = true;
            // 
            // Btn_Remove
            // 
            this.Btn_Remove.Location = new System.Drawing.Point(479, 269);
            this.Btn_Remove.Name = "Btn_Remove";
            this.Btn_Remove.Size = new System.Drawing.Size(75, 23);
            this.Btn_Remove.TabIndex = 13;
            this.Btn_Remove.Text = "Remove";
            this.Btn_Remove.UseSelectable = true;
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToAddRows = false;
            this.metroGrid1.AllowUserToDeleteRows = false;
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle5;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(57, 314);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.ReadOnly = true;
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(619, 150);
            this.metroGrid1.TabIndex = 14;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Lbl_Total
            // 
            this.Lbl_Total.AutoSize = true;
            this.Lbl_Total.Location = new System.Drawing.Point(57, 517);
            this.Lbl_Total.Name = "Lbl_Total";
            this.Lbl_Total.Size = new System.Drawing.Size(36, 19);
            this.Lbl_Total.TabIndex = 15;
            this.Lbl_Total.Text = "Total";
            // 
            // Txt_Total
            // 
            // 
            // 
            // 
            this.Txt_Total.CustomButton.Image = null;
            this.Txt_Total.CustomButton.Location = new System.Drawing.Point(95, 1);
            this.Txt_Total.CustomButton.Name = "";
            this.Txt_Total.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Txt_Total.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Txt_Total.CustomButton.TabIndex = 1;
            this.Txt_Total.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Txt_Total.CustomButton.UseSelectable = true;
            this.Txt_Total.CustomButton.Visible = false;
            this.Txt_Total.Lines = new string[0];
            this.Txt_Total.Location = new System.Drawing.Point(99, 513);
            this.Txt_Total.MaxLength = 32767;
            this.Txt_Total.Name = "Txt_Total";
            this.Txt_Total.PasswordChar = '\0';
            this.Txt_Total.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Txt_Total.SelectedText = "";
            this.Txt_Total.SelectionLength = 0;
            this.Txt_Total.SelectionStart = 0;
            this.Txt_Total.ShortcutsEnabled = true;
            this.Txt_Total.Size = new System.Drawing.Size(117, 23);
            this.Txt_Total.TabIndex = 16;
            this.Txt_Total.UseSelectable = true;
            this.Txt_Total.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Txt_Total.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Btn_Save
            // 
            this.Btn_Save.Location = new System.Drawing.Point(383, 513);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(75, 23);
            this.Btn_Save.TabIndex = 17;
            this.Btn_Save.Text = "Save";
            this.Btn_Save.UseSelectable = true;
            // 
            // Btn_Print
            // 
            this.Btn_Print.Location = new System.Drawing.Point(464, 513);
            this.Btn_Print.Name = "Btn_Print";
            this.Btn_Print.Size = new System.Drawing.Size(75, 23);
            this.Btn_Print.TabIndex = 18;
            this.Btn_Print.Text = "Print";
            this.Btn_Print.UseSelectable = true;
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.Location = new System.Drawing.Point(545, 513);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(75, 23);
            this.Btn_Exit.TabIndex = 19;
            this.Btn_Exit.Text = "Exit";
            this.Btn_Exit.UseSelectable = true;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Location = new System.Drawing.Point(374, 82);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(302, 100);
            this.metroTabControl1.TabIndex = 20;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.metroComboBox1);
            this.metroTabPage1.Controls.Add(this.Rbn_Service);
            this.metroTabPage1.Controls.Add(this.Rbn_Sales);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(294, 58);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Reference Order";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // Rbn_Sales
            // 
            this.Rbn_Sales.AutoSize = true;
            this.Rbn_Sales.Location = new System.Drawing.Point(12, 26);
            this.Rbn_Sales.Name = "Rbn_Sales";
            this.Rbn_Sales.Size = new System.Drawing.Size(49, 15);
            this.Rbn_Sales.TabIndex = 2;
            this.Rbn_Sales.Text = "Sales";
            this.Rbn_Sales.UseSelectable = true;
            // 
            // Rbn_Service
            // 
            this.Rbn_Service.AutoSize = true;
            this.Rbn_Service.Location = new System.Drawing.Point(67, 26);
            this.Rbn_Service.Name = "Rbn_Service";
            this.Rbn_Service.Size = new System.Drawing.Size(60, 15);
            this.Rbn_Service.TabIndex = 3;
            this.Rbn_Service.Text = "Service";
            this.Rbn_Service.UseSelectable = true;
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Location = new System.Drawing.Point(148, 12);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(121, 29);
            this.metroComboBox1.TabIndex = 4;
            this.metroComboBox1.UseSelectable = true;
            // 
            // Purchase_Order_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 567);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.Btn_Exit);
            this.Controls.Add(this.Btn_Print);
            this.Controls.Add(this.Btn_Save);
            this.Controls.Add(this.Txt_Total);
            this.Controls.Add(this.Lbl_Total);
            this.Controls.Add(this.metroGrid1);
            this.Controls.Add(this.Btn_Remove);
            this.Controls.Add(this.Btn_Add);
            this.Controls.Add(this.Txt_Qty);
            this.Controls.Add(this.Lbl_Qty);
            this.Controls.Add(this.Txt_Item);
            this.Controls.Add(this.Lbl_Item);
            this.Controls.Add(this.Rbn_Delivered);
            this.Controls.Add(this.Rbn_Paid);
            this.Controls.Add(this.Rbn_Invoiced);
            this.Controls.Add(this.Rbn_Pending);
            this.Controls.Add(this.Dtp_DueDate);
            this.Controls.Add(this.Lbl_DueDate);
            this.Controls.Add(this.Txt_PurchaseID);
            this.Controls.Add(this.Lbl_PurchaseID);
            this.Name = "Purchase_Order_Details";
            this.Text = "Purchase Order Details";
            this.Load += new System.EventHandler(this.Purchase_Order_Details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel Lbl_PurchaseID;
        private MetroFramework.Controls.MetroTextBox Txt_PurchaseID;
        private MetroFramework.Controls.MetroLabel Lbl_DueDate;
        private MetroFramework.Controls.MetroDateTime Dtp_DueDate;
        private MetroFramework.Controls.MetroRadioButton Rbn_Pending;
        private MetroFramework.Controls.MetroRadioButton Rbn_Invoiced;
        private MetroFramework.Controls.MetroRadioButton Rbn_Paid;
        private MetroFramework.Controls.MetroRadioButton Rbn_Delivered;
        private MetroFramework.Controls.MetroLabel Lbl_Item;
        private MetroFramework.Controls.MetroTextBox Txt_Item;
        private MetroFramework.Controls.MetroLabel Lbl_Qty;
        private MetroFramework.Controls.MetroTextBox Txt_Qty;
        private MetroFramework.Controls.MetroButton Btn_Add;
        private MetroFramework.Controls.MetroButton Btn_Remove;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private MetroFramework.Controls.MetroLabel Lbl_Total;
        private MetroFramework.Controls.MetroTextBox Txt_Total;
        private MetroFramework.Controls.MetroButton Btn_Save;
        private MetroFramework.Controls.MetroButton Btn_Print;
        private MetroFramework.Controls.MetroButton Btn_Exit;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Controls.MetroRadioButton Rbn_Service;
        private MetroFramework.Controls.MetroRadioButton Rbn_Sales;
    }
}