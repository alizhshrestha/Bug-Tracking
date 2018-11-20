using BugTracking.Controller;
using BugTracking.Model;
using System;
using System.Windows.Forms;

namespace BugTracking
{
    public partial class Register_form : Form
    {
        Validation validation; //declares validation

        //declares variable name
        string first_name, last_name, address, sex, username, password, role; 
        int user_id; 
        Boolean updateFlag;

        //button click event
        private void btn_update_Click(object sender, EventArgs e)
        {
            //Assign value to variable
            int user_id = this.user_id;
            String fname = txt_first_name.Text;
            String lname = txt_last_name.Text;
            String address = txt_address.Text;
            String sex = cmb_sex.Text;
            String username = txt_username.Text;
            String password = txt_password.Text;
            String role = cmb_role.Text;

            //declares and call parameterised constructor
            User user = new User(user_id, fname, lname, address, sex, username, password, role);
            UserController.updateUserToDatabase(user);//updates user to database
            MessageBox.Show("Updated successfully!!");
            this.Hide();
            User_list user_list = new User_list();
            user_list.ShowDialog();
            //conn.Close();
        }

        #region Constructor
        public Register_form()
        {
            validation = new Validation();//object creation

            InitializeComponent();
        }

        public Register_form(int user_id, string first_name, string last_name, string address, string sex, string username, string password, string role, Boolean updateFlag)
        {
            //btn_update.Show();
            //sets local variables value
            this.user_id = user_id;
            this.first_name = first_name;
            this.last_name = last_name;
            this.address = address;
            this.sex = sex;
            this.username = username;
            this.password = password;
            this.role = role;
            this.updateFlag = updateFlag;

            validation = new Validation();//object creation

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
            //condition to see if data is to be updated or not
            if (updateFlag==true)
            {
                this.btn_submit.Hide();
                this.btn_update.Show();
            }
            else
            {
                this.btn_update.Hide();
                this.btn_submit.Show();
            }

            //sets combo-box items
            cmb_sex.DropDownHeight = 50;
            setComboSexItems();
            setComboRoleItems();

            //sets value to text-box
            txt_first_name.Text = this.first_name;
            txt_last_name.Text = this.last_name;
            txt_address.Text = this.address;
            cmb_sex.Text = this.sex;
            txt_username.Text = this.username;
            txt_password.Text = this.password;
            cmb_role.Text = this.role;
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
            cmb_role.Items.Add("Admin");
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
                                //setting local variable value
                                String fname = txt_first_name.Text;
                                String lname = txt_last_name.Text;
                                String address = txt_address.Text;
                                String sex = cmb_sex.Text;
                                String username = txt_username.Text;
                                String password = txt_password.Text;
                                String role = cmb_role.Text;

                                //object creation
                                User user = new User(fname,lname,address,sex,username,password,role);

                                //inserting to user controller
                                UserController.insertUserToDatabase(user);

                                MessageBox.Show("successfully registered");
                            }
                        }
                    }
                }
            }
        }
        #endregion


    }
}
