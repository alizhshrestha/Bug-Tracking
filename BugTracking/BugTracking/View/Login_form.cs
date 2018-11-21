using BugTracking.View;
using BugTracking.View.Dashboard;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

// Import the Material Skin
using MaterialSkin;
using MaterialSkin.Controls;
//libgit2sharp


namespace BugTracking
{

    //creating class
    public partial class Login_form : MaterialForm
    {
        //declaring variables.
        int login_id;
        string role, first_name, username;

        //location of the mysqlconnection linked
        MySqlConnection con = new MySqlConnection(@"Data Source=localhost;port=3306;Initial Catalog=bug_tracking; User Id=root; password=''");
        int i;//variable defined

        #region constructor
        public Login_form()
        {
            InitializeComponent();
            // Create a material theme manager and add the form to manage (this)
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE
            );
        }
        #endregion  

        private void label2_Click(object sender, EventArgs e)
        {

        }

        #region Button Login click event
        private void btn_login_Click(object sender, EventArgs e)
        {
            
        }

        private void btnlop_login_Click(object sender, EventArgs e)
        {
            this.username = txt_username.Text;
            i = 0;

            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from User where username='" + txt_username.Text + "' and password='" + txt_password.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            i = Convert.ToInt32(dt.Rows.Count.ToString());

            if (i == 0)
            {
                lbl_invalid.Text = "!!Please input correct username and password!!";
                con.Close();
            }
            else
            {
                using (con)
                {
                    MySqlCommand command = new MySqlCommand("select first_name, role, id from user where username = '" + txt_username.Text + "'", con);
                    MySqlDataReader reader = command.ExecuteReader();
                    using (reader)
                    {
                        while (reader.Read())
                        {
                            string role = Convert.ToString(reader["role"]);
                            string first_name = (string)reader["first_name"];
                            int id = (int)reader["id"];
                            login_id = id;
                            this.first_name = first_name;
                            this.role = role;
                        }
                    }

                }
                if (this.role == "Admin")
                {
                    this.Hide();
                    Admin_dashboard admin_dashboard = new Admin_dashboard(this.login_id);
                    admin_dashboard.Show();
                }
                else
                {
                    this.Hide();
                    User_dashboard user_dashboard = new User_dashboard(this.login_id, this.first_name, this.username);
                    user_dashboard.Show();
                }
                con.Close();
            }




        }
        #endregion

        #region Button register click
        private void btn_register_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register_form register_form = new Register_form();
            register_form.Show();
        }
        #endregion

        private void Login_form_Load(object sender, EventArgs e)
        {

        }
    }
}
