using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace BugTracking.View.Dashboard
{
    public partial class Admin_dashboard : MaterialForm
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
            MaterialSkin();
            Register_form register = new Register_form();
            register.ShowDialog();
        }

        private void Admin_dashboard_Load(object sender, EventArgs e)
        {

        }

        public void MaterialSkin()
        {
            // Create a material theme manager and add the form to manage (this)
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE
            );
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

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User_list user_list = new User_list();
            user_list.ShowDialog();
        }
    }
}
