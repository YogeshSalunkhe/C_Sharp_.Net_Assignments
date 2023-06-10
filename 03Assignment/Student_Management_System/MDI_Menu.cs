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
    public partial class MDI_Menu : Form
    {

        public MDI_Menu()
        {
            InitializeComponent();
        }

        private void addNewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Add_New_Student obj = new frm_Add_New_Student();
            obj.MdiParent = this;
            obj.WindowState= FormWindowState.Maximized;
            obj.Show();
        }

        private void viewStudentListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_View_All_Student_Details obj = new frm_View_All_Student_Details();
            obj.MdiParent = this;
            obj.WindowState = FormWindowState.Maximized;
            obj.Show();
        }

        private void searchStudentDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Search_Student_Details obj = new frm_Search_Student_Details();
            obj.MdiParent = this;
            obj.WindowState = FormWindowState.Maximized;
            obj.Show();
        }

        private void updateStudentDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Update_Student_Details obj = new frm_Update_Student_Details();
            obj.MdiParent = this;
            obj.WindowState = FormWindowState.Maximized;
            obj.Show();
        }
    }
}
