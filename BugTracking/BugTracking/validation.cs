using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BugTracking
{
    class validation
    {
        #region Validation methods

        /// <summary>
        /// validates common user info
        /// </summary>
        /// <param name="txt"></param>
        /// <param name="label"></param>
        /// <returns></returns>
        public bool validateUserInfo(TextBox txt, String label, Label lbl_validate)
        {
            lbl_validate.Hide();
            lbl_validate.ForeColor = Color.Red;

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

        /// <summary>
        /// validates login credential info
        /// </summary>
        /// <param name="txt"></param>
        /// <param name="label"></param>
        /// <returns></returns>
        public bool validateUserloginInfo(TextBox txt, String label, Label lbl_validate)
        {
            string value = txt.Text;
            if (string.IsNullOrWhiteSpace(value))
            {
                lbl_validate.Text = "PLEASE ENTER VALID " + label;
                lbl_validate.Show();
                txt.Select();
                return false;
            }
            return true;
        }

        #endregion

    }
}
