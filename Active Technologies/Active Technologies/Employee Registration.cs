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
    public partial class Employee_Registration : MetroForm
    {
        public Employee_Registration()
        {
            InitializeComponent();
        }

        private void Employee_Registration_Load(object sender, EventArgs e)
        {

        }
        int empid, phoneno, addno;
        string fname, lname, street, email, title, type, password, city;
        Database db = new Database();
        private void Btn_Save_Click(object sender, EventArgs e)
        {
            empid = Convert.ToInt32(Txt_EmployeeID.Text);
            phoneno = Convert.ToInt32(Txt_Phone.Text);
            addno=Convert.ToInt32(Txt_AddNo.Text);
            fname = Txt_FName.Text;
            lname = Txt_LName.Text;
            street = Txt_Street.Text;
            email = Txt_Email.Text;
            title = Cmb_Title.Text;
            type = Cmb_Type.Text;
            password = Txt_Password.Text;
            city = Txt_City.Text;
            
            try
            {
                string query = "Insert into Employees (Fname,Lname,Title,Phone,Email,Type,Address_No,Address_Street,Address_City,Password) values ('" + fname + "','" + lname + "', '" + title + "' , '" + phoneno + "', '" + email + "', '" + type + "', '" + addno + "', '" + street + "' , '" + city + "' , '" + password + "'  )";
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
                    MetroMessageBox.Show(this, "Employee added Succesfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MetroMessageBox.Show(this, "Employee not added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                
            }
            catch (Exception)
            {
                MetroMessageBox.Show(this, "Exception");
            }

        }
    }
}
