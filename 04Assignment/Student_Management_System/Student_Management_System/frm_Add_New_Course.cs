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
    public partial class frm_Add_New_Course : Form
    {
        public frm_Add_New_Course()
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
        void Clear_Cantrols()
        {
            Auto_Incr();
            tb_Course_Name.Clear();
        }
        void Auto_Incr()
        {
            Con_Open();
            int Cnt = 0;

            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = Con;
            Cmd.CommandText = "select count (*) from Course_Details";

            Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            Cmd.Dispose();

            if(Cnt > 0)
            {
                Cmd.Connection = Con;
                Cmd.CommandText = "select max(Course_id) from Course_Details";

                Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

                Cnt++;
            }
            else
            {
                Cnt = 1;
            }

            tb_Course_Id.Text = Convert.ToString(Cnt);

            Con_Close();
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            Con_Open();

            if(tb_Course_Name.Text != "")
            {
                SqlCommand Cmd = new SqlCommand();
                Cmd.Connection = Con;
                Cmd.CommandText = "Insert into Course_Details values(@Cid, @Cnm)";

                Cmd.Parameters.Add("Cid", SqlDbType.Int).Value = tb_Course_Id.Text;
                Cmd.Parameters.Add("Cnm", SqlDbType.NVarChar).Value = tb_Course_Name.Text;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Course Saved Succsefully !!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("First Mention The Course Name !!!", "INCOMPLETE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            Clear_Cantrols();
            Con_Close();
        }

        private void frm_Add_New_Course_Load(object sender, EventArgs e)
        {
            Clear_Cantrols();
        }
    }
}
