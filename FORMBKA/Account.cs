using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FORMBKA
{
    class Account
    {
        private string username;
        private string password;
        private string role;
        public Account()
        {

        }

        public Account(string userName, string passWord, string role)
        {
            this.username = userName;
            this.password = passWord;
            this.role = role;
        }


    }
}
