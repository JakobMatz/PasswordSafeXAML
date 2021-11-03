using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordSafeXAML
{
    class Entry
    {
        private string username;
        private string loginname;
        private string password;
        private string website;
        private string description;

        public Entry(string domain)
        {
            website = domain;
        }

    }
}
