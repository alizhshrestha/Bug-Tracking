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

using MaterialSkin;
using MaterialSkin.Controls;
using System.IO;

namespace BugTracking.View
{
    public partial class Bug_list : MaterialForm
    {
        string project_name, bug_title, source_file, class_name, method_line, code_line, fix_status, resolved_code, source_code, reported_by;
        string username;
        int project_id, bug_id;
        Image screenshot;

        private void btn_update_fix_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_fix_Click_1(object sender, EventArgs e)
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
            Fix_report fix_report = new Fix_report(bug_title, source_file, class_name, method_line, code_line, project_id, bug_id, resolved_code, this.username);
            fix_report.ShowDialog();
        }

        private void btn_update_Click_1(object sender, EventArgs e)
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
            Bug_report bug_report = new Bug_report(bug_title, source_file, class_name, method_line, code_line, project_id, bug_id, true, this.username, this.source_code);
            bug_report.ShowDialog();
        }

        private void btn_update_fix_Click_1(object sender, EventArgs e)
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
            Fix_report fix_report = new Fix_report(bug_title, source_file, class_name, method_line, code_line, project_id, bug_id, this.resolved_code, this.username);
            fix_report.ShowDialog();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            
        }

        public Bug_list(string username)
        {
            MaterialSkin();
            this.username = username;
            InitializeComponent();
        }

        public Bug_list()
        {
            MaterialSkin();
            InitializeComponent();
        }

        public void MaterialSkin()
        {
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



        private void Bug_list_Load(object sender, EventArgs e)
        {
            loadData.loadUserData("select id, bug_title, source_file, class, method_line, code_line, project_id, fixed, reported_by, source_code from bug where reported_by = '"+this.username+"';", dataGridView1);
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
                    reported_by = row.Cells[8].Value.ToString();
                    source_code = row.Cells[9].Value.ToString();
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
