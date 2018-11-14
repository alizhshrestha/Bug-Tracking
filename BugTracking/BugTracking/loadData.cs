using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BugTracking
{
    class loadData
    {

        public static void loadUserData(String query, DataGridView dataGridView)
        {
            string connString = @"Data Source=localhost;port=3306;Initial Catalog=bug_tracking; User Id=root; password=''";
            MySqlConnection conDataBase = new MySqlConnection(connString);
            MySqlCommand cmdDataBase = new MySqlCommand(query, conDataBase);

            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                dataGridView.DataSource = bSource;
                sda.Update(dbdataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
