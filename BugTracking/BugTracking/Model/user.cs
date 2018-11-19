using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracking.Model
{
    class User
    {
        int id;
        string fname, lname, address, sex, username, password, role;

        public User(int id)
        {
            this.id = id;
        }

        public User(string fname, string lname, string address, string sex, string username, string password, string role)
        {
            this.fname = fname;
            this.lname = lname;
            this.address = address;
            this.sex = sex;
            this.username = username;
            this.password = password;
            this.role = role;

        }

        public User(int id, string fname, string lname, string address, string sex, string username, string password, string role)
        {
            this.id = id;
            this.fname = fname;
            this.lname = lname;
            this.address = address;
            this.sex = sex;
            this.username = username;
            this.password = password;
            this.role = role;

        }

        public void setId(int id)
        {
            this.id = id;
        }

        public int getId()
        {
            return this.id;
        }

        public void setFirstName(string fname)
        {
            this.fname = fname;
        }

        public string getFirstName()
        {
            return this.fname;
        }

        public void setLastName(string lname)
        {
            this.lname = lname;
        }

        public string getLastName()
        {
            return this.lname;
        }

        public void setAddress(string address)
        {
            this.address = address;
        }

        public string getAddress()
        {
            return this.address;
        }

        public void setSex(string sex)
        {
            this.sex = sex;
        }

        public string getSex()
        {
            return this.sex;
        }

        public void setUsername(string username)
        {
            this.username = username;
        }

        public string getUsername()
        {
            return this.username;
        }

        public void setPassword(string password)
        {
            this.password = password;
        }

        public string getPassword()
        {
            return this.password;
        }

        public void setRole(string role)
        {
            this.role = role;
        }

        public string getRole()
        {
            return this.role;
        }
    }
}
