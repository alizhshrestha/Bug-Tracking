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
        string fixer_name, fixed_code, reported_by;

        public Bug_fix(string fixer_name, string fixed_code, int bug_id, string reported_by)
        {
            this.fixer_name = fixer_name;
            this.fixed_code = fixed_code;
            this.bug_id = bug_id;
            this.reported_by = reported_by;
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
