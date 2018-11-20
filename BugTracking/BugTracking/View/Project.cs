using BugTracking.Controller;
using BugTracking.Model;
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
    public partial class Project : Form
    {
        //creating the variables.
        int login_id, project_id, user_id;
        String project_name, start_date, end_date, arthur ;
        Boolean updateFlag;

        //updating button action
        private void btn_update_Click(object sender, EventArgs e)
        {
            //assigning the values to local variable
            //MessageBox.Show("Project Id:"+Convert.ToString(this.project_id));
            this.project_name = txt_project_name.Text;
            //MessageBox.Show("Project Name:" + Convert.ToString(this.project_name));
            this.start_date = dtme_start.Text;
            this.end_date = dtme_end.Text;
            this.arthur = txt_arthur.Text;
            //MessageBox.Show("User Id:" + Convert.ToString(this.user_id));

            //creating the object for User Project class.
            UserProject project = new UserProject(this.project_id, project_name, start_date, end_date, arthur, this.user_id);

            //method for Updating project to database.
            ProjectController.UpdateProjectToDatabase(project);
            MessageBox.Show("Successfully updated");
            //String update_query = "Update project set project_name='"+txt_project_name.Text+"', start_date='"+dtme_start.Text+"', end_date='"+dtme_end.Text+"', arthur='"+txt_arthur.Text+"' where id='"+this.project_id+"'";
            /*MySqlConnection conn = DbConnection.connectToDb();
            MySqlCommand command = new MySqlCommand(update_query, conn);
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            command.ExecuteNonQuery();
            */
            MessageBox.Show("Updated successfully!!");
        }

        Validation validation;//defined validation class

        #region constructor

        //method for project
        public Project(int login_id)
        {
            this.login_id = login_id;
            updateFlag = false;
            validation = new Validation();//initializing object
            InitializeComponent();
            MessageBox.Show(Convert.ToString(login_id));
        }

        //method for project
        public Project(int project_id, string project_name, string start_date, string end_date, string arthur, int user_id, Boolean updateFlag)
        {
            //assigning value to local variables.
            this.project_id = project_id;
            this.updateFlag = updateFlag;
            this.project_name = project_name;
            this.start_date = start_date;
            this.end_date = end_date;
            this.arthur = arthur;
            this.user_id = user_id;
            validation = new Validation();//initialized validation class
            InitializeComponent();
            MessageBox.Show(Convert.ToString("From project: " +user_id));
        }
        #endregion

        //Load data to project form
        private void Project_Load(object sender, EventArgs e)
        {
            //checking the update status
            if (updateFlag==true)
            {
                btn_submit.Hide();
                btn_update.Show();
            }
            else
            {
                btn_update.Hide();
            }

            //assigning text box value
            txt_project_name.Text = this.project_name;
            dtme_start.Text = this.start_date;
            dtme_end.Text = this.end_date;
            txt_arthur.Text = this.arthur;
        }

        #region button submit event

        //submit button event
        private void btn_submit_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Convert.ToString(login_id));
            //Validates if information is correct or not
            if (validation.validateUserInfo(txt_project_name, "PROJECT NAME", lbl_validate)==true)
            {
                if (validation.validateUserInfo(txt_arthur, "ARTHUR NAME", lbl_validate) == true)
                {
                    //declaring and assigning the value 
                    string project_name = txt_project_name.Text;
                    string start_date = dtme_start.Text;
                    string end_date = dtme_end.Text;
                    string arthur = txt_arthur.Text;
                    
                    //creating object for UserProject
                    UserProject project = new UserProject(project_name, start_date, end_date, arthur, this.login_id);

                    //method to insert project in database 
                    ProjectController.insertProjectToDatabase(project);
                    MessageBox.Show("Successfully submited");
                    //this.Close();

                    //Establishing the connection to the database.
                    MySqlConnection conn = DatabaseController.connectToDb();

                    //opening the connection to the database.
                    conn.Open();


                    using (conn)
                    {
                        MessageBox.Show("Project Name: " + Convert.ToString(project_name));

                        //assigning query to MySqlCommand
                        MySqlCommand command2 = new MySqlCommand("select id from project where project_name = '" + txt_project_name.Text + "'", conn);
                        MySqlDataReader reader = command2.ExecuteReader();
                        using (reader)
                        {
                            while (reader.Read())
                            {
                                int id = (int)reader["id"];
                                project_id = id;
                            }
                        }

                    }

                    //creating Bug_report object
                    //Bug_report bug_report = new Bug_report(project_id, project_name);
                    Console.WriteLine(project_id);
                    //bug_report.ShowDialog();


                    
                    /*project_name = txt_project_name.Text;
                    //data connection and data transfer
                    MySqlConnection conn = DbConnection.connectToDb();
                    MySqlCommand command = conn.CreateCommand();
                    command.CommandText = "insert into project (project_name, start_date, end_date, arthur, user_id) values('" + txt_project_name.Text + "', '" + dtme_start.Text + "', '" + dtme_end.Text + "', '" + txt_arthur.Text + "', @login_id)";
                    command.Parameters.Add(new MySqlParameter("@login_id", login_id));
                    try
                    {
                        conn.Open();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    command.ExecuteNonQuery();

                    conn.Close();

                    conn.Open();
                    using (conn)
                    {
                        MessageBox.Show("Project Name: "+ Convert.ToString(project_name));
                        MySqlCommand command2 = new MySqlCommand("select id from project where project_name = '" + txt_project_name.Text + "'", conn);
                        MySqlDataReader reader = command2.ExecuteReader();
                        using (reader)
                        {
                            while (reader.Read())
                            {
                                int id = (int)reader["id"];
                                project_id = id;
                            }
                        }

                    }
                    

                    MessageBox.Show("successfully project created");
                    this.Close();
                    Bug_report bug_report = new Bug_report(project_id, project_name);
                    bug_report.ShowDialog();
                    MessageBox.Show("Successfully submited");

                    conn.Close();*/
                }
            }
            
        }

        #endregion
    }
}
