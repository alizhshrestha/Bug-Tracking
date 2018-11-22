using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracking.Model
{
    class ChatBox
    {
        int id;
        string username, message;

        public ChatBox(String message, String username)
        {
            this.username = username;
            this.message = message;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public int getId()
        {
            return this.id;
        }

        public void setUsernme(string username)
        {
            this.username = username;
        }

        public string getUsername()
        {
            return this.username;
        }

        public void setMessage(string message)
        {
            this.message = message;
        }

        public string getMessage()
        {
            return this.message;
        }
    }
}
