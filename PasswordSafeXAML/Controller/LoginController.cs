using PasswordSafeXAML.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using CsvHelper;
using PasswordSafeXAML.Views;

namespace PasswordSafeXAML.Controller
{

    public class LoginController
    {
        public static void newLogin(string accountname, string eMail, string loginname, string password, string website, string description)
        {

            var records = new List<LoginModel>
            {
                    new LoginModel { accountname = accountname, eMail = eMail, loginname = loginname, password=password, website=website, description=description },
            };
            using (var mem = new MemoryStream())
            {
                bool fileExist = File.Exists("LoginDaten.csv");
                if (fileExist)
                {
                    using (var writer = new StreamWriter("LoginDaten.csv", true))
                    {
                        using (var csv = new CsvWriter(writer))
                        {
                            csv.Configuration.HasHeaderRecord = false;
                            csv.Configuration.Delimiter = ";";

                            csv.WriteRecords(records);
                        }
                    }
                }
                else
                {
                    using (var writer = new StreamWriter("LoginDaten.csv"))
                    using (var csv = new CsvWriter(writer))
                    {
                        csv.Configuration.Delimiter = ";";

                        csv.WriteRecords(records);

                        writer.Flush();

                        var result = Encoding.UTF8.GetString(mem.ToArray());
                        Console.WriteLine(result);
                    }
                }
            }
        }

        public void loadData()
        {
            
        }
    }
}
