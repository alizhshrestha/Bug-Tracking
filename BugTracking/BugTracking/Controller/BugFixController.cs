﻿using BugTracking.Model;
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
            //string query2 = "INSERT INTO `bug_fix` (`id`, `fixer_name`, `fixed_code`, `bug_id`,`reported_by`) VALUES(NULL, '"+bf.getFixerName()+"', '"+bf.getFixedCode()+"', '"+bf.getBugId()+ "' , '" + bf.getReportedBy() + "'); ";
            string query = "INSERT INTO `bug_fix` (`id`, `fixer_name`, `fixed_code`, `bug_id`, `reported_by`, `bug_title`, `source_file`, `class_name`, `method_line`, `code_line`, `source_code`) " +
                "VALUES(NULL,'" + bf.getFixerName() + "','" + bf.getFixedCode() + "', '" + bf.getBugId() + "', '" + bf.getReportedBy() + "', '" + bf.getBugTitle() + "','" + bf.getSourceFile() + "', '" + bf.getClassName() + "', " +
                "'" + bf.getMethodLine() + "', '" + bf.getCodeLine() + "','" + bf.getSourceCode() + "');";
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
