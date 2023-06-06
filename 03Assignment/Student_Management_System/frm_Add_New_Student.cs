using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management_System
{
    public partial class frm_Add_New_Student : Form
    {
        public frm_Add_New_Student()
        {
            InitializeComponent();
        }


        void Clear_Controls()
        {
            tb_RollNO.Clear();
            tb_Name.Clear();
            tb_MobNO.Clear();
            dtp_DOB.Value = DateTimePicker.MaximumDateTime;
            cmb_Course.SelectedIndex = -1;
        }
        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void frm_Add_New_Student_Load(object sender, EventArgs e)
        {
            Clear_Controls();
        }
    }
}
