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

        private void Tile_SaleNew_Click(object sender, EventArgs e)
        {
            New_Sales_Order nso = new New_Sales_Order();
            nso.Show();
            Close(); 
        }

        private void Tile_SaleReports_Click(object sender, EventArgs e)
        {
            Sales_Report sr = new Sales_Report();
            sr.Show();
            Close();
        }

        private void Tile_PurchaseOrder_Click(object sender, EventArgs e)
        {
            Purchase_Order_Details pod = new Purchase_Order_Details();
            pod.Show();
            Close();
        }

        private void Tile_PurchaseNew_Click(object sender, EventArgs e)
        {
            New_Purchase_Order npo = new New_Purchase_Order();
            npo.Show();
            Close();
        }

        private void Tile_PurchaseReports_Click(object sender, EventArgs e)
        {
            Purchasing_Report pr = new Purchasing_Report();
            pr.Show();
            Close();
        }

        private void Tile_ServiceOrder_Click(object sender, EventArgs e)
        {
            Service_Order_Details sod = new Service_Order_Details();
            sod.Show();
            Close();
        }

        private void Tile_ServiceNew_Click(object sender, EventArgs e)
        {
            New_Service_Order nso = new New_Service_Order();
            nso.Show();
            Close();
        }

        private void Tile_ServiceReports_Click(object sender, EventArgs e)
        {
            Service_Report sr = new Service_Report();
            sr.Show();
            Close();
        }

        private void Tile_Items_Click(object sender, EventArgs e)
        {
            Items itm = new Items();
            itm.Show();
            Close();
        }

        private void Tile_Packages_Click(object sender, EventArgs e)
        {
            Package_Details pd = new Package_Details();
            pd.Show();
            Close();
        }

        private void Tile_Employees_Click(object sender, EventArgs e)
        {
            Employee_S es = new Employee_S();
            es.Show();
            Close();
        }
    }
}
