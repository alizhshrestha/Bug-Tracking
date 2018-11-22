using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibGit2Sharp;

using MaterialSkin;
using MaterialSkin.Controls;

namespace BugTracking.View
{
    public partial class User_dashboard : MaterialForm
    {
        int login_id, project_id;
        string first_name, last_name, address, sex, role, username, password;

        public User_dashboard(int login_id, string first_name, string username)
        {
            MaterialSkin();
            this.username = username;
            this.login_id = login_id;
            this.first_name = first_name;
            InitializeComponent();
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

            Project project = new Project(this.login_id);
            project.Show();
        }

        private void listProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List_of_project list_of_project = new List_of_project(this.login_id, this.first_name, this.username);
            list_of_project.ShowDialog();
        }

        private void bugToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bug_report bug_report = new Bug_report();
            bug_report.ShowDialog();
        }

        private void fixToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fix_report fix_report = new Fix_report();
            fix_report.ShowDialog();
        }

        private void bugToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Bug_list bug_list = new Bug_list(this.username);
            bug_list.ShowDialog();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Login_form login_form = new Login_form();
            login_form.Show();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fixToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Bug_fix_list bug_fix_list = new Bug_fix_list(this.username);
            bug_fix_list.ShowDialog();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            User_list user_list = new User_list();
            user_list.ShowDialog();
        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Register_form register = new Register_form();
            register.Show();
        }

        private void MenuStripItem_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void bugToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = DbConnection.connectToDb();
            conn.Open();
            using (conn)
            {
                MySqlCommand command = new MySqlCommand("select * from user where id = '"+this.login_id+"'", conn);
                MySqlDataReader reader = command.ExecuteReader();
                using (reader)
                {
                    while (reader.Read())
                    {
                        this.first_name = reader["first_name"].ToString();
                        this.last_name = reader["last_name"].ToString();
                        this.address = reader["address"].ToString();
                        this.sex = reader["sex"].ToString();
                        this.username = reader["username"].ToString();
                        this.password = reader["password"].ToString();
                        this.role = reader["role"].ToString();
                    }
                }
            }
            conn.Close();
            Register_form register_form = new Register_form(first_name, last_name, address, sex, username, password, role, true);
            register_form.Show();
        }
    }
}
