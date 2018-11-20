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
    public partial class Bug_report : MaterialForm
    {
        Validation validate;//defined validation class
        #region constructor
        int project_id, bug_id;
        string project_name, bug_title, source_file, class_name, method_line, code_line, arthur, username;

        private void btn_submit_Click(object sender, EventArgs e)
        {
            
        }

        private void lollipopLabel6_Click(object sender, EventArgs e)
        {

        }

        private void lollipopTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {

        }

        private void btn_submit_Click_1(object sender, EventArgs e)
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
                                        string bug_title = txt_bug_title.Text;
                                        string source_file = txt_source_file.Text;
                                        string class_name = txt_class_name.Text;
                                        string method_line = txt_method_line.Text;
                                        string code_line = txt_code_line.Text;

                                        Console.WriteLine(this.project_id);
                                        Bug bug = new Bug(bug_title, source_file, class_name, method_line, code_line, this.username, this.project_id);
                                        BugController.insertBugToDatabase(bug);
                                        MessageBox.Show("Submitted Successfully");
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void btn_update_Click_1(object sender, EventArgs e)
        {
            String update_query = "Update bug set bug_title='" + txt_bug_title.Text + "', source_file='" + txt_source_file.Text + "', class='" + txt_class_name.Text + "'," +
                " method_line='" + txt_method_line.Text + "', code_line='" + txt_code_line.Text + "' where id='" + this.bug_id + "'";
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
            Bug_list bug_list = new Bug_list(this.username);
            bug_list.ShowDialog();
            conn.Close();
        }

        Boolean updateFlag;
        public Bug_report(int project_id, String project_name)
        {
            MaterialSkin();

            this.project_id = project_id;
            this.project_name = project_name;

            InitializeComponent();
            validate = new Validation();//initialized validation class
        }

        public Bug_report()
        {
            MaterialSkin();
            InitializeComponent();
            validate = new Validation();//initialized validation class
        }

        public Bug_report(string bug_title, string source_file, string class_name, string method_line, string code_line, int project_id, int bug_id, Boolean updateFlag, string username)
        {
            //txt_project_name.ReadOnly = true;
            MaterialSkin();

            this.bug_title = bug_title;
            this.source_file = source_file;
            this.class_name = class_name;
            this.method_line = method_line;
            this.code_line = code_line;
            this.project_id = project_id;
            this.bug_id = bug_id;
            this.updateFlag = updateFlag;
            this.username = username;

            InitializeComponent();
            validate = new Validation();//initialized validation class
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


        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Bug_report_Load(object sender, EventArgs e)
        {
            btn_update.Hide();
            txt_project_name.Text = this.project_name;
            txt_bug_title.Text = bug_title;
            txt_source_file.Text = source_file;
            txt_class_name.Text = class_name;
            txt_method_line.Text = method_line;
            txt_code_line.Text = code_line;

            if (updateFlag==true)
            {
                btn_submit.Hide();
                btn_update.Show();
            }

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
            

        }
        #endregion
    }
}
