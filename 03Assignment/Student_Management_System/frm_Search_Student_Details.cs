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

                }
                else
                {

                }
            }
            else
            {
                MessageBox.Show("Enter Roll Number For Search Details!!!", "INCOPLETE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            Con_Close();
        }
    }
}
