using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BugTracking.Model;
namespace BugTracking.Controller
{
    class ProjectController
    {
        public static void insertProjectToDatabase(UserProject p)
        {
            string query = "insert into project (project_name, start_date, end_date, arthur, user_id) values('"+p.getProjectName()+ "','" + p.getStartDate() + "','" + p.getEndDate() + "','" + p.getArthur() + "','" + p.getUserId() + "')";
            DatabaseController.insertDataToForm(query);
        }

        public static void UpdateProjectToDatabase(UserProject p)
        {
            string query = "update project set project_name='" + p.getProjectName() + "', start_date='" + p.getStartDate() + "', end_date='" + p.getEndDate() + "', arthur='" + p.getArthur() + "', user_id='" + p.getUserId() + "' where id='"+p.getId()+"'";
            DatabaseController.updateDataToForm(query);
        }

        public static void DeleteProjectToDatabase(UserProject p)
        {
            string query = "delete from project where id='"+p.getId()+"'";
            DatabaseController.deleteDataToForm(query);
        }
    }
}
