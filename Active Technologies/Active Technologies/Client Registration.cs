using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
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
        Database db = new Database();
        private void Btn_Save_Click(object sender, EventArgs e)
        {
            addno = Convert.ToInt32(Txt_AddNo.Text);
            phoneno = Convert.ToInt32(Txt_PhoneNo.Text);
            fname = Txt_Fname.Text;
            lname = Txt_LName.Text;
            company = Txt_Company.Text;
            email = Txt_Email.Text;
            street = Txt_Street.Text;
            city = Txt_City.Text;
            title=Cmb_Title.Text;
            try
            {


                string query = "Insert into Clients (Fname,Lname,Title,Company,Phone,Email,Address_No,Address_Street,Address_City) values ('" + fname + "','" + lname + "', '" + title + "' , '" + company + "', '" + phoneno + "', '" + email + "', '" + addno + "', '" + street + "' , '" + city + "'  )";
                int line = db.Save_Del_Update(query);

                if (line == 1)
                {

                    //string messgae = "Dear Employee, Welcome to Asia Hospital. ";
                    //SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                    //client.EnableSsl = true;
                    //client.Timeout = 10000;
                    //client.DeliveryMethod = SmtpDeliveryMethod.Network;
                    //client.UseDefaultCredentials = false;
                    //client.Credentials = new NetworkCredential("asiahospital123@gmail.com", "asia12345");
                    //MailMessage msg = new MailMessage();
                    //msg.To.Add(email);
                    //msg.From = new MailAddress("asiahospital123@gmail.com");
                    //msg.Subject = "Re:Asia Hospital";
                    //msg.Body = messgae;
                    //client.Send(msg);
                    MetroMessageBox.Show(this, "Client added Succesfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MetroMessageBox.Show(this, "Client not added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }

            catch (Exception)
            {
                MetroMessageBox.Show(this, "Exception");
            }


        }
    }
}
