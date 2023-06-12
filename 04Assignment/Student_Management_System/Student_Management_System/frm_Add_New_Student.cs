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
    public partial class frm_Add_New_Student : Form
    {
        public frm_Add_New_Student()
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
            if(Con.State != ConnectionState.Closed)
            {
                Con.Close();
            }
        }
        void Clear_Controls()
        {
            Auto_Incr();
            tb_Name.Clear();
            tb_MobNO.Clear();
            dtp_DOB.Value = dtp_DOB.MaxDate;
            cmb_Course.SelectedIndex = cmb_Course.SelectedIndex = -1;
        }
        void Auto_Incr()
        {
            Con_Open();
            int cnt = 0;

            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = Con;
            Cmd.CommandText = "select count(*) from Student_Details";

            cnt = Convert.ToInt32( Cmd.ExecuteScalar());

            Cmd.Dispose();

            if(cnt > 0)
            {
                Cmd.Connection = Con;
                Cmd.CommandText = "Select Max(Roll_NO) from Student_Details";

                cnt = Convert.ToInt32(Cmd.ExecuteScalar());
                cnt++;
            }
            else
            {
                cnt = 101;
            }
            tb_RollNO.Text = Convert.ToString(cnt);

            Con_Close();
        }
        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void frm_Add_New_Student_Load(object sender, EventArgs e)
        {
            Clear_Controls();
            tb_Name.Focus();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Con_Open();

            if (tb_RollNO.Text != "" && tb_Name.Text != "" && tb_MobNO.Text != "" && cmb_Course.Text != "")
            {
                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Con;
                Cmd.CommandText = "Insert Into Student_Details Values(@Rno,@Nm,@Mno,@Dob,@Cur)";

                Cmd.Parameters.Add("Rno", SqlDbType.Int).Value = tb_RollNO.Text;
                Cmd.Parameters.Add("Nm", SqlDbType.VarChar).Value = tb_Name.Text;
                Cmd.Parameters.Add("Mno", SqlDbType.Decimal).Value = tb_MobNO.Text;
                Cmd.Parameters.Add("Dob", SqlDbType.Date).Value = dtp_DOB.Value.Date;
                Cmd.Parameters.Add("Cur", SqlDbType.VarChar).Value = cmb_Course.Text;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Record Saved Successfully !!!", "Saved Details", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Clear_Controls(); 
            }
            else
            {
                MessageBox.Show("Fill All The Fileds !!!", "Incomplete Details", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Clear_Controls();
            }
            Con_Close();
        }

        private void Only_Number(object sender, KeyPressEventArgs e)
        {
            if(!(char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void Only_Text(object sender, KeyPressEventArgs e)
        {
            if(!(Char.IsLetter(e.KeyChar)|| (e.KeyChar == (char)Keys.Space) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }
    }
}
