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

        public Form1()
        {
            /*InitializeComponent();
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

            Main main = new Main();
            main.Show();
            this.Hide();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
