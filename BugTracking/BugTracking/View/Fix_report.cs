using BugTracking.View;
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
    public partial class Fix_report : Form
    {
        Validation validate; //declares validation class
        string bug_title, source_file, class_name, method_line, code_line, project_name;

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
            Bug_list bug_list = new Bug_list();
            bug_list.Show();
        }

        int project_id, bug_id;

        #region Constructor
        public Fix_report(string bug_title, string source_file, string class_name, string method_line, string code_line,int project_id, int bug_id)
        {
            txt_project_name.ReadOnly = true;
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
            InitializeComponent();
            validate = new Validation();
        }
        #endregion


        #region Form Load
        private void Fix_report_Load(object sender, EventArgs e)
        {
            cmb_role.Items.Add("Programmer");
            cmb_role.Items.Add("Tester");
            cmb_role.Items.Add("Developer");
            cmb_role.Text = "Programmer";

            txt_project_name.ReadOnly = true;
            txt_bug.Text = bug_title;
            txt_source_file.Text = source_file;
            txt_class_name.Text = class_name;
            txt_method_line.Text = method_line;
            txt_code_line.Text = code_line;

            MySqlConnection conn = DbConnection.connectToDb();
            conn.Open();
            using (conn)
            {
                MySqlCommand command = new MySqlCommand("select project_name from project where id = '"+this.project_id+"'", conn);
                MySqlDataReader reader = command.ExecuteReader();
                using (reader)
                {
                    while (reader.Read())
                    {
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
                                    if (validate.validateUserInfo(txt_fixer, "FIXER NAME", lbl_validate) == true)
                                    {
                                        String query = "insert into bug_fix (fixer_name, bug_id) values('"+txt_fixer.Text+"', '"+this.bug_id+"')";
                                        MySqlConnection conn = DbConnection.connectToDb();
                                        MySqlCommand command = new MySqlCommand(query, conn);
                                        conn.Open();
                                        command.ExecuteNonQuery();
                                        conn.Close();

                                        
                                        String update_status_query = "update bug set fixed = true where id = '"+this.bug_id+"'";
                                        MySqlConnection conn2 = DbConnection.connectToDb();
                                        MySqlCommand command2 = new MySqlCommand(update_status_query, conn2);
                                        conn2.Open();
                                        command2.ExecuteNonQuery();
                                        MessageBox.Show("status fixed" + Convert.ToString(this.bug_id));
                                        conn2.Close();

                                        this.Close();
                                        Bug_fix_list bug_fix_list = new Bug_fix_list();
                                        bug_fix_list.Show();
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
