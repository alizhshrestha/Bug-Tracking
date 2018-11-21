using BugTracking.Controller;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

using MaterialSkin;
using MaterialSkin.Controls;

namespace BugTracking
{
    //creating class
    public partial class List_of_project : MaterialForm
    {
        //declaring the variables
        int project_id, user_id, bug_id, login_id;
        string project_name, start_date, end_date, arthur;
        string bug_title, source_file, class_name, method_line, code_line, first_name, username;

        private void btn_update_Click_1(object sender, EventArgs e)
        {
            this.updateFlag = true;
            //closing the form
            this.Close();

            //creatingthe object for Project
            Project project = new Project(project_id, project_name, start_date, end_date, arthur, user_id, updateFlag);
            project.ShowDialog();
        }

        private void btn_open_Click_1(object sender, EventArgs e)
        {

            this.Hide();
            MySqlConnection conn = DatabaseController.connectToDb();
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            using (conn)
            {
                MySqlCommand cmd = new MySqlCommand("select * from bug where project_id='" + this.project_id + "'", conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                using (reader)
                {
                    while (reader.Read())
                    {
                        this.bug_title = (string)reader["bug_title"];
                        this.source_file = (string)reader["source_file"];
                        this.class_name = (string)reader["source_file"];
                        this.method_line = (string)reader["method_line"];
                        this.code_line = (string)reader["code_line"];
                        this.project_id = (int)reader["project_id"];
                        this.bug_id = (int)reader["id"];
                    }
                }
            }
            Bug_report bug_report = new Bug_report(bug_title, source_file, class_name, method_line, code_line, project_id, bug_id, false, this.username);
            bug_report.ShowDialog();
        }

        private void lollipopButton1_Click(object sender, EventArgs e)
        {

        }

        private void data_view_project_list_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        Boolean updateFlag, adminFlag;

        private void btn_open_Click(object sender, EventArgs e)
        {
            
        }

        //parameterized constructor for List_of_project
        public List_of_project(Boolean adminFlag)
        {
            MaterialSkin();
            this.adminFlag = adminFlag;
            InitializeComponent();
        }

        public List_of_project(int login_id, string first_name, string username)
        {
            MaterialSkin();
            this.first_name = first_name;
            this.login_id = login_id;
            this.username = username;
            InitializeComponent();
        }

        //default constructor for List_of_project
        public List_of_project()
        {
            MaterialSkin();
            this.adminFlag = false;
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


        //loads data to List_of_project view
        private void List_of_project_Load(object sender, EventArgs e)
        {
            //checks if admin has logged in or not
            if (adminFlag == true)
            {
                btn_open.Hide();
                btn_update.Hide();
            }
            if (adminFlag==true)
            {
                loadData.loadUserData("select * from project ;", data_view_project_list);

            }
            else
            {
                loadData.loadUserData("select * from project where arthur = '" + this.username + "';", data_view_project_list);
            }
            //data_view_project_list.Columns["project_id"].ReadOnly = true;
            data_view_project_list.Columns["project_name"].ReadOnly = true;
            data_view_project_list.Columns["start_date"].ReadOnly = true;
            data_view_project_list.Columns["end_date"].ReadOnly = true;
            data_view_project_list.Columns["arthur"].ReadOnly = true;
            data_view_project_list.Columns["user_id"].ReadOnly = true;

        }

        //update button event handling
        private void btn_update_Click(object sender, EventArgs e)
        {
             }

        //selectionChanged method for datagrid view
        private void data_view_project_list_SelectionChanged(object sender, EventArgs e)
        {
            //looping through DataGridViewRow
            foreach (DataGridViewRow row in data_view_project_list.SelectedRows)
            {
                //Exception handling
                try
                {
                    //assigning cell value to the local variable.
                    this.project_id = Convert.ToInt32(row.Cells[0].Value);
                    this.project_name = row.Cells[1].Value.ToString();
                    this.start_date = row.Cells[2].Value.ToString();
                    this.end_date = row.Cells[3].Value.ToString();
                    this.arthur = row.Cells[4].Value.ToString();
                    this.user_id = Convert.ToInt32(row.Cells[5].Value);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
