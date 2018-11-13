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
        Validation validation;//defined validation class

        #region constructor
        public Project()
        {
            validation = new Validation();//initialized validation class
            InitializeComponent();
        }
        #endregion

        private void Project_Load(object sender, EventArgs e)
        {

        }

        #region button submit event
        private void btn_submit_Click(object sender, EventArgs e)
        {
            //Validates if information is correct or not
            if (validation.validateUserInfo(txt_project_name, "PROJECT NAME", lbl_validate)==true)
            {
                if (validation.validateUserInfo(txt_arthur, "ARTHUR NAME", lbl_validate) == true)
                {
                    MessageBox.Show("Successfully submited");
                }
            }
            
        }

        #endregion
    }
}
