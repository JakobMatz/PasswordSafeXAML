using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PasswordSafeXAML
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                btn_Login_Click(sender, e);
            }
        }
        private void TextBox_KeyUp(object sender, System.Windows.Input.KeyEventArgs e)
        {
                        
        }
        private void btn_Login_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show(PasswordBox.Password);
            if (Login.loginTry(PasswordBox.Password))
            {
                Window1 win = new Window1();
                win.Show();

                this.Close();
            } else {
                MessageBox.Show("Falsches Passwort");
            }
            
        }
    }
}
