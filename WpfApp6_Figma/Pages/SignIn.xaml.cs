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

namespace WpfApp6_Figma.Pages
{
    /// <summary>
    /// Interaction logic for SignIn.xaml
    /// </summary>
    public partial class SignIn : Page
    {
        int y_login = 0;
        int y_password = 0;

        public SignIn()
        {

            InitializeComponent();

            y_login = 2;
            y_password = 2;
        }



       

        private void loginTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (y_login > 0) { loginTextBox!.Text = $"{loginTextBox.Text[loginTextBox.Text.Length-1]}"; y_login--; }
        }

        private void passwordTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (y_password > 0) { passwordTextBox!.Text = $"{passwordTextBox.Text[passwordTextBox.Text.Length - 1]}"; y_password--; }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Profil());
        }

        private void FPasswordRI__Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Email());
        }
    }
}
