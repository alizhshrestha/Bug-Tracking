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
    public partial class Bug_report : Form
    {
        Validation validate;//defined validation class
        #region constructor
        public Bug_report()
        {
            InitializeComponent();
            validate = new Validation();//initialized validation class
        }
        #endregion

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Bug_report_Load(object sender, EventArgs e)
        {

        }

        #region Button Update click event
        private void btn_update_Click(object sender, EventArgs e)
        {
            if (validate.validateUserInfo(txt_project_name, "PROJECT NAME", lbl_validate) == true)
            {
                if (validate.validateUserInfo(txt_bug_title, "BUG TITLE", lbl_validate) == true)
                {
                    if (validate.validateUserInfo(txt_arthur, "ARTHUR NAME", lbl_validate) == true)
                    {
                        if (validate.validateUserInfo(txt_source_file, "SOURCE FILE", lbl_validate) == true)
                        {
                            if (validate.validateUserInfo(txt_class_name, "CLASS NAME", lbl_validate) == true)
                            {
                                if (validate.validateUserInfo(txt_method_line, "METHOD LINE", lbl_validate) == true)
                                {
                                    if (validate.validateUserInfo(txt_code_line, "CODE LINE", lbl_validate) == true)
                                    {
                                        MessageBox.Show("OK");
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        #endregion
    }
}
