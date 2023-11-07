using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOForm.model
{
    internal class User
    {
        private string username, password, userid;
        private DateTime createdDate;

        public User()
        {

        }
        public User(string username, string password, string userid, DateTime createdDate)
        {
            this.username = username;
            this.password = password;
            this.userid = userid;
            this.createdDate = createdDate;
        }

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Userid { get => userid; set => userid = value; }
        public DateTime CreatedDate { get => createdDate; set => createdDate = value; }
    }
}
