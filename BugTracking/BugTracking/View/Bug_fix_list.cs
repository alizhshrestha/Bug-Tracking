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


namespace BugTracking.View
{
    public partial class Bug_fix_list : MaterialForm
    {
        string username;
        public Bug_fix_list()
        {
            InitializeComponent();
        }

        public Bug_fix_list(string username)
        {
            MaterialSkin();
            this.username = username;
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



        private void Bug_fix_list_Load(object sender, EventArgs e)
        {
            loadData.loadUserData("select * from bug_fix where reported_by = '"+this.username+"';", dataGridView1);
            dataGridView1.Columns["fixer_name"].ReadOnly = true;
            dataGridView1.Columns["fixed_code"].ReadOnly = true;
            dataGridView1.Columns["bug_id"].ReadOnly = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
