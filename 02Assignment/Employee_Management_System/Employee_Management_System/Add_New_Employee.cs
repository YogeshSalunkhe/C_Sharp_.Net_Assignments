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

namespace Employee_Management_System
{
    public partial class frm_Add_New_Employee : Form
    {
        public frm_Add_New_Employee()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=LAPTOP-G4TOJ42B;Initial Catalog=Employee_Management_System_DB;Integrated Security=True");

        void Con_Open()
        {
            if(Con.State != ConnectionState.Open)
            {
                Con.Open();
            }
        }
        void Con_Close()
        {
            if(Con.State != ConnectionState.Closed)
            {
                Con.Close();
            }
        }
        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        void Clear_Controls()
        {
            tb_Name.Clear();
            tb_MobileNO.Clear();
            dtp_DOB.Text = "31-12-2003";
            cmb_Designation.SelectedIndex = -1;
            Auto_Incr();
        }

        void Auto_Incr()
        {
            Con_Open();

            int Cnt = 0;
            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = Con;
            Cmd.CommandText = "select Count(*) from Employee_Details";

            Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            Cmd.Dispose();

            if(Cnt > 0)
            {
                Cmd.Connection = Con;
                Cmd.CommandText = "Select Max(Id) from Employee_Details";

                Cnt = Convert.ToInt32(Cmd.ExecuteScalar());
                Cnt++;
            }
            else
            {
                Cnt = 1;
            }

            tb_Id.Text = Convert.ToString(Cnt);
            Con_Close();
        }

        private void Only_Text(object sender, KeyPressEventArgs e)
        {
            if(!(char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space)))
            {
                e.Handled = true;
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void frm_Add_New_Employee_Load(object sender, EventArgs e)
        {
            lbl_Uname.Text = Comman_Content.Username;
            Clear_Controls();
            tb_Name.Focus();
        }
        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            frm_Login Obj = new frm_Login();
            Obj.Show();
            this.Hide();
        }

        private void btn_Veiw_All_Employee_Click(object sender, EventArgs e)
        {
            frm_View_Employee_Details Obj = new frm_View_Employee_Details();
            Obj.Show();
            this.Hide();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Con_Open();

            if (tb_Name.Text != "" && tb_Id.Text != "" && tb_MobileNO.Text != "" && cmb_Designation.Text != "")
            {
                SqlCommand Cmd = new SqlCommand();
                Cmd.Connection = Con;
                Cmd.CommandText = "Insert Into Employee_Details Values(@ID,@NM,@MOBNO,@DOB,@DES)";

                Cmd.Parameters.Add("ID", SqlDbType.Int).Value = tb_Id.Text;
                Cmd.Parameters.Add("NM", SqlDbType.VarChar).Value = tb_Name.Text;
                Cmd.Parameters.Add("MOBNO", SqlDbType.Decimal).Value = tb_MobileNO.Text;
                Cmd.Parameters.Add("DOB", SqlDbType.Date).Value = dtp_DOB.Value.Date;
                Cmd.Parameters.Add("DES", SqlDbType.VarChar).Value = cmb_Designation.Text;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Record Saved Successfully !!!","Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                Clear_Controls();
            }
            else
            {
                MessageBox.Show("Fill All The Fileds!!!", "InComplete Information", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Clear_Controls();
            }
            Con_Close();
        }
    }
}
