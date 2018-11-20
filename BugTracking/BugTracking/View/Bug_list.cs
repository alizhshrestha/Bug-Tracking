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
        string project_name, bug_title, source_file, class_name, method_line, code_line, fix_status, resolved_code;
        int project_id, bug_id;

        private void btn_update_fix_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = DbConnection.connectToDb();
            conn.Open();
            using (conn)
            {
                MySqlCommand command = new MySqlCommand("select id from bug where bug_title = '" + this.bug_title + "'", conn);
                MySqlDataReader reader = command.ExecuteReader();
                using (reader)
                {
                    while (reader.Read())
                    {
                        int id = (int)reader["id"];
                        this.bug_id = id;

                    }
                }
            }
            conn.Close();

            conn.Open();
            using (conn)
            {
                MySqlCommand command = new MySqlCommand("select fixed_code from bug_fix where bug_id = '" + this.bug_id + "'", conn);
                MySqlDataReader reader = command.ExecuteReader();
                using (reader)
                {
                    while (reader.Read())
                    {
                        string fixed_code = (string)reader["fixed_code"];
                        
                        this.resolved_code = fixed_code;

                    }
                }
            }
            conn.Close();
            this.Hide();
            MessageBox.Show(this.resolved_code);
            Fix_report fix_report = new Fix_report(bug_title, source_file, class_name, method_line, code_line, project_id, bug_id, this.resolved_code);
            fix_report.ShowDialog();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = DbConnection.connectToDb();
            conn.Open();
            using (conn)
            {
                MySqlCommand command = new MySqlCommand("select id from bug where bug_title = '" + this.bug_title + "'", conn);
                MySqlDataReader reader = command.ExecuteReader();
                using (reader)
                {
                    while (reader.Read())
                    {
                        int id = (int)reader["id"];
                        this.bug_id = id;
                        
                    }
                }
            }
            conn.Close();

            this.Close();
            Bug_report bug_report = new Bug_report(bug_title, source_file, class_name, method_line, code_line, project_id, bug_id, true);
            bug_report.ShowDialog();
        }

        public Bug_list()
        {
            InitializeComponent();
        }

        private void Bug_list_Load(object sender, EventArgs e)
        {
            loadData.loadUserData("select * from bug;", dataGridView1);
            dataGridView1.Columns["fixed"].ReadOnly = true;
            dataGridView1.Columns["bug_title"].ReadOnly = true;
            dataGridView1.Columns["source_file"].ReadOnly = true;
            //dataGridView1.Columns["class_name"].ReadOnly = true;
            dataGridView1.Columns["method_line"].ReadOnly = true;
            dataGridView1.Columns["code_line"].ReadOnly = true;
            dataGridView1.Columns["project_id"].ReadOnly = true;
            //dataGridView1.Columns["fix_status"].ReadOnly = true;
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
                    fix_status = row.Cells[7].Value.ToString();
                    if (Convert.ToBoolean(fix_status)==false)
                    {
                        btn_fix.Show();
                        btn_update.Show();
                        btn_update_fix.Hide();
                    }
                    else
                    {
                        btn_fix.Hide();
                        btn_update.Hide();
                        btn_update_fix.Show();
                    }



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
                
            }
        }
    }
}
