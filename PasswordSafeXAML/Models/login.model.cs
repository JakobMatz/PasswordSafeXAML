using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordSafeXAML.Models
{
    
    public class LoginModel
    {
        public string accountname { get; set; }
        public string eMail { get; set; }
        public string loginname { get; set; }
        public string password { get; set; }
        public string website { get; set; }
        public string description { get; set; }
        
    }
    
    /*
    public class LoginModel
    {
        private string eMail;
        private string loginname;
        private string password;
        private string website;
        private string description;

        public LoginModel(string eMail, string loginname, string password, string website, string description) 
            => (eMail, loginname, password, website, description) = (eMail, loginname, password, website, description);
    }
    */
}
