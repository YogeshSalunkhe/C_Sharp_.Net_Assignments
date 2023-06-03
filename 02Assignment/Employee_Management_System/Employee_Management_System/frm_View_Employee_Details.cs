using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Management_System
{
    public partial class frm_View_Employee_Details : Form
    {
        public frm_View_Employee_Details()
        {
            InitializeComponent();
        }

        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            frm_Login Obj = new frm_Login();
            Obj.Show();
            this.Hide();
        }

        private void btn_Add_New_Employee_Click(object sender, EventArgs e)
        {
            frm_Add_New_Employee Obj = new frm_Add_New_Employee();
            Obj.Show();
            this.Hide();
        }

        private void frm_View_Employee_Details_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'employee_Management_System_DBDataSet.Employee_Details' table. You can move, or remove it, as needed.
            this.employee_DetailsTableAdapter.Fill(this.employee_Management_System_DBDataSet.Employee_Details);

            lbl_Uname.Text = Comman_Content.Username;

        }
    }
}
