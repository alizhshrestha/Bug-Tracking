using BugTracking.Controller;
using BugTracking.Model;
using System;
using System.Windows.Forms;

namespace BugTracking
{
    public partial class User_list : Form
    {
        //declaring the variables
        int user_id;
        string first_name, last_name, address, sex, username, password, role;
        Boolean updateFlag;

        //event on delete button
        private void btn_delete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Delete Id: "+ Convert.ToInt32(this.user_id));
            User user = new User(this.user_id); //creating object for user
            UserController.deleteUserToDatabase(user); //method to delete user from the database
            MessageBox.Show("Delete Successfully");
        }

        //constructor for the user class
        public User_list()
        {
            InitializeComponent();
        }

        //loading userlist in data grid view
        private void User_list_Load(object sender, EventArgs e)
        {
            loadData.loadUserData("select * from user;", dataGridView1);

            User_list user_list = new User_list();
            dataGridView1.Columns["first_name"].ReadOnly = true;
            dataGridView1.Columns["last_name"].ReadOnly = true;
            dataGridView1.Columns["address"].ReadOnly = true;
            dataGridView1.Columns["sex"].ReadOnly = true;
            dataGridView1.Columns["username"].ReadOnly = true;
            dataGridView1.Columns["password"].ReadOnly = true;
            dataGridView1.Columns["role"].ReadOnly = true;
            
            Console.ReadLine();
        }

        //edit button action
        private void bnt_edit_Click(object sender, EventArgs e)
        {
            this.updateFlag = true;
            this.Hide();

            //creating object for register form
            Register_form register_form = new Register_form(user_id, first_name, last_name, address, sex, username, password, role, updateFlag);
            register_form.ShowDialog();
        }

        //selection change method whenever pointer is changed.
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            //looping datagridviewrow
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                try
                {
                    //assigning the values from selection index.
                    user_id = Convert.ToInt32(row.Cells[0].Value);
                    first_name = row.Cells[1].Value.ToString();
                    last_name = row.Cells[2].Value.ToString();
                    address = row.Cells[3].Value.ToString();
                    sex = row.Cells[4].Value.ToString();
                    username = row.Cells[5].Value.ToString();
                    password = row.Cells[6].Value.ToString();
                    role = row.Cells[7].Value.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }

            }
        }
    }
}
