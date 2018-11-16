﻿using BugTracking.View;
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
    public partial class Bug_report : Form
    {
        Validation validate;//defined validation class
        #region constructor
        int project_id;
        string project_name, bug_title, source_file, class_name, method_line, code_line, bug_id, arthur;
        public Bug_report(int project_id, String project_name)
        {
            txt_project_name.ReadOnly = true;
            this.project_id = project_id;
            this.project_name = project_name;

            InitializeComponent();
            validate = new Validation();//initialized validation class
        }

        public Bug_report()
        {
            InitializeComponent();
            validate = new Validation();//initialized validation class
        }

        public Bug_report(string bug_title, string source_file, string class_name, string method_line, string code_line, int project_id, int bug_id)
        {
            txt_project_name.ReadOnly = true;
            this.bug_title = bug_title;
            this.source_file = source_file;
            this.class_name = class_name;
            this.method_line = method_line;
            this.code_line = code_line;
            this.project_id = project_id;

            InitializeComponent();
            validate = new Validation();//initialized validation class
        }
        #endregion

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Bug_report_Load(object sender, EventArgs e)
        {
            txt_project_name.Text = this.project_name;
            txt_bug_title.Text = bug_title;
            txt_source_file.Text = source_file;
            txt_class_name.Text = class_name;
            txt_method_line.Text = method_line;
            txt_code_line.Text = code_line;

            MySqlConnection conn = DbConnection.connectToDb();
            conn.Open();
            using (conn)
            {
                MySqlCommand command = new MySqlCommand("select project_name, arthur from project where id = '" + this.project_id + "'", conn);
                MySqlDataReader reader = command.ExecuteReader();
                using (reader)
                {
                    while (reader.Read())
                    {
                        string proj_name = (string)reader["project_name"];
                        String arthur = (string)reader["arthur"];
                        this.project_name = proj_name;
                        this.arthur = arthur;
                        txt_arthur.Text = this.arthur;
                        txt_project_name.Text = this.project_name;
                    }
                    reader.Close();
                }
            }
            conn.Close();
        }

        #region Button Update click event
        private void btn_update_Click(object sender, EventArgs e)
        {
            if (validate.validateUserInfo(txt_project_name, "PROJECT NAME", lbl_validate) == true)
            {
                if (validate.validateUserInfo(txt_bug_title, "BUG TITLE", lbl_validate) == true)
                {
                    if (validate.validateUserInfo(txt_arthur, "ARTHUR NAME", lbl_validate) == true)
                    {
                        if (validate.validateUserInfo(txt_source_file, "SOURCE FILE", lbl_validate) == true)
                        {
                            if (validate.validateUserInfo(txt_class_name, "CLASS NAME", lbl_validate) == true)
                            {
                                if (validate.validateUserInfo(txt_method_line, "METHOD LINE", lbl_validate) == true)
                                {
                                    if (validate.validateUserInfo(txt_code_line, "CODE LINE", lbl_validate) == true)
                                    {
                                        //data connection and data transfer
                                        MySqlConnection conn = DbConnection.connectToDb();
                                        MySqlCommand command = conn.CreateCommand();
                                        command.CommandText = "insert into bug (bug_title, source_file, class, method_line, code_line, project_id) values('" + txt_bug_title.Text + "', '" + txt_source_file.Text+ "', '" + txt_class_name.Text + "', '" + txt_method_line.Text + "', '"+txt_code_line.Text+"', @project_id)";
                                        command.Parameters.Add(new MySqlParameter("@project_id", project_id));
                                        try
                                        {
                                            conn.Open();
                                        }
                                        catch (Exception ex)
                                        {
                                            MessageBox.Show(ex.Message);
                                        }
                                        MessageBox.Show(Convert.ToString(project_id));
                                        command.ExecuteNonQuery();

                                        conn.Close();
                                        MessageBox.Show("OK");

                                        this.Close();
                                        Bug_list bug_list = new Bug_list();
                                        bug_list.ShowDialog();
                                    }
                                }
                            }
                        }
                    }
                }
            }
            
            
        }
        #endregion
    }
}
