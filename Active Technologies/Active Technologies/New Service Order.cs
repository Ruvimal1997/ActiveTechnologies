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
    public partial class New_Service_Order : MetroForm
    {
        public New_Service_Order()
        {
            InitializeComponent();
        }

        private void New_Service_Order_Load(object sender, EventArgs e)
        {

        }
        int serviceid, salesid,tax,discount,total;
        Database db = new Database();
        string clients, comments,duedate;
        private void Btn_Save_Click(object sender, EventArgs e)
        {
            serviceid= Convert.ToInt32(Txt_ServiceID.Text);
            duedate = Dtp_DueDate.Text;
            tax = Convert.ToInt32(Txt_Tax.Text);
            discount = Convert.ToInt32(Txt_Discount.Text);
            total = Convert.ToInt32(Txt_Total.Text);
            clients = Txt_Clients.Text;
            comments = Txt_Comments.Text;


            try
            {
                //hadana one methana login id eka
                string query = "Insert into Service_Orders (Fname,Lname,Title,Phone,Email,Type,Address_No,Address_Street,Address_City,Password) values ('" + fname + "','" + lname + "', '" + title + "' , '" + phoneno + "', '" + email + "', '" + type + "', '" + addno + "', '" + street + "' , '" + city + "' , '" + password + "'  )";
                int line = db.Save_Del_Update(query);

                if (line == 1)
                {

                    MetroMessageBox.Show(this, "Service Orders added Succesfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MetroMessageBox.Show(this, "Service Orders not added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            catch (Exception)
            {
                MetroMessageBox.Show(this, "Exception");
            }


        }
    }
}
