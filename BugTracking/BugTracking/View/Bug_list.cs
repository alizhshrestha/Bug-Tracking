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

namespace BugTracking.View
{
    public partial class Bug_list : Form
    {
        string bug_title, source_file, class_name, method_line, code_line;
        int project_id, bug_id;

        public Bug_list()
        {
            InitializeComponent();
        }

        private void Bug_list_Load(object sender, EventArgs e)
        {
            loadData.loadUserData("select * from bug;", dataGridView1);
        }

        private void btn_fix_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = DbConnection.connectToDb();
            conn.Open();
            using (conn)
            {
                MySqlCommand command = new MySqlCommand("select id from bug where bug_title = '"+this.bug_title+"'", conn);
                MySqlDataReader reader = command.ExecuteReader();
                using (reader)
                {
                    while (reader.Read())
                    {
                        int id = (int)reader["id"];
                        this.bug_id = id;
                        MessageBox.Show(Convert.ToString(this.bug_id));
                    }
                }
            }
            conn.Close();

            this.Close();
            Fix_report fix_report = new Fix_report(bug_title, source_file, class_name, method_line, code_line, project_id,bug_id);
            fix_report.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                try
                {
                    bug_title = row.Cells[1].Value.ToString();
                    source_file = row.Cells[2].Value.ToString();
                    class_name = row.Cells[3].Value.ToString();
                    method_line = row.Cells[4].Value.ToString();
                    code_line = row.Cells[5].Value.ToString();
                    project_id = (int)row.Cells[6].Value;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
                
            }
        }
    }
}
