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
    /// Interaction logic for newPass.xaml
    /// </summary>
    public partial class newPass : Page
    {

        int y_newpass = 0;
        int y_confirmpass = 0;



        public newPass()
        {
            InitializeComponent();


            newpassTextBox.Text = "new pass";

            confirmpassTextBox.Text = "confirm pass";


            y_newpass = 2;
            y_confirmpass = 2;
        }

        private void newpassTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (y_newpass > 0) { newpassTextBox!.Text = $"{newpassTextBox.Text[newpassTextBox.Text.Length - 1]}"; y_newpass--; }
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
