using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordSafeXAML
{
    public class Login
    {
    static private string _pw = "";
        public static bool loginTry(string pw)
        {
            _pw = pw;
            return pwCheck();
        }
        static private bool pwCheck()
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
