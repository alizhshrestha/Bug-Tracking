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
        Validation validation;//defined validation class

        #region constructor
        public Project()
        {
            validation = new Validation();//initialized validation class
            InitializeComponent();
        }
        #endregion

        private void Project_Load(object sender, EventArgs e)
        {

        }

        #region button submit event
        private void btn_submit_Click(object sender, EventArgs e)
        {
            //Validates if information is correct or not
            if (validation.validateUserInfo(txt_project_name, "PROJECT NAME", lbl_validate)==true)
            {
                if (validation.validateUserInfo(txt_arthur, "ARTHUR NAME", lbl_validate) == true)
                {
                    //data connection and data transfer
                    string connString = "Data Source=localhost;port=3306;Initial Catalog=bug_tracking; User Id=root; password=''";
                    MySqlConnection conn = new MySqlConnection(connString);
                    MySqlCommand command = conn.CreateCommand();
                    command.CommandText = "insert into project_list (project_name, start_date, end_date, arthur, login_id)";
                    try
                    {
                        conn.Open();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    command.ExecuteNonQuery();


                    MessageBox.Show("successfully project created");

                    this.Close();
                    Login_form login_frm = new Login_form();
                    login_frm.Show();
                    MessageBox.Show("Successfully submited");
                }
            }
            
        }

        #endregion
    }
}
