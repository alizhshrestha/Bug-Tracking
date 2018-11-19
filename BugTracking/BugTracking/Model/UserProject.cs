using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracking.Model
{
    class UserProject
    {
        int id, user_id;
        string project_name, start_date, end_date, arthur;

        public UserProject(int id)
        {
            this.id = id;
        }

        public UserProject(string project_name, string start_date, string end_date, string arthur)
        {
            this.project_name = project_name;
            this.start_date = start_date;
            this.end_date = end_date;
            this.arthur = arthur;
        }

        public UserProject(int id, string project_name, string start_date, string end_date, string arthur, int user_id)
        {
            this.id = id;
            this.project_name = project_name;
            this.start_date = start_date;
            this.end_date = end_date;
            this.arthur = arthur;
            this.user_id = user_id;
        }

        public UserProject(string project_name, string start_date, string end_date, string arthur, int user_id)
        {
            this.project_name = project_name;
            this.start_date = start_date;
            this.end_date = end_date;
            this.arthur = arthur;
            this.user_id = user_id;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public int getId()
        {
            return this.id;
        }

        public void setUserId(int user_id)
        {
            this.user_id = user_id;
        }

        public int getUserId()
        {
            return this.user_id;
        }

        public void setProjectName(string project_name)
        {
            this.project_name = project_name;
        }

        public string getProjectName()
        {
            return this.project_name;
        }

        public void setStartDate(string start_date)
        {
            this.start_date = start_date;
        }

        public string getStartDate()
        {
            return this.start_date;
        }

        public void setEndDate(string end_date)
        {
            this.end_date = end_date;
        }

        public string getEndDate()
        {
            return this.end_date;
        }

        public void setArthur(string arthur)
        {
            this.arthur = arthur;
        }

        public string getArthur()
        {
            return this.arthur;
        }

    }
}
