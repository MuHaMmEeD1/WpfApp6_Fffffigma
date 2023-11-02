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
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class Register : Page
    {

        int y_firstname = 0;
        int y_lastname = 0;
        int y_email = 0;


        public Register()
        {
            InitializeComponent();


            firstnameTextBox.Text = "first name";
            lastnameTextBox.Text = "last name";
            emailTextBox.Text = "e-mail";


            y_firstname = 2;
            y_lastname = 2;
            y_email = 2;

        }

        private void firstnameTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (y_firstname > 0) { firstnameTextBox!.Text = $"{firstnameTextBox.Text[firstnameTextBox.Text.Length - 1]}"; y_firstname--; }
        }

        private void laatnameTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (y_lastname > 0) { lastnameTextBox!.Text = $"{lastnameTextBox.Text[lastnameTextBox.Text.Length - 1]}"; y_lastname--; }
        }

        private void emailTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (y_email > 0) { emailTextBox!.Text = $"{emailTextBox.Text[emailTextBox.Text.Length - 1]}"; y_email--; }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Password());
        }
    }
}
