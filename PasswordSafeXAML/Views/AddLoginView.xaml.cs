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
using PasswordSafeXAML.Views;

namespace PasswordSafeXAML.Views
{
    /// <summary>
    /// Interaktionslogik für AddLoginView.xaml
    /// </summary>
    public partial class AddLoginView : Window

    {
        private string eMailInput;
        private string loginnameInput;
        private string passwortInput;
        private string websiteInput;
        private string descriptionInput;
        private string accountnameInput;


        public AddLoginView()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.accountnameInput = Accountname.Text;
            this.eMailInput = eMail.Text;
            this.loginnameInput = loginname.Text;
            this.passwortInput = password.Text;
            this.websiteInput = website.Text;
            this.descriptionInput = description.Text;

            Controller.LoginController.newLogin(this.accountnameInput,this.eMailInput,this.loginnameInput,this.passwortInput, 
                this.websiteInput, this.descriptionInput);

            this.Close();
            
        }
    }
}
