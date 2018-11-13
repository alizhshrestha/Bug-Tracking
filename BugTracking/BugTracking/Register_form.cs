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
        #region Constructor
        public Register_form()
        {
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
            lbl_validate.Hide();
            lbl_validate.ForeColor = Color.Red;
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
            if (validateUserInfo(txt_first_name, "FIRST NAME", lbl_validate) == true)
            {
                if (validateUserInfo(txt_last_name, "LAST NAME", lbl_validate) == true)
                {
                    if (validateUserInfo(txt_address, "ADDRESS", lbl_validate) == true)
                    {
                        if (validateUserloginInfo(txt_username, "Username", lbl_validate) == true)
                        {
                            if (validateUserloginInfo(txt_password, "Password", lbl_validate) == true)
                            {
                                MessageBox.Show("YOU HAVE BEEN SUCCESSFULLY REGISTERED");
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

        #region Validation methods

        /// <summary>
        /// validates common user info
        /// </summary>
        /// <param name="txt"></param>
        /// <param name="label"></param>
        /// <returns></returns>
        private bool validateUserInfo(TextBox txt, String label, Label lbl_validate)
        {
            string value = txt.Text;
            if (string.IsNullOrWhiteSpace(value) || value.Any(Char.IsDigit))
            {
                lbl_validate.Text = "PLEASE ENTER VALID "+label;
                lbl_validate.Show();
                txt.Select();
                return false;
            }
            return true;
        }

        /// <summary>
        /// validates login credential info
        /// </summary>
        /// <param name="txt"></param>
        /// <param name="label"></param>
        /// <returns></returns>
        private bool validateUserloginInfo(TextBox txt, String label, Label lbl_validate)
        {
            string value = txt.Text;
            if (string.IsNullOrWhiteSpace(value))
            {
                lbl_validate.Text = "PLEASE ENTER VALID " + label;
                lbl_validate.Show();
                txt.Select();
                return false;
            }
            return true;
        }

        #endregion
    }
}
