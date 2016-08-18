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
        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (metroTextBox1.Text.Length > 0)
            {
                errorProvider1.Clear();
                username = metroTextBox1.Text;
            }
            else
            {
                errorProvider1.SetError(metroTextBox1, "Username is required");
            }


            if (metroTextBox2.Text.Length > 8)
            {
                errorProvider2.Clear();
                password = metroTextBox2.Text;
            }
            else if (metroTextBox2.Text.Length == 0)
            {
                errorProvider2.SetError(metroTextBox2, "Password is required");
            }
            else if (metroTextBox2.Text.Length < 7)
            {
                errorProvider2.SetError(metroTextBox2, "Password must contain more than 7 characters");
            }
            //username = metroTextBox1.Text;
            //password = metroTextBox2.Text;
            String query1 = ("select * from Login_Table where User_Name='" + username + "'and Password='" + password + "'");
            DataTable dt = db.GetData(query1);


            if (dt.Rows.Count > 0)
            {
                Main_Menu mn = new Main_Menu();
                mn.Show();
                Close();
            }
            else
            {
                MetroMessageBox.Show(this, "Invalid Login please check your username and password");
            }

        }
    }
}
