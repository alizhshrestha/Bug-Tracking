using BugTracking.Controller;
using BugTracking.Model;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

using MaterialSkin;
using MaterialSkin.Controls;

namespace BugTracking
{
    public partial class Project : MaterialForm
    {
        //creating the variables.
        int login_id, project_id, user_id;
        String project_name, start_date, end_date, arthur ;
        Boolean updateFlag;

        //updating button action
        private void btn_update_Click(object sender, EventArgs e)
        {
            }

        Validation validation;//defined validation class

        private void lollipopButton2_Click(object sender, EventArgs e)
        {

        }

        private void btn_submit_Click_1(object sender, EventArgs e)
        {
            //Validates if information is correct or not
            if (validation.validateUserInfo(txt_project_name, "PROJECT NAME", lbl_validate) == true)
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
                    Console.WriteLine(project_id);
                    this.Hide();
                }
            }

        }

        private void btn_update_Click_1(object sender, EventArgs e)
        {
            //assigning the values to local variable
            this.project_name = txt_project_name.Text;
            this.start_date = dtme_start.Text;
            this.end_date = dtme_end.Text;
            this.arthur = txt_arthur.Text;

            //creating the object for User Project class.
            UserProject project = new UserProject(this.project_id, project_name, start_date, end_date, arthur, this.user_id);

            //method for Updating project to database.
            ProjectController.UpdateProjectToDatabase(project);
            this.Hide();


            MessageBox.Show("Updated successfully!!");

        }

        #region constructor

        //method for project
        public Project(int login_id)
        {
            MaterialSkin();
            this.login_id = login_id;
            updateFlag = false;
            validation = new Validation();//initializing object
            InitializeComponent();
            MessageBox.Show(Convert.ToString(login_id));
        }

        //method for project
        public Project(int project_id, string project_name, string start_date, string end_date, string arthur, int user_id, Boolean updateFlag)
        {
            MaterialSkin();
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
        }
        #endregion

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
            
        }

        #endregion
    }
}
