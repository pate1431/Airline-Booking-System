using System;
using System.Collections.Generic;
using System.Printing.IndexedProperties;
using System.Text;

namespace Midterm
{
    class Login
    {
        private int id;
        private string username;
        private string password;
        private int superuser;

        public Login(int id,string username,string password,int superuser)
        {
            Id = id;
            Username = username;
            Password = password;
            Superuser = superuser;
        }
        public Login()
        {

        }
        public int Id {
            get { return this.id; }
            set { this.id = value; }
        }
        public string Username
        {
            get { return this.username; }
            set { this.username = value; }
        }
        public string Password
        {
            get { return this.password; }
            set { this.password = value; }
        }
        public int Superuser
        {
            get { return this.superuser; }
            set { this.superuser = value; }
        }

        public List<Login> getcredentials()
        {
            List<Login> ulist = new List<Login>
            {
                new Login(1,"daksh","patel",1),
                new Login(2,"John","1234",0)


            };
            return ulist;
        }
    }
}
