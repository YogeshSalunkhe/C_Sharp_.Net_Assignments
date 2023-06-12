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
    public partial class frm_Update_Student_Details : Form
    {
        public frm_Update_Student_Details()
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
        void Control_Enabled()
        {
            tb_RollNO.Enabled = false;
            tb_Name.Enabled = true;
            tb_MobNO.Enabled = true;
            cmb_Course.Enabled = true;
            dtp_DOB.Enabled = true;
        }
        void Control_Disabled()
        {
            tb_RollNO.Enabled = true;
            tb_Name.Enabled = false;
            tb_MobNO.Enabled = false;
            cmb_Course.Enabled = false;
            dtp_DOB.Enabled = false;
        }
        void Clear_Controls()       
        {
            tb_RollNO.Clear();
            tb_Name.Clear();
            tb_MobNO.Clear();
            dtp_DOB.Value = dtp_DOB.MaxDate;
            cmb_Course.SelectedIndex = -1;
        }
        private void Only_Number(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }
        private void frm_Update_Student_Details_Load(object sender, EventArgs e)
        {
            Control_Disabled();
            Clear_Controls();
        }
        private void btn_Search_Click_1(object sender, EventArgs e)
        {
            Con_Open();

            if(tb_RollNO.Text != "")
            {
                SqlCommand Cmd = new SqlCommand();
                Cmd.Connection = Con;
                Cmd.CommandText = "select * from student_Details where Roll_NO = @Rno";

                Cmd.Parameters.Add("Rno", SqlDbType.Int).Value = tb_RollNO.Text;

                SqlDataReader Dr = Cmd.ExecuteReader();

                if (Dr.Read())
                {
                    tb_Name.Text = Dr.GetString(Dr.GetOrdinal("Name"));
                    tb_MobNO.Text = Dr["Mobile_NO"].ToString();
                    cmb_Course.Text = Dr.GetString(Dr.GetOrdinal("Course"));
                    dtp_DOB.Text = Dr["DOB"].ToString();

                    Control_Enabled();
                }
                else
                {
                    MessageBox.Show("Given Roll Number Is Invalid !!!", "INVALID", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    tb_RollNO.Clear();
                    tb_RollNO.Focus();
                }
            }
            else
            {
                MessageBox.Show("Enter Roll Number For Search And Update Details!!!", "INCOPLETE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_RollNO.Focus();
            }

            Con_Close();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Control_Disabled();
            Clear_Controls();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            Con_Open();

            if(tb_Name.Text != "" && tb_MobNO.Text != "" && cmb_Course.Text != "")
            {
                SqlCommand Cmd = new SqlCommand();
                Cmd.Connection = Con;
                Cmd.CommandText = "update Student_Details set Name = @Nm,Mobile_NO = @Mno,DOB = @Dob,Course = @Crs where Roll_NO = @Rno";

                Cmd.Parameters.Add("Rno", SqlDbType.Int).Value = tb_RollNO.Text;
                Cmd.Parameters.Add("Nm", SqlDbType.VarChar).Value = tb_Name.Text;
                Cmd.Parameters.Add("Mno", SqlDbType.Decimal).Value = tb_MobNO.Text;
                Cmd.Parameters.Add("Dob", SqlDbType.Date).Value = dtp_DOB.Text;
                Cmd.Parameters.Add("Crs", SqlDbType.VarChar).Value = cmb_Course.Text;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Record Updated Succssfully !!!", "UPDATED", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                Clear_Controls();
                Control_Disabled();
            }
            
            Con_Close();
        }

        
    }
}
