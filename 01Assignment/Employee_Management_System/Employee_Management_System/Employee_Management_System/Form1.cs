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
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        private void frm_Login_Load(object sender, EventArgs e)
        {
            tb_Password.Enabled = false;
            btn_Submit.Enabled = false;
            lbl_Note.Text = "Enter A Valid Username And Password !!!";
        }

        private void tb_Username_TextChanged(object sender, EventArgs e)
        {
            tb_Password.Enabled = true;
        }

        private void tb_Password_TextChanged(object sender, EventArgs e)
        {
            btn_Submit.Enabled = true;
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            if(tb_Username.Text == "a" && tb_Password.Text == "a")
            {
                MessageBox.Show("Login Successfully!!!","WECOME",MessageBoxButtons.OK,MessageBoxIcon.Information);

                frm_Add_New_Employee Obj = new frm_Add_New_Employee();
                this.Hide();
                Obj.Show();
            }
            else
            {
                lbl_Note.Text = "Invalid Username Or Password !!!";
                lbl_Note.ForeColor = Color.Red;
                tb_Username.Focus();
            }
            tb_Username.Clear();
            tb_Password.Clear();
        }
    }
}
