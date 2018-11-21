using BugTracking.Controller;
using BugTracking.Model;
using BugTracking.View;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;


namespace BugTracking
{

    //creating class for Fix_report
    public partial class Fix_report : MaterialForm
    {
        Validation validate; //declare validation class
        //declaring variables.
        string bug_title, source_file, class_name, method_line, code_line, project_name, fixer_name, resolved_code, username;
        int project_id, bug_id;

        private void btn_update_Click_1(object sender, EventArgs e)
        {
            //validates fix report information
            if (validate.validateUserInfo(txt_project_name, "PROJECT NAME", lbl_validate) == true)
            {
                if (validate.validateUserInfo(txt_bug, "BUG TITLE", lbl_validate) == true)
                {
                    if (validate.validateUserInfo(txt_source_file, "SOURCE FILE", lbl_validate) == true)
                    {
                        if (validate.validateUserInfo(txt_class_name, "CLASS NAME", lbl_validate) == true)
                        {
                            if (validate.validateUserInfo(txt_code_line, "CODE LINE", lbl_validate) == true)
                            {
                                if (validate.validateUserInfo(txt_method_line, "METHOD LINE", lbl_validate) == true)
                                {
                                    if (validate.validateUserInfo(txt_resolved_code, "RESOLVE CODE", lbl_validate) == true)
                                    {
                                        if (validate.validateUserInfo(txt_fixer, "FIXER NAME", lbl_validate) == true)
                                        {

                                            this.bug_title = txt_bug.Text;
                                            this.source_file = txt_source_file.Text;
                                            this.class_name = txt_class_name.Text;
                                            this.method_line = txt_method_line.Text;
                                            this.code_line = txt_code_line.Text;
                                            this.fixer_name = txt_fixer.Text;
                                            this.resolved_code = txt_resolved_code.Text;
                                            Bug_fix bf = new Bug_fix(fixer_name, resolved_code, this.bug_id, this.username);
                                            BugFixController.insertBugFixToDatabase(bf);


                                            String update_status_query = "update bug set fixed = true where id = '" + this.bug_id + "'";
                                            MySqlConnection conn2 = DbConnection.connectToDb();
                                            MySqlCommand command2 = new MySqlCommand(update_status_query, conn2);
                                            conn2.Open();
                                            command2.ExecuteNonQuery();
                                            conn2.Close();


                                            this.Hide();
                                            MessageBox.Show("Submitted successfully");
                                        }
                                    }
                                    
                                }
                            }
                        }
                    }
                }
            }
        }

        private void btn_back_Click_1(object sender, EventArgs e)
        {
            this.Close();

            //creating object for Bug_list.
            Bug_list bug_list = new Bug_list();
            bug_list.Show();
        }

        private void lollipopLabel6_Click(object sender, EventArgs e)
        {

        }

        //back button click event
        private void btn_back_Click(object sender, EventArgs e)
        {
            
        }

        #region Constructor
        public Fix_report(string bug_title, string source_file, string class_name, string method_line, 
            string code_line,int project_id, int bug_id,string resolved_code)
        {
            MaterialSkin();
            //txt_project_name.ReadOnly = true;
            this.bug_title = bug_title;
            this.source_file = source_file;
            this.class_name = class_name;
            this.method_line = method_line;
            this.code_line = code_line;
            this.project_id = project_id;
            this.bug_id = bug_id;
            this.resolved_code = resolved_code;
            InitializeComponent();
            validate = new Validation();
        }

        public Fix_report(string bug_title, string source_file, string class_name, string method_line,
            string code_line, int project_id, int bug_id, string resolved_code, string username)
        {
            MaterialSkin();
            //txt_project_name.ReadOnly = true;
            this.bug_title = bug_title;
            this.source_file = source_file;
            this.class_name = class_name;
            this.method_line = method_line;
            this.code_line = code_line;
            this.project_id = project_id;
            this.bug_id = bug_id;
            this.resolved_code = resolved_code;
            this.username = username;
            InitializeComponent();
            validate = new Validation();
        }

        public Fix_report(string bug_title, string source_file, string class_name, string method_line,
            string code_line, int project_id, int bug_id)
        {
            MaterialSkin();
            //txt_project_name.ReadOnly = true;
            this.bug_title = bug_title;
            this.source_file = source_file;
            this.class_name = class_name;
            this.method_line = method_line;
            this.code_line = code_line;
            this.project_id = project_id;
            this.bug_id = bug_id;
            InitializeComponent();
            validate = new Validation();
        }


        public Fix_report()
        {
            MaterialSkin();
            InitializeComponent();
            validate = new Validation();
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


        #region Form Load
        private void Fix_report_Load(object sender, EventArgs e)
        {
            //combo box items adding user types
            cmb_role.Items.Add("Programmer");
            cmb_role.Items.Add("Tester");
            cmb_role.Items.Add("Developer");
            cmb_role.Text = "Programmer";

            //assigning the value to the variables.
            txt_project_name.ReadOnly = true;
            txt_bug.Text = bug_title;
            txt_source_file.Text = source_file;
            txt_class_name.Text = class_name;
            txt_method_line.Text = method_line;
            txt_code_line.Text = code_line;
            txt_resolved_code.Text = this.resolved_code;
            //Establishing connection with database.
            MySqlConnection conn = DbConnection.connectToDb();
            conn.Open();
            using (conn)
            {
                //Query running
                MySqlCommand command = new MySqlCommand("select project_name from project where id = '"+this.project_id+"'", conn);
                MySqlDataReader reader = command.ExecuteReader();
                using (reader)
                {
                    while (reader.Read())
                    {
                        //Reads project_name from database and assign to proj_name
                        string proj_name = (string)reader["project_name"];
                        this.project_name = proj_name;
                        txt_project_name.Text = this.project_name;
                    }
                    reader.Close();
                }
            }
            conn.Close();
            
        }
        #endregion

        #region Button Update Click event
        private void btn_update_Click(object sender, EventArgs e)
        {
            
        }
        #endregion

    }
}
