﻿using BugTracking.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BugTracking.Controller
{
    class BugController
    {

        public static void insertBugToDatabase(Bug b)
        {
            try
            {
                byte[] Image;
                FileStream fileStream = new FileStream(b.getScreenShot(), FileMode.Open, FileAccess.Read);
                BinaryReader bReader = new BinaryReader(fileStream);
                Image = bReader.ReadBytes((int)fileStream.Length);

                MessageBox.Show(b.getReportedBy());
                string query = "insert into bug(id, bug_title, source_file, class, method_line, code_line, project_id, reported_by, source_code, screenshot, reported_at) " +
                    "values(NULL, '" + b.getBugTitle() + "','" + b.getSourceFile() + "','" + b.getClassName() + "','" + b.getMethodLine() + "','" + b.getCodeLine() + "'," +
                    "'" + b.getProjectId() + "','" + b.getReportedBy() + "','" + b.getSourceCode() + "',@screenshot,'"+b.getReportedAt()+"')";
                DatabaseController.insertDataToForm(query, Image);

                bReader.Close();
                fileStream.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

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
