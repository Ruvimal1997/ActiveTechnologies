namespace Active_Technologies
{
    partial class Purchase_Order_List
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Lbl_From = new MetroFramework.Controls.MetroLabel();
            this.Dtp_From = new MetroFramework.Controls.MetroDateTime();
            this.Rbn_Delivered = new MetroFramework.Controls.MetroRadioButton();
            this.Rbn_Paid = new MetroFramework.Controls.MetroRadioButton();
            this.Rbn_Invoiced = new MetroFramework.Controls.MetroRadioButton();
            this.Rbn_Pending = new MetroFramework.Controls.MetroRadioButton();
            this.Btn_ViewDetails = new MetroFramework.Controls.MetroButton();
            this.Btn_ViewReferenceOrder = new MetroFramework.Controls.MetroButton();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_From
            // 
            this.Lbl_From.AutoSize = true;
            this.Lbl_From.Location = new System.Drawing.Point(39, 107);
            this.Lbl_From.Name = "Lbl_From";
            this.Lbl_From.Size = new System.Drawing.Size(41, 19);
            this.Lbl_From.TabIndex = 0;
            this.Lbl_From.Text = "From";
            // 
            // Dtp_From
            // 
            this.Dtp_From.Location = new System.Drawing.Point(86, 97);
            this.Dtp_From.MinimumSize = new System.Drawing.Size(0, 29);
            this.Dtp_From.Name = "Dtp_From";
            this.Dtp_From.Size = new System.Drawing.Size(200, 29);
            this.Dtp_From.TabIndex = 1;
            // 
            // Rbn_Delivered
            // 
            this.Rbn_Delivered.AutoSize = true;
            this.Rbn_Delivered.Location = new System.Drawing.Point(560, 111);
            this.Rbn_Delivered.Name = "Rbn_Delivered";
            this.Rbn_Delivered.Size = new System.Drawing.Size(72, 15);
            this.Rbn_Delivered.TabIndex = 11;
            this.Rbn_Delivered.Text = "Delivered";
            this.Rbn_Delivered.UseSelectable = true;
            // 
            // Rbn_Paid
            // 
            this.Rbn_Paid.AutoSize = true;
            this.Rbn_Paid.Location = new System.Drawing.Point(508, 111);
            this.Rbn_Paid.Name = "Rbn_Paid";
            this.Rbn_Paid.Size = new System.Drawing.Size(46, 15);
            this.Rbn_Paid.TabIndex = 10;
            this.Rbn_Paid.Text = "Paid";
            this.Rbn_Paid.UseSelectable = true;
            // 
            // Rbn_Invoiced
            // 
            this.Rbn_Invoiced.AutoSize = true;
            this.Rbn_Invoiced.Location = new System.Drawing.Point(434, 111);
            this.Rbn_Invoiced.Name = "Rbn_Invoiced";
            this.Rbn_Invoiced.Size = new System.Drawing.Size(68, 15);
            this.Rbn_Invoiced.TabIndex = 9;
            this.Rbn_Invoiced.Text = "Invoiced";
            this.Rbn_Invoiced.UseSelectable = true;
            // 
            // Rbn_Pending
            // 
            this.Rbn_Pending.AutoSize = true;
            this.Rbn_Pending.Location = new System.Drawing.Point(361, 111);
            this.Rbn_Pending.Name = "Rbn_Pending";
            this.Rbn_Pending.Size = new System.Drawing.Size(67, 15);
            this.Rbn_Pending.TabIndex = 8;
            this.Rbn_Pending.Text = "Pending";
            this.Rbn_Pending.UseSelectable = true;
            // 
            // Btn_ViewDetails
            // 
            this.Btn_ViewDetails.Location = new System.Drawing.Point(72, 181);
            this.Btn_ViewDetails.Name = "Btn_ViewDetails";
            this.Btn_ViewDetails.Size = new System.Drawing.Size(75, 23);
            this.Btn_ViewDetails.TabIndex = 12;
            this.Btn_ViewDetails.Text = "View Details";
            this.Btn_ViewDetails.UseSelectable = true;
            // 
            // Btn_ViewReferenceOrder
            // 
            this.Btn_ViewReferenceOrder.Location = new System.Drawing.Point(161, 181);
            this.Btn_ViewReferenceOrder.Name = "Btn_ViewReferenceOrder";
            this.Btn_ViewReferenceOrder.Size = new System.Drawing.Size(125, 23);
            this.Btn_ViewReferenceOrder.TabIndex = 13;
            this.Btn_ViewReferenceOrder.Text = "View Reference Order";
            this.Btn_ViewReferenceOrder.UseSelectable = true;
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(39, 240);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.ReadOnly = true;
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(593, 239);
            this.metroGrid1.TabIndex = 14;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Purchase_Order_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 561);
            this.Controls.Add(this.metroGrid1);
            this.Controls.Add(this.Btn_ViewReferenceOrder);
            this.Controls.Add(this.Btn_ViewDetails);
            this.Controls.Add(this.Rbn_Delivered);
            this.Controls.Add(this.Rbn_Paid);
            this.Controls.Add(this.Rbn_Invoiced);
            this.Controls.Add(this.Rbn_Pending);
            this.Controls.Add(this.Dtp_From);
            this.Controls.Add(this.Lbl_From);
            this.Name = "Purchase_Order_List";
            this.Text = "Purchase Order List";
            this.Load += new System.EventHandler(this.Purchase_Order_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel Lbl_From;
        private MetroFramework.Controls.MetroDateTime Dtp_From;
        private MetroFramework.Controls.MetroRadioButton Rbn_Delivered;
        private MetroFramework.Controls.MetroRadioButton Rbn_Paid;
        private MetroFramework.Controls.MetroRadioButton Rbn_Invoiced;
        private MetroFramework.Controls.MetroRadioButton Rbn_Pending;
        private MetroFramework.Controls.MetroButton Btn_ViewDetails;
        private MetroFramework.Controls.MetroButton Btn_ViewReferenceOrder;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}