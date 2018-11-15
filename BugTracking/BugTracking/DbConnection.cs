using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracking
{
    class DbConnection
    { 

        public static MySqlConnection connectToDb()
        {
            string connString = "Data Source=localhost;port=3306;Initial Catalog=bug_tracking; User Id=root; password=''";
            MySqlConnection conn = new MySqlConnection(connString);
            return conn;
        }

    }
}
