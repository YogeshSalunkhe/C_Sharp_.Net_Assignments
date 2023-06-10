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
    }
}
