using BugTracking.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracking.Controller
{
    class ChatBoxController
    {
        public static void insertMessageToDatabase(ChatBox c)
        {
            string query = "INSERT INTO `chat_box`(`id`, `message`, `username`) VALUES ('"+c.getId()+ "','" + c.getMessage() + "','" + c.getUsername() + "')";
            DatabaseController.insertDataToForm(query);
        }

        public static void UpdateMessageToDatabase(ChatBox c)
        {
            string query = "UPDATE `chat_box` SET `message`='" + c.getMessage() + "',`username`='" + c.getUsername() + "' WHERE id='" + c.getId() + "'";
            DatabaseController.updateDataToForm(query);
        }

        public static void DeleteMessageToDatabase(ChatBox c)
        {
            string query = "DELETE FROM `chat_box` WHERE id = '" + c.getId() + "'";
            DatabaseController.deleteDataToForm(query);
        }
    }
}
