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
        public Register_form()
        {
            InitializeComponent();
        }

        private void cmb_sex_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Register_form_Load(object sender, EventArgs e)
        {
            lbl_validate.Hide();
            lbl_validate.ForeColor = Color.Red;
            cmb_sex.DropDownHeight = 50;
            setComboSexItems();
            setComboRoleItems();
        }

        public void setComboSexItems()
        {
            cmb_sex.Items.Add("Male");
            cmb_sex.Items.Add("Female");
            cmb_sex.Items.Add("Others");
            cmb_sex.Text = "Male";
        }

        public void setComboRoleItems()
        {
            cmb_role.Items.Add("Programmer");
            cmb_role.Items.Add("Developer");
            cmb_role.Items.Add("Tester");
            cmb_role.Text = "Programmer";
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //Login_form login_frm = new Login_form();
            //login_frm.Show();
            if (validateUserInfo(txt_first_name, "FIRST NAME") == true)
            {
                if (validateUserInfo(txt_last_name, "LAST NAME") == true)
                {
                    if (validateUserInfo(txt_address, "ADDRESS") == true)
                    {
                        if (validateUserloginInfo(txt_username, "Username") == true)
                        {
                            if (validateUserloginInfo(txt_password, "Password") == true)
                            {
                                MessageBox.Show("OK");
                            }
                        }
                    }
                }
            }
        }


        private bool validateUserInfo(TextBox txt, String label)
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

        private bool validateUserloginInfo(TextBox txt, String label)
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
    }
}
