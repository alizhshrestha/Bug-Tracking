﻿using BugTracking.Controller;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace BugTracking
{
    //creating class
    public partial class List_of_project : Form
    {
        //declaring the variables
        int project_id, user_id, bug_id;
        string project_name, start_date, end_date, arthur;
        string bug_title, source_file, class_name, method_line, code_line;
        Boolean updateFlag, adminFlag;

        private void btn_open_Click(object sender, EventArgs e)
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
                using (reader) {
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
            Bug_report bug_report = new Bug_report(bug_title, source_file, class_name, method_line, code_line, project_id, bug_id, false);
            bug_report.ShowDialog();
        }

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
                btn_open.Hide();
                btn_update.Hide();
            }
            loadData.loadUserData("select * from project;", data_view_project_list);
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
            this.updateFlag = true;
            //closing the form
            this.Close();

            //creatingthe object for Project
            Project project = new Project(project_id, project_name, start_date, end_date, arthur, user_id, updateFlag);
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
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
