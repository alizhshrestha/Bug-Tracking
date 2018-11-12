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


namespace BugTracking
{
    public partial class Form1 : Form
    {
        //SqlConnection mySqlConnection;
        MySqlConnection con = new MySqlConnection(@"Data Source=localhost;port=3306;Initial Catalog=bug_tracking; User Id=root; password=''");
        int i;
        public Form1()
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            i = 0;

            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from login where username='"+txt_username.Text+"' and password='"+txt_password.Text+"'";
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
                this.Hide();
                Main main = new Main();
                main.Show();
            }

            con.Close();

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
