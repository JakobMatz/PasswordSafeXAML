using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordSafeXAML
{
    class Login
    {
        private string _pw = "";
        public Login(string pw)
        {
            _pw = pw;
        }
        private bool pwCheck()
        {
            string password = "asdf";

            if(_pw.Equals(password))
            {
                return true;
            }

            return false;
        }
    }
}
