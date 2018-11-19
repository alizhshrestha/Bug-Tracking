﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracking.Model
{
    class Bug
    {
        int id, project_id;
        string bug_title, source_file, class_name, method_line, code_line;
        bool fix;

        public Bug(string bug_title, string source_file, string class_name, string method_line, string code_line, int project_id,  bool fix)
        {
            this.bug_title = bug_title;
            this.source_file = source_file;
            this.class_name = class_name;
            this.method_line = method_line;
            this.code_line = code_line;
            this.project_id = project_id;
            this.fix = fix;

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

    }
}
