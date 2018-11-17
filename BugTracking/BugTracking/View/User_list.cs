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
    public partial class User_list : Form
    {
        int user_id;
        string first_name, last_name, address, sex, username, password, role;
        Boolean updateFlag;

        public User_list()
        {
            InitializeComponent();
        }

        private void User_list_Load(object sender, EventArgs e)
        {
            loadData.loadUserData("select * from user;", dataGridView1);
            User_list user_list = new User_list();
            Console.ReadLine();
        }

        private void bnt_edit_Click(object sender, EventArgs e)
        {
            this.updateFlag = true;
            this.Close();
            Register_form register_form = new Register_form(user_id, first_name, last_name, address, sex, username, password, role, updateFlag);
            register_form.Show();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                try
                {
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
