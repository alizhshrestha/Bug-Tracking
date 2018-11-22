using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracking.Model
{
    class Bug_fix
    {
        int id, bug_id;
        string fixer_name, fixed_code, reported_by, 
            bug_title, source_file, class_name, method_line, code_line, source_code;

        public void setBugTitle(string bug_title)
        {
            this.bug_title = bug_title;
        }

        public string getBugTitle()
        {
            return this.bug_title;
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

        public void setSourceCode(string source_code)
        {
            this.source_code = source_code;
        }

        public string getSourceCode()
        {
            return this.source_code;
        }

        
        public Bug_fix(string fixer_name, string fixed_code, int bug_id, string reported_by)
        {
            this.fixer_name = fixer_name;
            this.fixed_code = fixed_code;
            this.bug_id = bug_id;
            this.reported_by = reported_by;
        }

        public Bug_fix(string fixer_name, string fixed_code, int bug_id, string reported_by,
            string bug_title, string source_file, string class_name, string method_line, string code_line, string source_code)
        {
            this.fixer_name = fixer_name;
            this.fixed_code = fixed_code;
            this.bug_id = bug_id;
            this.reported_by = reported_by;
            this.bug_title = bug_title;
            this.source_file = source_file;
            this.class_name = class_name;
            this.method_line = method_line;
            this.code_line = code_line;
            this.source_code = code_line;
        }

        public Bug_fix(string fixer_name, string fixed_code, int bug_id)
        {
            this.fixer_name = fixer_name;
            this.fixed_code = fixed_code;
            this.bug_id = bug_id;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public int getId()
        {
            return this.id;
        }

        public void setBugId(int bug_id)
        {
            this.bug_id = bug_id;
        }

        public int getBugId()
        {
            return this.bug_id;
        }

        public void setReportedBy(string reported_by)
        {
            this.reported_by = reported_by;
        }

        public string getReportedBy()
        {
            return this.reported_by;
        }

        public void setFixerName(string fixer_name)
        {
            this.fixer_name = fixer_name;
        }

        public string getFixerName()
        {
            return this.fixer_name;
        }

        public void setFixedCode(string fixed_code)
        {
            this.fixed_code = fixed_code;
        }

        public string getFixedCode()
        {
            return this.fixed_code;
        }
    }
}
