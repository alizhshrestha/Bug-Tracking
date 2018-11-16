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
        int login_id, project_id, user_id;
        String project_name, start_date, end_date, arthur ;
        Boolean updateFlag;

        private void btn_update_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Convert.ToString(this.project_id));
            String update_query = "Update project set project_name='"+txt_project_name.Text+"', start_date='"+dtme_start.Text+"', end_date='"+dtme_end.Text+"', arthur='"+txt_arthur.Text+"' where id='"+this.project_id+"'";
            MySqlConnection conn = DbConnection.connectToDb();
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
            MessageBox.Show("Updated successfully!!");
        }

        Validation validation;//defined validation class

        #region constructor
        public Project(int login_id)
        {
            this.login_id = login_id;
            updateFlag = false;
            validation = new Validation();//initialized validation class
            InitializeComponent();
            MessageBox.Show(Convert.ToString(login_id));
        }

        public Project(int project_id, string project_name, string start_date, string end_date, string arthur, int user_id, Boolean updateFlag)
        {
            this.project_id = project_id;
            this.updateFlag = updateFlag;
            this.project_name = project_name;
            this.start_date = start_date;
            this.end_date = end_date;
            this.arthur = arthur;
            this.user_id = user_id;
            validation = new Validation();//initialized validation class
            InitializeComponent();
            MessageBox.Show(Convert.ToString(login_id));
        }
        #endregion

        private void Project_Load(object sender, EventArgs e)
        {
            if (updateFlag==true)
            {
                btn_submit.Hide();
                btn_update.Show();
            }
            txt_project_name.Text = this.project_name;
            dtme_start.Text = this.start_date;
            dtme_end.Text = this.end_date;
            txt_arthur.Text = this.arthur;
        }

        #region button submit event
        private void btn_submit_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Convert.ToString(login_id));
            //Validates if information is correct or not
            if (validation.validateUserInfo(txt_project_name, "PROJECT NAME", lbl_validate)==true)
            {
                if (validation.validateUserInfo(txt_arthur, "ARTHUR NAME", lbl_validate) == true)
                {
                    project_name = txt_project_name.Text;
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

                    conn.Close();
                }
            }
            
        }

        #endregion
    }
}
