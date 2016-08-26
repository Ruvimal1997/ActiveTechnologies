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
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        string username, password;
        Database db = new Database();

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {

            //if (Txt_Username.Text.Length > 0)
            //{
            //    errorProvider1.Clear();
            //    username = Txt_Username.Text;
            //}
            //else
            //{
            //    errorProvider1.SetError(Txt_Username, "Username is required");
            //}


            //if (Txt_Password.Text.Length > 8)
            //{
            //    errorProvider2.Clear();
            //    password = Txt_Password.Text;
            //}
            //else if (Txt_Password.Text.Length == 0)
            //{
            //    errorProvider2.SetError(Txt_Password, "Password is required");
            //}
            //else if (Txt_Password.Text.Length < 7)
            //{
            //    errorProvider2.SetError(Txt_Password, "Password must contain more than 7 characters");
            //}
            //username = metroTextBox1.Text;
            //password = metroTextBox2.Text;
            //String query1 = ("select * from Login_Table where User_Name='" + username + "'and Password='" + password + "'");
            //DataTable dt = db.GetData(query1);


            //if (dt.Rows.Count > 0)
            //{
            Main_Menu mn = new Main_Menu();
            mn.Show();
            Hide();
            //    }
            //    else
            //    {
            //        MetroMessageBox.Show(this, "Invalid Login please check your username and password");
            //    }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
