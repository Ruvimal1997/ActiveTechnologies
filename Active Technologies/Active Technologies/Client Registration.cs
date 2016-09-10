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
    public partial class Client_Registration : MetroForm
    {
        public Client_Registration()
        {
            InitializeComponent();
        }



        private void Client_Registration_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            Main_Menu mn = new Main_Menu();
            mn.Show();
            Close();
        }
        int clientid,addno,phoneno;
        string fname, lname, company, email, street, city, title;
        private void Btn_Save_Click(object sender, EventArgs e)
        {
            clientid = Convert.ToInt32(Txt_Client_ID.Text);
            addno = Convert.ToInt32(Txt_AddNo.Text);
            phoneno = Convert.ToInt32(Txt_PhoneNo.Text);
            fname = Txt_Fname.Text;
            lname = Txt_LName.Text;
            company = Txt_Company.Text;
            email = Txt_Email.Text;
            street = Txt_Street.Text;
            city = Txt_City.Text;
            title=Cmb_Title.Text;



        }
    }
}
