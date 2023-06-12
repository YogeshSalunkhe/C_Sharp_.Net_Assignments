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
    public partial class frm_Search_Student_Details : Form
    {
        public frm_Search_Student_Details()
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
        void Clear_Cantrols()
        {
            tb_RollNO.Clear();
            tb_Name.Clear();
            tb_MobNO.Clear();
            dtp_DOB.Value = dtp_DOB.MaxDate;
            cmb_Course.SelectedIndex = -1;
        }
        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (Char)Keys.Back)))
            {
                e.Handled = true;
            }
        }
        private void btn_Search_Click(object sender, EventArgs e)
        {
            Con_Open();

            if(tb_RollNO.Text != "")
            {
                SqlCommand Cmd = new SqlCommand();
                Cmd.Connection = Con;
                Cmd.CommandText = "select * from Student_Details where Roll_NO = @Rno";

                Cmd.Parameters.Add("Rno", SqlDbType.Int).Value = tb_RollNO.Text;

                SqlDataReader Dr = Cmd.ExecuteReader();

                if(Dr.Read())
                {
                    tb_Name.Text = Dr.GetString(Dr.GetOrdinal("Name"));
                    tb_MobNO.Text = (Dr["Mobile_NO"].ToString());
                    dtp_DOB.Text = (Dr["DOB"].ToString());
                    cmb_Course.Text = Dr.GetString(Dr.GetOrdinal("Course"));

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
                MessageBox.Show("Enter Roll Number For Search Details!!!", "INCOPLETE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_RollNO.Focus();
            }


            Con_Close();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Cantrols();
            tb_RollNO.Focus();
        }

        private void frm_Search_Student_Details_Load(object sender, EventArgs e)
        {
            tb_RollNO.Focus();
        }

        private void Only_Number(object sender, KeyPressEventArgs e)
        {
            if(!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (Char)Keys.Back)))
            {
                e.Handled = true;
            }
        }
    }
}
