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
    public partial class Employee_S : MetroForm
    {
        public Employee_S()
        {
            InitializeComponent();
        }
        Database db = new Database();
        private void Employee_S_Load(object sender, EventArgs e)
        {
            metroGrid1.DataSource = db.GetData("select * from Employees");
        }

        private void Btn_AddEmp_Click(object sender, EventArgs e)
        {
            Employee_Registration er = new Employee_Registration();
            er.Show();
            Close();
        }
    }
}
