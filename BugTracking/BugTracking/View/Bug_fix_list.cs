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
    public partial class Bug_fix_list : Form
    {
        public Bug_fix_list()
        {
            InitializeComponent();
        }

        private void Bug_fix_list_Load(object sender, EventArgs e)
        {
            loadData.loadUserData("select * from bug_fix;", dataGridView1);
            dataGridView1.Columns["fixer_name"].ReadOnly = true;
            dataGridView1.Columns["fixed_code"].ReadOnly = true;
            dataGridView1.Columns["bug_id"].ReadOnly = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
