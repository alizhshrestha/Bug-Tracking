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
    public partial class Fix_report : Form
    {
        Validation validate; //declares validation class

        #region Constructor
        public Fix_report()
        {
            InitializeComponent();
            validate = new Validation();
        }
        #endregion


        #region Form Load
        private void Fix_report_Load(object sender, EventArgs e)
        {
            cmb_role.Items.Add("Programmer");
            cmb_role.Items.Add("Tester");
            cmb_role.Items.Add("Developer");
            cmb_role.Text = "Programmer";
        }
        #endregion

        #region Button Update Click event
        private void btn_update_Click(object sender, EventArgs e)
        {
            //validates fix report information
            if (validate.validateUserInfo(txt_project_name, "PROJECT NAME", lbl_validate) == true)
            {
                if (validate.validateUserInfo(txt_bug, "BUG TITLE", lbl_validate) == true)
                {
                    if (validate.validateUserInfo(txt_source_file, "SOURCE FILE", lbl_validate) == true)
                    {
                        if (validate.validateUserInfo(txt_class_name, "CLASS NAME", lbl_validate) == true)
                        {
                            if (validate.validateUserInfo(txt_code_line, "CODE LINE", lbl_validate) == true)
                            {
                                if (validate.validateUserInfo(txt_method_line, "METHOD LINE", lbl_validate) == true)
                                {
                                    if (validate.validateUserInfo(txt_fixer, "FIXER NAME", lbl_validate) == true)
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
