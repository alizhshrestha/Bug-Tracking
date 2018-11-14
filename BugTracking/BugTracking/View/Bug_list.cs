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
        public Bug_list()
        {
            InitializeComponent();
        }

        private void Bug_list_Load(object sender, EventArgs e)
        {
            loadData.loadUserData("select * from bug;", dataGridView1);
        }
    }
}
