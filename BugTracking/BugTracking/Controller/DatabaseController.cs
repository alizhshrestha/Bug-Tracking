using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BugTracking.Controller
{
    class DatabaseController
    {
        public static MySqlConnection connectToDb()
        {
            string connString = "Data Source=localhost;port=3306;Initial Catalog=bug_tracking; User Id=root; password=''";
            MySqlConnection conn = new MySqlConnection(connString);
            return conn;
        }

        public static void insertDataToForm(string query)
        {
            MySqlConnection conn = connectToDb();
            MySqlCommand cmd = new MySqlCommand(query,conn);

            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Console.WriteLine(query);
            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public static void updateDataToForm(string query)
        {
            MySqlConnection conn = connectToDb();
            MySqlCommand cmd = new MySqlCommand(query, conn);

            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Console.WriteLine(query);
            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public static void deleteDataToForm(string query)
        {
            MySqlConnection conn = connectToDb();
            MySqlCommand cmd = new MySqlCommand(query, conn);

            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            cmd.ExecuteNonQuery();
            MessageBox.Show("Successfully deleted!!");

            conn.Close();
        }
    }
}
