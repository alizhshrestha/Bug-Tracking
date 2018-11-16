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
    public partial class List_of_project : Form
    {
        public List_of_project()
        {
            InitializeComponent();
        }

        private void List_of_project_Load(object sender, EventArgs e)
        {
            loadData.loadUserData("select * from project;", data_view_project_list);
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            
        }
    }
}
