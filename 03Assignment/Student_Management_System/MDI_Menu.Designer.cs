
namespace Student_Management_System
{
    partial class MDI_Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDI_Menu));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.toolsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewStudentListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchStudentDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateStudentDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.courseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewCourseListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notepadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolsMenu,
            this.courseToolStripMenuItem,
            this.toolToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(938, 33);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // toolsMenu
            // 
            this.toolsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewStudentToolStripMenuItem,
            this.viewStudentListToolStripMenuItem,
            this.searchStudentDetailsToolStripMenuItem,
            this.updateStudentDetailsToolStripMenuItem});
            this.toolsMenu.Name = "toolsMenu";
            this.toolsMenu.Size = new System.Drawing.Size(108, 29);
            this.toolsMenu.Text = "Student";
            // 
            // addNewStudentToolStripMenuItem
            // 
            this.addNewStudentToolStripMenuItem.Name = "addNewStudentToolStripMenuItem";
            this.addNewStudentToolStripMenuItem.Size = new System.Drawing.Size(347, 30);
            this.addNewStudentToolStripMenuItem.Text = "Add New Student";
            this.addNewStudentToolStripMenuItem.Click += new System.EventHandler(this.addNewStudentToolStripMenuItem_Click);
            // 
            // viewStudentListToolStripMenuItem
            // 
            this.viewStudentListToolStripMenuItem.Name = "viewStudentListToolStripMenuItem";
            this.viewStudentListToolStripMenuItem.Size = new System.Drawing.Size(347, 30);
            this.viewStudentListToolStripMenuItem.Text = "View Student List";
            this.viewStudentListToolStripMenuItem.Click += new System.EventHandler(this.viewStudentListToolStripMenuItem_Click);
            // 
            // searchStudentDetailsToolStripMenuItem
            // 
            this.searchStudentDetailsToolStripMenuItem.Name = "searchStudentDetailsToolStripMenuItem";
            this.searchStudentDetailsToolStripMenuItem.Size = new System.Drawing.Size(347, 30);
            this.searchStudentDetailsToolStripMenuItem.Text = "Search Student Details";
            this.searchStudentDetailsToolStripMenuItem.Click += new System.EventHandler(this.searchStudentDetailsToolStripMenuItem_Click);
            // 
            // updateStudentDetailsToolStripMenuItem
            // 
            this.updateStudentDetailsToolStripMenuItem.Name = "updateStudentDetailsToolStripMenuItem";
            this.updateStudentDetailsToolStripMenuItem.Size = new System.Drawing.Size(347, 30);
            this.updateStudentDetailsToolStripMenuItem.Text = "Update Student Details";
            this.updateStudentDetailsToolStripMenuItem.Click += new System.EventHandler(this.updateStudentDetailsToolStripMenuItem_Click);
            // 
            // courseToolStripMenuItem
            // 
            this.courseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewCourseToolStripMenuItem,
            this.viewCourseListToolStripMenuItem});
            this.courseToolStripMenuItem.Name = "courseToolStripMenuItem";
            this.courseToolStripMenuItem.Size = new System.Drawing.Size(96, 29);
            this.courseToolStripMenuItem.Text = "Course";
            // 
            // addNewCourseToolStripMenuItem
            // 
            this.addNewCourseToolStripMenuItem.Name = "addNewCourseToolStripMenuItem";
            this.addNewCourseToolStripMenuItem.Size = new System.Drawing.Size(281, 30);
            this.addNewCourseToolStripMenuItem.Text = "Add New Course";
            // 
            // viewCourseListToolStripMenuItem
            // 
            this.viewCourseListToolStripMenuItem.Name = "viewCourseListToolStripMenuItem";
            this.viewCourseListToolStripMenuItem.Size = new System.Drawing.Size(281, 30);
            this.viewCourseListToolStripMenuItem.Text = "View Course List";
            // 
            // toolToolStripMenuItem
            // 
            this.toolToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculatorToolStripMenuItem,
            this.notepadToolStripMenuItem});
            this.toolToolStripMenuItem.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolToolStripMenuItem.Name = "toolToolStripMenuItem";
            this.toolToolStripMenuItem.Size = new System.Drawing.Size(84, 29);
            this.toolToolStripMenuItem.Text = "Tools";
            // 
            // calculatorToolStripMenuItem
            // 
            this.calculatorToolStripMenuItem.Name = "calculatorToolStripMenuItem";
            this.calculatorToolStripMenuItem.Size = new System.Drawing.Size(209, 30);
            this.calculatorToolStripMenuItem.Text = "Calculator";
            // 
            // notepadToolStripMenuItem
            // 
            this.notepadToolStripMenuItem.Name = "notepadToolStripMenuItem";
            this.notepadToolStripMenuItem.Size = new System.Drawing.Size(209, 30);
            this.notepadToolStripMenuItem.Text = "Notepad";
            // 
            // MDI_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 679);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MDI_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Form";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolsMenu;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem addNewStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewStudentListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchStudentDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateStudentDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem courseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewCourseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewCourseListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notepadToolStripMenuItem;
    }
}



