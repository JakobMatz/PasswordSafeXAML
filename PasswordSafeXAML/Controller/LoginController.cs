using PasswordSafeXAML.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PasswordSafeXAML.Controller
{
    class LoginController
    {
        private static List<LoginModel> LoginData = new List<LoginModel>();
        public static void newLogin(string eMail, string loginname, string password, string website, string description)
        {
            LoginData.AddRange(new List<LoginModel> {
            new LoginModel(eMail,loginname,password,website,description)
            });
            //MessageBox.Show(LoginData.ToString());

            try
            {
                FileStream addLoginData = new FileStream("AddedLogins.csv", FileMode.OpenOrCreate);
                using (StreamWriter ASKYWRITE = new StreamWriter(addLoginData))
                {
                    ASKYWRITE.Write("eMail,loginname,password,website,description" + "\r\n");
                    ASKYWRITE.Write(eMail + ",");
                    ASKYWRITE.Write(loginname + ",");
                    ASKYWRITE.Write(password + ",");
                    ASKYWRITE.Write(website + ",");
                    ASKYWRITE.Write(description + ",");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error");
            }
        }
    }
}
