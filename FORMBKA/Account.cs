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
        private int role;
        public Account()
        {

        }

        public Account(string userName, string passWord, int role)
        {
            this.username = userName;
            this.password = passWord;
            this.role = role;
        }


    }
}
