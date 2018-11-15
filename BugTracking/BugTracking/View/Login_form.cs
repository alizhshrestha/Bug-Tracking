using BugTracking.View;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//libgit2sharp


namespace BugTracking
{
    public partial class Login_form : Form
    {
        int login_id;

        //location of the mysqlconnection linked
        MySqlConnection con = new MySqlConnection(@"Data Source=localhost;port=3306;Initial Catalog=bug_tracking; User Id=root; password=''");
        int i;//variable defined

        #region constructor
        public Login_form()
        {
            InitializeComponent();
            /*
            String[] myData = new string[100];
            

            mySqlConnection = new SqlConnection("server=Localhost;user id=root;database=bug_tracking");

            String selcmd = "SELECT USERNAME FROM LOGIN";

            SqlCommand mySqlCommand = new SqlCommand(selcmd, mySqlConnection);

            mySqlConnection.Open();

            SqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();

            int i = 0;
            while (mySqlDataReader.Read())
            {
                Console.WriteLine(mySqlDataReader["USERNAME"]); //reads a line of the query result at a time
                myData[i++] = (String)mySqlDataReader["name"]; // store in an array too for use later

            }

            for(int j = 0; j<1; j++)
            {
                Console.WriteLine("Your username is: " + myData[j]);
            }
            */
        }
        #endregion  

        private void label2_Click(object sender, EventArgs e)
        {

        }

        #region Button Login click event
        private void btn_login_Click(object sender, EventArgs e)
        {

            i = 0;

            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from User where username='"+txt_username.Text+"' and password='"+txt_password.Text+"'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            i = Convert.ToInt32(dt.Rows.Count.ToString());

            if (i==0)
            {
                lbl_invalid.Text = "you have entered invalid username and password";
            }
            else
            {
                con.Close();

                con.Open();
                using (con)
                {
                    MySqlCommand command = new MySqlCommand("select id from user where username = '" + txt_username.Text + "'", con);
                    MySqlDataReader reader = command.ExecuteReader();
                    using (reader)
                    {
                        while (reader.Read())
                        {
                            int id = (int)reader["id"];
                            login_id = id;
                        }
                    }

                }
                con.Close();


                this.Hide();
                Dashboard dashboard = new Dashboard(this.login_id);
                dashboard.Show();
                //Fix_report fix_report = new Fix_report();
                //fix_report.Show();
                //Project project = new Project();
                //project.Show();
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
