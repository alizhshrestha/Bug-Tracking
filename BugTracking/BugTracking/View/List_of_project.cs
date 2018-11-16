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
        int project_id, user_id;
        string project_name, start_date, end_date, arthur;
        Boolean updateFlag;

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
            this.updateFlag = true;
            this.Close();
            Project project = new Project(project_id, project_name, start_date, end_date, arthur, user_id, updateFlag);
            MessageBox.Show(Convert.ToString(project_id));
            project.ShowDialog();
        }

        private void data_view_project_list_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in data_view_project_list.SelectedRows)
            {
                try
                {
                    this.project_id = Convert.ToInt32(row.Cells[0].Value);
                    this.project_name = row.Cells[1].Value.ToString();
                    this.start_date = row.Cells[2].Value.ToString();
                    this.end_date = row.Cells[3].Value.ToString();
                    this.arthur = row.Cells[4].Value.ToString();
                    this.user_id = Convert.ToInt32(row.Cells[5].Value);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
