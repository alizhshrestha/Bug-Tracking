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
                                MessageBox.Show("YOU HAVE BEEN SUCCESSFULLY REGISTERED");
                                this.Close();
                                Bug_report bug_report = new Bug_report();
                                bug_report.Show();
                                //Login_form login_frm = new Login_form();
                                //login_frm.Show();
                            }
                        }
                    }
                }
            }
        }
        #endregion

        
    }
}
