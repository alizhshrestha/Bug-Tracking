using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracking.Model
{
    class Bug
    {
        int id, project_id;
        string bug_title, source_file, class_name, method_line, code_line, reported_by, source_code;
        string screenshotfile;
        bool fix;

        public Bug(string bug_title, string source_file, string class_name, string method_line, string code_line, 
            int project_id, string reported_by, bool fix)
        {
            this.bug_title = bug_title;
            this.source_file = source_file;
            this.class_name = class_name;
            this.method_line = method_line;
            this.code_line = code_line;
            this.project_id = project_id;
            this.reported_by = reported_by;
            this.fix = fix;

        }

        public Bug()
        {
            
        }

        public Bug(string bug_title, string source_file, string class_name, string method_line, string code_line, int project_id)
        {
            this.bug_title = bug_title;
            this.source_file = source_file;
            this.class_name = class_name;
            this.method_line = method_line;
            this.code_line = code_line;
            this.project_id = project_id;
        }


        public Bug(string bug_title, string source_file, string class_name, string method_line, 
            string code_line, string reported_by, int project_id, string source_code, string screenshotfile)
        {

            this.bug_title = bug_title;
            this.source_file = source_file;
            this.class_name = class_name;
            this.method_line = method_line;
            this.code_line = code_line;
            this.reported_by = reported_by;
            this.project_id = project_id;
            this.source_code = source_code;
            this.screenshotfile = screenshotfile;

        }

        public void setId(int id)
        {
            this.id = id;
        }

        public int getId()
        {
            return this.id;
        }

        public void setProjectId(int project_id)
        {
            this.project_id = project_id;
        }

        public int getProjectId()
        {
            return this.project_id;
        }

        public void setBugTitle(string bug_title)
        {
            this.bug_title = bug_title;
        }

        public string getBugTitle()
        {
            return this.bug_title;
        }

        public void setReportedBy(string reported_by)
        {
            this.reported_by = reported_by;
        }

        public string getReportedBy()
        {
            return this.reported_by;
        }

        public void setSourceFile(string source_file)
        {
            this.source_file = source_file;
        }

        public string getSourceFile()
        {
            return this.source_file;
        }

        public void setClassName(string class_name)
        {
            this.class_name = class_name;
        }

        public string getClassName()
        {
            return this.class_name;
        }

        public void setMethodLine(string method_line)
        {
            this.method_line = method_line;
        }

        public string getMethodLine()
        {
            return this.method_line;
        }

        public void setCodeLine(string code_line)
        {
            this.code_line = code_line;
        }

        public string getCodeLine()
        {
            return this.code_line;
        }

        public void setFixed(bool fix)
        {
            this.fix = fix;
        }

        public bool getFixed()
        {
            return this.fix;
        }

        public void setSourceCode(string source_code)
        {
            this.source_code = source_code;
        }

        public string getSourceCode()
        {
            return this.source_code;
        }

        public void setScreenShotFile(String screenshotfile)
        {
            this.screenshotfile = screenshotfile;
        }

        public String getScreenShot()
        {
            return this.screenshotfile;
        }

    }
}
