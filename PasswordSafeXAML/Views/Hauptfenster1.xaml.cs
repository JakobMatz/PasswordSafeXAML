using Microsoft.Win32;
using PasswordSafeXAML.Views;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;


namespace PasswordSafeXAML
{
    /// <summary>
    /// Interaktionslogik für Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            loadData();
        }

        public void refresh()
        {
            if(File.Exists("LoginDaten.csv"))
            {
                loadData();
            }
            else
            {

            }
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddLoginView win = new AddLoginView();
            win.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }


        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            {
                bool fileExist = File.Exists("LoginDaten.csv");

                if (fileExist)
                {
                    listView1.Items.Clear();
                    
                    List<example> values = File.ReadAllLines("LoginDaten.csv")

                              .Skip(1)

                              .Select(v => example.FromCsv(v))

                              .ToList();

                    foreach (var item in values)

                    {
                        
                        listView1.Items.Add(new { accountname = item.t1, email = item.t2, loginname = item.t3, password = item.t4, website = item.t5, description = item.t6 });

                    }
                }
                else
                {
                    MessageBox.Show("No Datafile found!");
                }


            }
        }


        public class example

        {

            public string t1;

            public string t2;

            public string t3;

            public string t4;

            public string t5;

            public string t6;

            public static example FromCsv(string csvLine)

            {

                string[] values = csvLine.Split(';');

                example dailyValues = new example();

                dailyValues.t1 = values[0];

                dailyValues.t2 = values[1];

                dailyValues.t3 = values[2];

                dailyValues.t4 = values[3];

                dailyValues.t5 = values[4];

                dailyValues.t6 = values[5];

                return dailyValues;

            }

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            var selection = listView1.SelectedItem;


            //Im selection kommt das ausgewählte schonmal an ^^
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            listView1.Items.RemoveAt(listView1.SelectedIndex);

            // Hier entweder ListView zu List machen und dann an Controller zum Speichern senden oder irgendwie direkt speichern.

            ExportToCsv(listView1);

/*            List<string> items = new List<string>();
            foreach (ListViewItem itm in listView1.Items)
            {
                items.Add(itm.ToString());
            }*/
        }

        private void ExportToCsv(ListView listView)
        {
            StringBuilder sb = new StringBuilder();
            GridView gv = listView.View as GridView;
            sb.Append("accountname;eMail;loginname;password;website;description");
            sb.Append(Environment.NewLine);
            for (int i = 0; i < listView.Items.Count; ++i)
            {
                Type t = listView.Items[i].GetType();
                foreach (GridViewColumn gc in gv.Columns)
                {
                    string bindingPath = (gc.DisplayMemberBinding as Binding).Path.Path;
                    PropertyInfo pi = listView.Items[i].GetType().GetProperty(bindingPath);
                    string value = pi.GetValue(listView.Items[i]).ToString();
                    sb.Append(value);
                    sb.Append(";");
                }
                sb.Append(Environment.NewLine);
            }
            File.WriteAllText("LoginDaten.csv", sb.ToString());
        }
    }
}
