using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Student_Management_System
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=LAPTOP-G4TOJ42B;Initial Catalog=Student_Information_DB;Integrated Security=True");

        void Con_Open()
        {
            if(Con.State != ConnectionState.Open)
            {
                Con.Open();
            }
        }

        void Con_Close()
        {
            if (Con.State != ConnectionState.Closed)
            {
                Con.Close();
            }
        }
        private void frm_Login_Load(object sender, EventArgs e)
        {
            tb_Username.Focus();
            lbl_MSG.Text = "Please Enter Valid Username And Password!!!";
        }

        private void tb_Username_TextChanged(object sender, EventArgs e)
        {
            tb_Password.Enabled = true;
            lbl_MSG.Visible = true;
        }

        private void tb_Password_TextChanged(object sender, EventArgs e)
        {
            btn_Submit.Enabled = true;
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            Con_Open();
            int Cnt = 0;

            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = Con;
            Cmd.CommandText = "select count(*) from Login_Details where Username = @Un and Password = @pwd";

            Cmd.Parameters.Add("Un", SqlDbType.NVarChar).Value = tb_Username.Text;
            Cmd.Parameters.Add("Pwd", SqlDbType.NVarChar).Value = tb_Password.Text;

            Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            if(Cnt > 0)
            {
                MessageBox.Show("Login Successfully!!!","Login",MessageBoxButtons.OK,MessageBoxIcon.Information);
                MDI_Menu obj = new MDI_Menu();
                obj.Show();
                this.Hide();

            }
            else
            {
                lbl_MSG.Text = "Invalid Username Or Password !!!";
                lbl_MSG.Visible = true;
                tb_Username.Focus();
            }
            tb_Username.Clear();
            tb_Password.Clear();

            Con_Close();
        }
    }
}
