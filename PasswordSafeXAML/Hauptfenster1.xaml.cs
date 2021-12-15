using Microsoft.Win32;
using PasswordSafeXAML.Views;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
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
            {
                bool fileExist = File.Exists("LoginDaten.csv");

                if(fileExist)
                {
                    List<example> values = File.ReadAllLines("LoginDaten.csv")

                              .Skip(1)

                              .Select(v => example.FromCsv(v))

                              .ToList();

                    foreach (var item in values)

                    {

                        listView1.Items.Add(new { accountname = item.t1, email = item.t2, loginname = item.t3, password = item.t4, website = item.t5, description = item.t6 });

                    }
                } else
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

        private void listView1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            var selection = listView1.SelectedItem;

            //Im selection kommt das ausgeählte schonmal an ^^
        }
    }
}
