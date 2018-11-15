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
        string project_name;
        public Bug_report(int project_id, String project_name)
        {
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
        #endregion

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Bug_report_Load(object sender, EventArgs e)
        {
            txt_project_name.Text = this.project_name;
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
