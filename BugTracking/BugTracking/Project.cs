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
    public partial class Project : Form
    {
        public Project()
        {
            InitializeComponent();
        }

        private void Project_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// validates common user info
        /// </summary>
        /// <param name="txt"></param>
        /// <param name="label"></param>
        /// <returns></returns>
        private bool validateProjectInfo(TextBox txt, String label, Label lbl_validate)
        {
            string value = txt.Text;
            if (string.IsNullOrWhiteSpace(value) || value.Any(Char.IsDigit))
            {
                lbl_validate.Text = "PLEASE ENTER VALID " + label;
                lbl_validate.Show();
                txt.Select();
                return false;
            }
            return true;
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            if (validateProjectInfo(txt_project_name, "PROJECT NAME", lbl_validate)==true)
            {
                if (validateProjectInfo(txt_arthur, "ARTHUR NAME", lbl_validate) == true)
                {
                    MessageBox.Show("Successfully submited");
                }
            }
            
        }
    }
}
