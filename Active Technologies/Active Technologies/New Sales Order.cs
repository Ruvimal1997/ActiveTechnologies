using MetroFramework.Forms;
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
    public partial class New_Sales_Order : MetroForm
    {
        public New_Sales_Order()
        {
            InitializeComponent();
        }

        private void New_Sales_Order_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'activeTechnologiesDataSet.Packages' table. You can move, or remove it, as needed.
            this.packagesTableAdapter.Fill(this.activeTechnologiesDataSet.Packages);

        }
        int salesid;
        DateTime DueDate;
        string client, package, item, qty;
        private void Btn_Save_Click(object sender, EventArgs e)
        {

        }
    }
}
