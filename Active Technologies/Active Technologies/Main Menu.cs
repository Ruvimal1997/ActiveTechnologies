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
    public partial class Main_Menu : MetroForm
    {
        public Main_Menu()
        {
            InitializeComponent();
        }

        private void Main_Menu_Load(object sender, EventArgs e)
        {

        }

        private void metroTile14_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            Close();
        }

        private void Tile_Clients_Click(object sender, EventArgs e)
        {
            Clients c = new Clients();
            c.Show();
            Close();
        }

        private void Tile_SalesOrder_Click(object sender, EventArgs e)
        {
            Sales_Order_Details sod = new Sales_Order_Details();
            sod.Show();
            Close();

        }
    }
}
