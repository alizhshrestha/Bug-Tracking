using BugTracking.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracking.Controller
{
    class BugFixController
    {
        public static void insertBugFixToDatabase(Bug_fix bf)
        {
            string query = "INSERT INTO `bug_fix` (`id`, `fixer_name`, `fixed_code`, `bug_id`) VALUES(NULL, '"+bf.getFixerName()+"', '"+bf.getFixedCode()+"', '"+bf.getBugId()+"'); "; 
            DatabaseController.insertDataToForm(query);
        }

        public static void UpdateBugFixToDatabase(Bug_fix bf)
        {
            string query = "UPDATE `bug_fix` SET `fixer_name` = '"+bf.getFixerName()+"' WHERE `bug_fix`.`id` = "+bf.getBugId();
            DatabaseController.updateDataToForm(query);

        }

        public static void DeleteBugFixToDatabase(Bug_fix bf)
        {
            string query = "delete from bug_fix where id = '"+bf.getId()+"'";
            DatabaseController.deleteDataToForm(query);
        }
    }
}
