using BugTracking.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracking.Controller
{
    class UserController
    {
        public static void insertUserToDatabase(User u)
        {
            string query = "insert into user (id, first_name, last_name, sex, address, username, password, role) " +
                "values(NULL,'"+u.getFirstName()+"','"+u.getLastName()+"','"+u.getSex()+"','"+u.getAddress()+"','"+u.getUsername()+"','"+u.getPassword()+"','"+u.getRole()+"')";
            DatabaseController.insertDataToForm(query);
        }

        public static void updateUserToDatabase(User u)
        {
            string query = "update user set first_name='"+ u.getFirstName() + "', last_name='"+u.getLastName()+"'" +
                ", sex='"+u.getSex()+"', address ='"+u.getAddress()+"', username='"+u.getUsername()+"', password='"+u.getPassword()+"', role='"+u.getRole()+"' where id='"+u.getId()+"'";
            DatabaseController.updateDataToForm(query);
        }

        public static void deleteUserToDatabase(User u)
        {
            string query = "delete from user where id='"+u.getId()+"'";
            DatabaseController.deleteDataToForm(query);
        }
    }
}
