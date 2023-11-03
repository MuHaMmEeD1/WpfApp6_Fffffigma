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
    /// Interaction logic for Code.xaml
    /// </summary>
    public partial class Code : Page
    {

        int y_code = 0;
        int randomSay;

        string email;

        public Code(int randomSay, string email)
        {
            InitializeComponent();

            this.randomSay = randomSay; 
            codeTextBox.Text = "code";

            y_code = 2;
            this.email = email;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if (codeTextBox.Text == randomSay.ToString())
            {
                NavigationService.Navigate(new newPass(email));
            }

        }

        private void codeTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (y_code > 0) { codeTextBox!.Text = $"{codeTextBox.Text[codeTextBox.Text.Length - 1]}"; y_code--; }
        }
    }
}
