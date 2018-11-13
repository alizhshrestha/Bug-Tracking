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
    public partial class Register_form : Form
    {
        Validation validation;

        #region Constructor
        public Register_form()
        {
            validation = new Validation();

            InitializeComponent();
        }
        #endregion

        #region selected Index change event
        private void cmb_sex_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        #endregion

        #region Form load
        /// <summary>
        /// When form starts to open
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Register_form_Load(object sender, EventArgs e)
        {
            cmb_sex.DropDownHeight = 50;
            setComboSexItems();
            setComboRoleItems();
        }
        #endregion

        #region Sets items to combobox

        /// <summary>
        /// sets items to sex combo-box
        /// </summary>
        public void setComboSexItems()
        {
            cmb_sex.Items.Add("Male");
            cmb_sex.Items.Add("Female");
            cmb_sex.Items.Add("Others");
            cmb_sex.Text = "Male";
        }

        /// <summary>
        /// sets items to role combo-box
        /// </summary>
        public void setComboRoleItems()
        {
            cmb_role.Items.Add("Programmer");
            cmb_role.Items.Add("Developer");
            cmb_role.Items.Add("Tester");
            cmb_role.Text = "Programmer";
        }

        #endregion


        #region Button click event
        /// <summary>
        /// click event of btn_submit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_submit_Click(object sender, EventArgs e)
        {
            
            ///sequentially validates forms if there is improper value or textbox is blank
            if (validation.validateUserInfo(txt_first_name, "FIRST NAME", lbl_validate) == true)
            {
                if (validation.validateUserInfo(txt_last_name, "LAST NAME", lbl_validate) == true)
                {
                    if (validation.validateUserInfo(txt_address, "ADDRESS", lbl_validate) == true)
                    {
                        if (validation.validateUserloginInfo(txt_username, "Username", lbl_validate) == true)
                        {
                            if (validation.validateUserloginInfo(txt_password, "Password", lbl_validate) == true)
                            {
                                //data connection and data transfer
                                string connString = "Data Source=localhost;port=3306;Initial Catalog=bug_tracking; User Id=root; password=''";
                                MySqlConnection conn = new MySqlConnection(connString);
                                MySqlCommand command = conn.CreateCommand();
                                command.CommandText = "insert into register (first_name, last_name, sex, address, username, password, role) values('" + txt_first_name.Text + "','" + txt_last_name.Text + "','" + cmb_sex.Text + "'," +
                                    "'" + txt_address.Text + "','" + txt_username.Text + "','" + txt_password.Text + "','" + cmb_role.Text + "');insert into login (username, password) values('" + txt_username.Text + "','" + txt_password.Text + "')";

                                try
                                {
                                    conn.Open();
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message);
                                }

                                command.ExecuteNonQuery();


                                MessageBox.Show("successfully registered");

                                this.Close();
                                Login_form login_frm = new Login_form();
                                login_frm.Show();
                            }
                        }
                    }
                }
            }
        }
        #endregion


    }
}
