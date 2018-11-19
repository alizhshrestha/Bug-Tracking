using BugTracking.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracking.Controller
{
    class BugController
    {
        public static void insertBugToDatabase(Bug b)
        {
            string query = "insert into bug(id, bug_title, source_file, class, method_line, code_line, project_id) " +
                "values(NULL, '" + b.getBugTitle() + "','" + b.getSourceFile() + "','" + b.getClassName() + "','" + b.getMethodLine() + "','"+b.getCodeLine()+ "','" + b.getProjectId() + "')";
            //Console.WriteLine(query);
            DatabaseController.insertDataToForm(query);
        }

        public static void UpdateBugToDatabase(Bug b)
        {
            string query = "UPDATE `bug` SET `bug_title` = '"+b.getBugTitle()+"', `source_file` = '"+b.getSourceFile()+"', `class` = '"+b.getClassName()+"', `method_line` = '"+b.getMethodLine()+"', `code_line` = '"+b.getCodeLine()+"' WHERE `bug`.`id` = "+b.getId();
            DatabaseController.insertDataToForm(query);

        }

        public static void DeleteBugToDatabase(Bug b)
        {
            string query = "delete from bug where id = '"+b.getId()+"'";
            DatabaseController.insertDataToForm(query);
        }
        
    }
}
