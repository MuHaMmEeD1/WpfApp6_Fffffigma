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
    /// Interaction logic for Email.xaml
    /// </summary>
    public partial class Email : Page
    {

        int y_email = 0;

        public Email()
        {
            InitializeComponent();

            emailTextBox.Text = "e-mael";

            y_email = 2;
        }

        private void emailTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (y_email > 0) { emailTextBox!.Text = $"{emailTextBox.Text[emailTextBox.Text.Length - 1]}"; y_email--; }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Code());
        }
    }
}
