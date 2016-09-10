namespace Active_Technologies
{
    partial class New_Package
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
            this.Btn_Items = new MetroFramework.Controls.MetroButton();
            this.Txt_Desc = new MetroFramework.Controls.MetroTextBox();
            this.Lbl_Desc = new MetroFramework.Controls.MetroLabel();
            this.Txt_Discount = new MetroFramework.Controls.MetroTextBox();
            this.Lbl_Discount = new MetroFramework.Controls.MetroLabel();
            this.Txt_Price = new MetroFramework.Controls.MetroTextBox();
            this.Lbl_Price = new MetroFramework.Controls.MetroLabel();
            this.Txt_Name = new MetroFramework.Controls.MetroTextBox();
            this.Lbl_Name = new MetroFramework.Controls.MetroLabel();
            this.Txt_PackageID = new MetroFramework.Controls.MetroTextBox();
            this.Lbl_PackageID = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // Btn_Items
            // 
            this.Btn_Items.Location = new System.Drawing.Point(150, 441);
            this.Btn_Items.Name = "Btn_Items";
            this.Btn_Items.Size = new System.Drawing.Size(75, 23);
            this.Btn_Items.TabIndex = 21;
            this.Btn_Items.Text = "Items";
            this.Btn_Items.UseSelectable = true;
            this.Btn_Items.Click += new System.EventHandler(this.Btn_Items_Click);
            // 
            // Txt_Desc
            // 
            // 
            // 
            // 
            this.Txt_Desc.CustomButton.Image = null;
            this.Txt_Desc.CustomButton.Location = new System.Drawing.Point(85, 1);
            this.Txt_Desc.CustomButton.Name = "";
            this.Txt_Desc.CustomButton.Size = new System.Drawing.Size(89, 89);
            this.Txt_Desc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Txt_Desc.CustomButton.TabIndex = 1;
            this.Txt_Desc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Txt_Desc.CustomButton.UseSelectable = true;
            this.Txt_Desc.CustomButton.Visible = false;
            this.Txt_Desc.Lines = new string[0];
            this.Txt_Desc.Location = new System.Drawing.Point(124, 274);
            this.Txt_Desc.MaxLength = 32767;
            this.Txt_Desc.Multiline = true;
            this.Txt_Desc.Name = "Txt_Desc";
            this.Txt_Desc.PasswordChar = '\0';
            this.Txt_Desc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Txt_Desc.SelectedText = "";
            this.Txt_Desc.SelectionLength = 0;
            this.Txt_Desc.SelectionStart = 0;
            this.Txt_Desc.ShortcutsEnabled = true;
            this.Txt_Desc.Size = new System.Drawing.Size(175, 91);
            this.Txt_Desc.TabIndex = 20;
            this.Txt_Desc.UseSelectable = true;
            this.Txt_Desc.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Txt_Desc.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Lbl_Desc
            // 
            this.Lbl_Desc.AutoSize = true;
            this.Lbl_Desc.Location = new System.Drawing.Point(45, 278);
            this.Lbl_Desc.Name = "Lbl_Desc";
            this.Lbl_Desc.Size = new System.Drawing.Size(74, 19);
            this.Lbl_Desc.TabIndex = 19;
            this.Lbl_Desc.Text = "Description";
            // 
            // Txt_Discount
            // 
            // 
            // 
            // 
            this.Txt_Discount.CustomButton.Image = null;
            this.Txt_Discount.CustomButton.Location = new System.Drawing.Point(153, 1);
            this.Txt_Discount.CustomButton.Name = "";
            this.Txt_Discount.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Txt_Discount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Txt_Discount.CustomButton.TabIndex = 1;
            this.Txt_Discount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Txt_Discount.CustomButton.UseSelectable = true;
            this.Txt_Discount.CustomButton.Visible = false;
            this.Txt_Discount.Lines = new string[0];
            this.Txt_Discount.Location = new System.Drawing.Point(124, 234);
            this.Txt_Discount.MaxLength = 32767;
            this.Txt_Discount.Name = "Txt_Discount";
            this.Txt_Discount.PasswordChar = '\0';
            this.Txt_Discount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Txt_Discount.SelectedText = "";
            this.Txt_Discount.SelectionLength = 0;
            this.Txt_Discount.SelectionStart = 0;
            this.Txt_Discount.ShortcutsEnabled = true;
            this.Txt_Discount.Size = new System.Drawing.Size(175, 23);
            this.Txt_Discount.TabIndex = 18;
            this.Txt_Discount.UseSelectable = true;
            this.Txt_Discount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Txt_Discount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Lbl_Discount
            // 
            this.Lbl_Discount.AutoSize = true;
            this.Lbl_Discount.Location = new System.Drawing.Point(45, 238);
            this.Lbl_Discount.Name = "Lbl_Discount";
            this.Lbl_Discount.Size = new System.Drawing.Size(58, 19);
            this.Lbl_Discount.TabIndex = 17;
            this.Lbl_Discount.Text = "Discount";
            // 
            // Txt_Price
            // 
            // 
            // 
            // 
            this.Txt_Price.CustomButton.Image = null;
            this.Txt_Price.CustomButton.Location = new System.Drawing.Point(153, 1);
            this.Txt_Price.CustomButton.Name = "";
            this.Txt_Price.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Txt_Price.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Txt_Price.CustomButton.TabIndex = 1;
            this.Txt_Price.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Txt_Price.CustomButton.UseSelectable = true;
            this.Txt_Price.CustomButton.Visible = false;
            this.Txt_Price.Lines = new string[0];
            this.Txt_Price.Location = new System.Drawing.Point(124, 195);
            this.Txt_Price.MaxLength = 32767;
            this.Txt_Price.Name = "Txt_Price";
            this.Txt_Price.PasswordChar = '\0';
            this.Txt_Price.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Txt_Price.SelectedText = "";
            this.Txt_Price.SelectionLength = 0;
            this.Txt_Price.SelectionStart = 0;
            this.Txt_Price.ShortcutsEnabled = true;
            this.Txt_Price.Size = new System.Drawing.Size(175, 23);
            this.Txt_Price.TabIndex = 16;
            this.Txt_Price.UseSelectable = true;
            this.Txt_Price.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Txt_Price.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Lbl_Price
            // 
            this.Lbl_Price.AutoSize = true;
            this.Lbl_Price.Location = new System.Drawing.Point(45, 199);
            this.Lbl_Price.Name = "Lbl_Price";
            this.Lbl_Price.Size = new System.Drawing.Size(38, 19);
            this.Lbl_Price.TabIndex = 15;
            this.Lbl_Price.Text = "Price";
            // 
            // Txt_Name
            // 
            // 
            // 
            // 
            this.Txt_Name.CustomButton.Image = null;
            this.Txt_Name.CustomButton.Location = new System.Drawing.Point(153, 1);
            this.Txt_Name.CustomButton.Name = "";
            this.Txt_Name.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Txt_Name.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Txt_Name.CustomButton.TabIndex = 1;
            this.Txt_Name.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Txt_Name.CustomButton.UseSelectable = true;
            this.Txt_Name.CustomButton.Visible = false;
            this.Txt_Name.Lines = new string[0];
            this.Txt_Name.Location = new System.Drawing.Point(124, 156);
            this.Txt_Name.MaxLength = 32767;
            this.Txt_Name.Name = "Txt_Name";
            this.Txt_Name.PasswordChar = '\0';
            this.Txt_Name.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Txt_Name.SelectedText = "";
            this.Txt_Name.SelectionLength = 0;
            this.Txt_Name.SelectionStart = 0;
            this.Txt_Name.ShortcutsEnabled = true;
            this.Txt_Name.Size = new System.Drawing.Size(175, 23);
            this.Txt_Name.TabIndex = 14;
            this.Txt_Name.UseSelectable = true;
            this.Txt_Name.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Txt_Name.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Lbl_Name
            // 
            this.Lbl_Name.AutoSize = true;
            this.Lbl_Name.Location = new System.Drawing.Point(45, 160);
            this.Lbl_Name.Name = "Lbl_Name";
            this.Lbl_Name.Size = new System.Drawing.Size(45, 19);
            this.Lbl_Name.TabIndex = 13;
            this.Lbl_Name.Text = "Name";
            // 
            // Txt_PackageID
            // 
            // 
            // 
            // 
            this.Txt_PackageID.CustomButton.Image = null;
            this.Txt_PackageID.CustomButton.Location = new System.Drawing.Point(125, 1);
            this.Txt_PackageID.CustomButton.Name = "";
            this.Txt_PackageID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Txt_PackageID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Txt_PackageID.CustomButton.TabIndex = 1;
            this.Txt_PackageID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Txt_PackageID.CustomButton.UseSelectable = true;
            this.Txt_PackageID.CustomButton.Visible = false;
            this.Txt_PackageID.Enabled = false;
            this.Txt_PackageID.Lines = new string[0];
            this.Txt_PackageID.Location = new System.Drawing.Point(124, 106);
            this.Txt_PackageID.MaxLength = 32767;
            this.Txt_PackageID.Name = "Txt_PackageID";
            this.Txt_PackageID.PasswordChar = '\0';
            this.Txt_PackageID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Txt_PackageID.SelectedText = "";
            this.Txt_PackageID.SelectionLength = 0;
            this.Txt_PackageID.SelectionStart = 0;
            this.Txt_PackageID.ShortcutsEnabled = true;
            this.Txt_PackageID.Size = new System.Drawing.Size(147, 23);
            this.Txt_PackageID.TabIndex = 12;
            this.Txt_PackageID.UseSelectable = true;
            this.Txt_PackageID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Txt_PackageID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Lbl_PackageID
            // 
            this.Lbl_PackageID.AutoSize = true;
            this.Lbl_PackageID.Location = new System.Drawing.Point(45, 110);
            this.Lbl_PackageID.Name = "Lbl_PackageID";
            this.Lbl_PackageID.Size = new System.Drawing.Size(73, 19);
            this.Lbl_PackageID.TabIndex = 11;
            this.Lbl_PackageID.Text = "Package ID";
            // 
            // New_Package
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 493);
            this.Controls.Add(this.Btn_Items);
            this.Controls.Add(this.Txt_Desc);
            this.Controls.Add(this.Lbl_Desc);
            this.Controls.Add(this.Txt_Discount);
            this.Controls.Add(this.Lbl_Discount);
            this.Controls.Add(this.Txt_Price);
            this.Controls.Add(this.Lbl_Price);
            this.Controls.Add(this.Txt_Name);
            this.Controls.Add(this.Lbl_Name);
            this.Controls.Add(this.Txt_PackageID);
            this.Controls.Add(this.Lbl_PackageID);
            this.Name = "New_Package";
            this.Text = "New Package";
            this.Load += new System.EventHandler(this.New_Package_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton Btn_Items;
        private MetroFramework.Controls.MetroTextBox Txt_Desc;
        private MetroFramework.Controls.MetroLabel Lbl_Desc;
        private MetroFramework.Controls.MetroTextBox Txt_Discount;
        private MetroFramework.Controls.MetroLabel Lbl_Discount;
        private MetroFramework.Controls.MetroTextBox Txt_Price;
        private MetroFramework.Controls.MetroLabel Lbl_Price;
        private MetroFramework.Controls.MetroTextBox Txt_Name;
        private MetroFramework.Controls.MetroLabel Lbl_Name;
        private MetroFramework.Controls.MetroTextBox Txt_PackageID;
        private MetroFramework.Controls.MetroLabel Lbl_PackageID;
    }
}