using MetroFramework;
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
    public partial class New_Package : MetroForm
    {
        public New_Package()
        {
            InitializeComponent();
        }

        private void New_Package_Load(object sender, EventArgs e)
        {

        }
        int packageid, price, discount;
        string name, decription;
        Database db=new Database();
        private void Btn_Items_Click(object sender, EventArgs e)
        {
         
            price = Convert.ToInt32(Txt_Price.Text);
            discount = Convert.ToInt32(Txt_Discount.Text);
            name = Txt_Name.Text;
            decription = Txt_Desc.Text;

            try
            {
                string query = "Insert into Packages (Name,Description,Discount,Price) values ('" + name + "','" + decription + "', '" + discount + "' , '" + price + "')";
                int line = db.Save_Del_Update(query);

                if (line == 1)
                {

                   
                    MetroMessageBox.Show(this, "Packages added Succesfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MetroMessageBox.Show(this, "Packages not added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            catch (Exception)
            {
                MetroMessageBox.Show(this, "Exception");
            }
        }
    }
}
