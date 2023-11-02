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
    /// Interaction logic for Password.xaml
    /// </summary>
    public partial class Password : Page
    {

        int y_password = 0;
        int y_confirmpass = 0;


        public Password()
        {
            InitializeComponent();

            passwordTextBox.Text = "password";
            confirmpassTextBox.Text = "confirm pass";

            y_password = 2;
            y_confirmpass = 2;

        }

        private void passwordTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (y_password > 0) { passwordTextBox!.Text = $"{passwordTextBox.Text[passwordTextBox.Text.Length - 1]}"; y_password--; }
        }

        private void confirmpassTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (y_confirmpass > 0) { confirmpassTextBox!.Text = $"{confirmpassTextBox.Text[confirmpassTextBox.Text.Length - 1]}"; y_confirmpass--; }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Done());
        }
    }
}
