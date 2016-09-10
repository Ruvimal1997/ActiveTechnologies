﻿using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Active_Technologies
{
    public partial class Items : MetroForm
    {
        public Items()
        {
            InitializeComponent();
        }
        Database db = new Database();
        private void Items_Load(object sender, EventArgs e)
        {
            metroGrid1.DataSource = db.GetData("select * from Items");
        }

        private void Btn_AddItem_Click(object sender, EventArgs e)
        {
            New_Item ni = new New_Item();
            ni.Show();
            Close();
        }
    }
}
