﻿namespace Active_Technologies
{
    partial class Sales_Order_Details
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
            this.Lbl_SalesID = new MetroFramework.Controls.MetroLabel();
            this.Txt_SalesID = new MetroFramework.Controls.MetroTextBox();
            this.Lbl_DueDate = new MetroFramework.Controls.MetroLabel();
            this.Dtp_DueDate = new MetroFramework.Controls.MetroDateTime();
            this.Lbl_Clients = new MetroFramework.Controls.MetroLabel();
            this.Txt_Clients = new MetroFramework.Controls.MetroTextBox();
            this.Lbl_Package = new MetroFramework.Controls.MetroLabel();
            this.Cmb_Package = new MetroFramework.Controls.MetroComboBox();
            this.Rbn_Paid = new MetroFramework.Controls.MetroRadioButton();
            this.Rbn_Invoiced = new MetroFramework.Controls.MetroRadioButton();
            this.Rbn_Pending = new MetroFramework.Controls.MetroRadioButton();
            this.Lbl_Item = new MetroFramework.Controls.MetroLabel();
            this.Cmb_Item = new MetroFramework.Controls.MetroComboBox();
            this.Lbl_Qty = new MetroFramework.Controls.MetroLabel();
            this.Txt_Qty = new MetroFramework.Controls.MetroTextBox();
            this.Btn_Add = new MetroFramework.Controls.MetroButton();
            this.Btn_Remove = new MetroFramework.Controls.MetroButton();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lbl_Total = new MetroFramework.Controls.MetroLabel();
            this.Txt_Total = new MetroFramework.Controls.MetroTextBox();
            this.Btn_Back = new MetroFramework.Controls.MetroButton();
            this.Btn_Save = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_SalesID
            // 
            this.Lbl_SalesID.AutoSize = true;
            this.Lbl_SalesID.Location = new System.Drawing.Point(43, 119);
            this.Lbl_SalesID.Name = "Lbl_SalesID";
            this.Lbl_SalesID.Size = new System.Drawing.Size(54, 19);
            this.Lbl_SalesID.TabIndex = 0;
            this.Lbl_SalesID.Text = "Sales ID";
            // 
            // Txt_SalesID
            // 
            // 
            // 
            // 
            this.Txt_SalesID.CustomButton.Image = null;
            this.Txt_SalesID.CustomButton.Location = new System.Drawing.Point(60, 1);
            this.Txt_SalesID.CustomButton.Name = "";
            this.Txt_SalesID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Txt_SalesID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Txt_SalesID.CustomButton.TabIndex = 1;
            this.Txt_SalesID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Txt_SalesID.CustomButton.UseSelectable = true;
            this.Txt_SalesID.CustomButton.Visible = false;
            this.Txt_SalesID.Enabled = false;
            this.Txt_SalesID.Lines = new string[0];
            this.Txt_SalesID.Location = new System.Drawing.Point(112, 115);
            this.Txt_SalesID.MaxLength = 32767;
            this.Txt_SalesID.Name = "Txt_SalesID";
            this.Txt_SalesID.PasswordChar = '\0';
            this.Txt_SalesID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Txt_SalesID.SelectedText = "";
            this.Txt_SalesID.SelectionLength = 0;
            this.Txt_SalesID.SelectionStart = 0;
            this.Txt_SalesID.ShortcutsEnabled = true;
            this.Txt_SalesID.Size = new System.Drawing.Size(82, 23);
            this.Txt_SalesID.TabIndex = 1;
            this.Txt_SalesID.UseSelectable = true;
            this.Txt_SalesID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Txt_SalesID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Lbl_DueDate
            // 
            this.Lbl_DueDate.AutoSize = true;
            this.Lbl_DueDate.Location = new System.Drawing.Point(43, 159);
            this.Lbl_DueDate.Name = "Lbl_DueDate";
            this.Lbl_DueDate.Size = new System.Drawing.Size(63, 19);
            this.Lbl_DueDate.TabIndex = 2;
            this.Lbl_DueDate.Text = "Due Date";
            // 
            // Dtp_DueDate
            // 
            this.Dtp_DueDate.Location = new System.Drawing.Point(112, 149);
            this.Dtp_DueDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.Dtp_DueDate.Name = "Dtp_DueDate";
            this.Dtp_DueDate.Size = new System.Drawing.Size(178, 29);
            this.Dtp_DueDate.TabIndex = 3;
            // 
            // Lbl_Clients
            // 
            this.Lbl_Clients.AutoSize = true;
            this.Lbl_Clients.Location = new System.Drawing.Point(43, 197);
            this.Lbl_Clients.Name = "Lbl_Clients";
            this.Lbl_Clients.Size = new System.Drawing.Size(47, 19);
            this.Lbl_Clients.TabIndex = 4;
            this.Lbl_Clients.Text = "Clients";
            // 
            // Txt_Clients
            // 
            // 
            // 
            // 
            this.Txt_Clients.CustomButton.Image = null;
            this.Txt_Clients.CustomButton.Location = new System.Drawing.Point(489, 1);
            this.Txt_Clients.CustomButton.Name = "";
            this.Txt_Clients.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Txt_Clients.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Txt_Clients.CustomButton.TabIndex = 1;
            this.Txt_Clients.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Txt_Clients.CustomButton.UseSelectable = true;
            this.Txt_Clients.CustomButton.Visible = false;
            this.Txt_Clients.Lines = new string[0];
            this.Txt_Clients.Location = new System.Drawing.Point(112, 193);
            this.Txt_Clients.MaxLength = 32767;
            this.Txt_Clients.Name = "Txt_Clients";
            this.Txt_Clients.PasswordChar = '\0';
            this.Txt_Clients.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Txt_Clients.SelectedText = "";
            this.Txt_Clients.SelectionLength = 0;
            this.Txt_Clients.SelectionStart = 0;
            this.Txt_Clients.ShortcutsEnabled = true;
            this.Txt_Clients.Size = new System.Drawing.Size(511, 23);
            this.Txt_Clients.TabIndex = 5;
            this.Txt_Clients.UseSelectable = true;
            this.Txt_Clients.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Txt_Clients.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Lbl_Package
            // 
            this.Lbl_Package.AutoSize = true;
            this.Lbl_Package.Location = new System.Drawing.Point(43, 234);
            this.Lbl_Package.Name = "Lbl_Package";
            this.Lbl_Package.Size = new System.Drawing.Size(57, 19);
            this.Lbl_Package.TabIndex = 6;
            this.Lbl_Package.Text = "Package";
            // 
            // Cmb_Package
            // 
            this.Cmb_Package.FormattingEnabled = true;
            this.Cmb_Package.ItemHeight = 23;
            this.Cmb_Package.Location = new System.Drawing.Point(112, 224);
            this.Cmb_Package.Name = "Cmb_Package";
            this.Cmb_Package.Size = new System.Drawing.Size(192, 29);
            this.Cmb_Package.TabIndex = 7;
            this.Cmb_Package.UseSelectable = true;
            // 
            // Rbn_Paid
            // 
            this.Rbn_Paid.AutoSize = true;
            this.Rbn_Paid.Location = new System.Drawing.Point(577, 238);
            this.Rbn_Paid.Name = "Rbn_Paid";
            this.Rbn_Paid.Size = new System.Drawing.Size(46, 15);
            this.Rbn_Paid.TabIndex = 22;
            this.Rbn_Paid.Text = "Paid";
            this.Rbn_Paid.UseSelectable = true;
            // 
            // Rbn_Invoiced
            // 
            this.Rbn_Invoiced.AutoSize = true;
            this.Rbn_Invoiced.Location = new System.Drawing.Point(503, 238);
            this.Rbn_Invoiced.Name = "Rbn_Invoiced";
            this.Rbn_Invoiced.Size = new System.Drawing.Size(68, 15);
            this.Rbn_Invoiced.TabIndex = 21;
            this.Rbn_Invoiced.Text = "Invoiced";
            this.Rbn_Invoiced.UseSelectable = true;
            // 
            // Rbn_Pending
            // 
            this.Rbn_Pending.AutoSize = true;
            this.Rbn_Pending.Location = new System.Drawing.Point(430, 238);
            this.Rbn_Pending.Name = "Rbn_Pending";
            this.Rbn_Pending.Size = new System.Drawing.Size(67, 15);
            this.Rbn_Pending.TabIndex = 20;
            this.Rbn_Pending.Text = "Pending";
            this.Rbn_Pending.UseSelectable = true;
            // 
            // Lbl_Item
            // 
            this.Lbl_Item.AutoSize = true;
            this.Lbl_Item.Location = new System.Drawing.Point(43, 279);
            this.Lbl_Item.Name = "Lbl_Item";
            this.Lbl_Item.Size = new System.Drawing.Size(35, 19);
            this.Lbl_Item.TabIndex = 23;
            this.Lbl_Item.Text = "Item";
            // 
            // Cmb_Item
            // 
            this.Cmb_Item.FormattingEnabled = true;
            this.Cmb_Item.ItemHeight = 23;
            this.Cmb_Item.Location = new System.Drawing.Point(112, 269);
            this.Cmb_Item.Name = "Cmb_Item";
            this.Cmb_Item.Size = new System.Drawing.Size(511, 29);
            this.Cmb_Item.TabIndex = 24;
            this.Cmb_Item.UseSelectable = true;
            // 
            // Lbl_Qty
            // 
            this.Lbl_Qty.AutoSize = true;
            this.Lbl_Qty.Location = new System.Drawing.Point(43, 319);
            this.Lbl_Qty.Name = "Lbl_Qty";
            this.Lbl_Qty.Size = new System.Drawing.Size(30, 19);
            this.Lbl_Qty.TabIndex = 25;
            this.Lbl_Qty.Text = "Qty";
            // 
            // Txt_Qty
            // 
            // 
            // 
            // 
            this.Txt_Qty.CustomButton.Image = null;
            this.Txt_Qty.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.Txt_Qty.CustomButton.Name = "";
            this.Txt_Qty.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Txt_Qty.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Txt_Qty.CustomButton.TabIndex = 1;
            this.Txt_Qty.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Txt_Qty.CustomButton.UseSelectable = true;
            this.Txt_Qty.CustomButton.Visible = false;
            this.Txt_Qty.Lines = new string[0];
            this.Txt_Qty.Location = new System.Drawing.Point(112, 315);
            this.Txt_Qty.MaxLength = 32767;
            this.Txt_Qty.Name = "Txt_Qty";
            this.Txt_Qty.PasswordChar = '\0';
            this.Txt_Qty.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Txt_Qty.SelectedText = "";
            this.Txt_Qty.SelectionLength = 0;
            this.Txt_Qty.SelectionStart = 0;
            this.Txt_Qty.ShortcutsEnabled = true;
            this.Txt_Qty.Size = new System.Drawing.Size(75, 23);
            this.Txt_Qty.TabIndex = 26;
            this.Txt_Qty.UseSelectable = true;
            this.Txt_Qty.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Txt_Qty.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Btn_Add
            // 
            this.Btn_Add.Location = new System.Drawing.Point(419, 315);
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Size = new System.Drawing.Size(75, 23);
            this.Btn_Add.TabIndex = 27;
            this.Btn_Add.Text = "Add";
            this.Btn_Add.UseSelectable = true;
            // 
            // Btn_Remove
            // 
            this.Btn_Remove.Location = new System.Drawing.Point(513, 315);
            this.Btn_Remove.Name = "Btn_Remove";
            this.Btn_Remove.Size = new System.Drawing.Size(75, 23);
            this.Btn_Remove.TabIndex = 28;
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
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
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
            this.metroGrid1.Location = new System.Drawing.Point(43, 355);
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
            this.metroGrid1.Size = new System.Drawing.Size(580, 150);
            this.metroGrid1.TabIndex = 29;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Column5";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Lbl_Total
            // 
            this.Lbl_Total.AutoSize = true;
            this.Lbl_Total.Location = new System.Drawing.Point(45, 513);
            this.Lbl_Total.Name = "Lbl_Total";
            this.Lbl_Total.Size = new System.Drawing.Size(36, 19);
            this.Lbl_Total.TabIndex = 30;
            this.Lbl_Total.Text = "Total";
            // 
            // Txt_Total
            // 
            // 
            // 
            // 
            this.Txt_Total.CustomButton.Image = null;
            this.Txt_Total.CustomButton.Location = new System.Drawing.Point(78, 1);
            this.Txt_Total.CustomButton.Name = "";
            this.Txt_Total.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Txt_Total.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Txt_Total.CustomButton.TabIndex = 1;
            this.Txt_Total.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Txt_Total.CustomButton.UseSelectable = true;
            this.Txt_Total.CustomButton.Visible = false;
            this.Txt_Total.Lines = new string[0];
            this.Txt_Total.Location = new System.Drawing.Point(87, 509);
            this.Txt_Total.MaxLength = 32767;
            this.Txt_Total.Name = "Txt_Total";
            this.Txt_Total.PasswordChar = '\0';
            this.Txt_Total.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Txt_Total.SelectedText = "";
            this.Txt_Total.SelectionLength = 0;
            this.Txt_Total.SelectionStart = 0;
            this.Txt_Total.ShortcutsEnabled = true;
            this.Txt_Total.Size = new System.Drawing.Size(100, 23);
            this.Txt_Total.TabIndex = 31;
            this.Txt_Total.UseSelectable = true;
            this.Txt_Total.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Txt_Total.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Btn_Back
            // 
            this.Btn_Back.Location = new System.Drawing.Point(513, 509);
            this.Btn_Back.Name = "Btn_Back";
            this.Btn_Back.Size = new System.Drawing.Size(75, 23);
            this.Btn_Back.TabIndex = 33;
            this.Btn_Back.Text = "Back";
            this.Btn_Back.UseSelectable = true;
            // 
            // Btn_Save
            // 
            this.Btn_Save.Location = new System.Drawing.Point(419, 509);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(75, 23);
            this.Btn_Save.TabIndex = 32;
            this.Btn_Save.Text = "Save";
            this.Btn_Save.UseSelectable = true;
            // 
            // Sales_Order_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 576);
            this.Controls.Add(this.Btn_Back);
            this.Controls.Add(this.Btn_Save);
            this.Controls.Add(this.Txt_Total);
            this.Controls.Add(this.Lbl_Total);
            this.Controls.Add(this.metroGrid1);
            this.Controls.Add(this.Btn_Remove);
            this.Controls.Add(this.Btn_Add);
            this.Controls.Add(this.Txt_Qty);
            this.Controls.Add(this.Lbl_Qty);
            this.Controls.Add(this.Cmb_Item);
            this.Controls.Add(this.Lbl_Item);
            this.Controls.Add(this.Rbn_Paid);
            this.Controls.Add(this.Rbn_Invoiced);
            this.Controls.Add(this.Rbn_Pending);
            this.Controls.Add(this.Cmb_Package);
            this.Controls.Add(this.Lbl_Package);
            this.Controls.Add(this.Txt_Clients);
            this.Controls.Add(this.Lbl_Clients);
            this.Controls.Add(this.Dtp_DueDate);
            this.Controls.Add(this.Lbl_DueDate);
            this.Controls.Add(this.Txt_SalesID);
            this.Controls.Add(this.Lbl_SalesID);
            this.Name = "Sales_Order_Details";
            this.Text = "Sales Order Details";
            this.Load += new System.EventHandler(this.Sales_Order_Details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel Lbl_SalesID;
        private MetroFramework.Controls.MetroTextBox Txt_SalesID;
        private MetroFramework.Controls.MetroLabel Lbl_DueDate;
        private MetroFramework.Controls.MetroDateTime Dtp_DueDate;
        private MetroFramework.Controls.MetroLabel Lbl_Clients;
        private MetroFramework.Controls.MetroTextBox Txt_Clients;
        private MetroFramework.Controls.MetroLabel Lbl_Package;
        private MetroFramework.Controls.MetroComboBox Cmb_Package;
        private MetroFramework.Controls.MetroRadioButton Rbn_Paid;
        private MetroFramework.Controls.MetroRadioButton Rbn_Invoiced;
        private MetroFramework.Controls.MetroRadioButton Rbn_Pending;
        private MetroFramework.Controls.MetroLabel Lbl_Item;
        private MetroFramework.Controls.MetroComboBox Cmb_Item;
        private MetroFramework.Controls.MetroLabel Lbl_Qty;
        private MetroFramework.Controls.MetroTextBox Txt_Qty;
        private MetroFramework.Controls.MetroButton Btn_Add;
        private MetroFramework.Controls.MetroButton Btn_Remove;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private MetroFramework.Controls.MetroLabel Lbl_Total;
        private MetroFramework.Controls.MetroTextBox Txt_Total;
        private MetroFramework.Controls.MetroButton Btn_Back;
        private MetroFramework.Controls.MetroButton Btn_Save;
    }
}