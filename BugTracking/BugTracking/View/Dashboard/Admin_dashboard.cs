using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BugTracking.View.Dashboard
{
    public partial class Admin_dashboard : Form
    {
        int login_id;
        Boolean adminFlag;
        public Admin_dashboard(int login_id)
        {
            this.login_id = login_id;
            InitializeComponent();
        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Register_form register = new Register_form();
            register.ShowDialog();
        }

        private void Admin_dashboard_Load(object sender, EventArgs e)
        {

        }

        private void newProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Project project = new Project(login_id);
            project.ShowDialog();
        }

        private void listProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.adminFlag = true;
            List_of_project list_of_project = new List_of_project(adminFlag);
            list_of_project.ShowDialog();
        }
    }
}
