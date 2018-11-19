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

namespace BugTracking
{
    //creating class
    public partial class List_of_project : Form
    {
        //declaring the variables
        int project_id, user_id;
        string project_name, start_date, end_date, arthur;
        Boolean updateFlag, adminFlag;

        //parameterized constructor for List_of_project
        public List_of_project(Boolean adminFlag)
        {
            this.adminFlag = adminFlag;
            InitializeComponent();
        }

        //default constructor for List_of_project
        public List_of_project()
        {
            this.adminFlag = false;
            InitializeComponent();
        }

        //loads data to List_of_project view
        private void List_of_project_Load(object sender, EventArgs e)
        {
            //checks if admin has logged in or not
            if (adminFlag == true)
            {
                btn_edit.Hide();
                btn_update.Hide();
            }
            loadData.loadUserData("select * from project;", data_view_project_list);
            
        }

        //update button event handling
        private void btn_update_Click(object sender, EventArgs e)
        {
            this.updateFlag = true;
            //closing the form
            this.Close();

            //creatingthe object for Project
            Project project = new Project(project_id, project_name, start_date, end_date, arthur, user_id, updateFlag);
            MessageBox.Show(Convert.ToString("Project ID: " +user_id));
            project.ShowDialog();
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
                    MessageBox.Show(Convert.ToString(user_id));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
