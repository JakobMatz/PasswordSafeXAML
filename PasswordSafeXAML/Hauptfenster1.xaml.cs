using PasswordSafeXAML.Views;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
    /// 

    public class TableNames

    {

        public string t1;

        public string t2;

        public string t3;

        public static TableNames FromCsv(string csvLine)

        {

            string[] values = csvLine.Split(';');

            TableNames dailyValues = new TableNames();

            dailyValues.t1 = values[0];

            dailyValues.t2 = values[1];

            dailyValues.t3 = values[2];

            return dailyValues;

        }

    }



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
            List<TableNames> values = File.ReadAllLines("C:\\Users\\jakob\\Documents\\git\\PasswordSafeXAML\\PasswordSafeXAML\\bin\\Debug\\LoginDaten.csv")

                              .Skip(1)

                              .Select(v => TableNames.FromCsv(v))

                              .ToList();

            foreach (var item in values)

            {

                ListBox1.Items.Add(item.t1);

            }
        }
    }
}
