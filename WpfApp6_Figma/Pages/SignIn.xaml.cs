using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
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




            int index = 0;

            List<Person> persons = new List<Person>();

            persons = JsonSerializer.Deserialize<List<Person>>(File.ReadAllText("../../../person.json"));

            bool yoxlayan = false;

            for (int i = 0; i < persons!.Count; i++)
            {
                if (persons[i].email == loginTextBox.Text && persons[i].password == passwordTextBox.Text)
                {
                    index = i;
                    yoxlayan = true;
                    break;
                }
            }

            if (yoxlayan)
            {
                NavigationService.Navigate(new Profil(index));
            }
            else { loginTextBox.Foreground = Brushes.Red; passwordTextBox.Foreground = Brushes.Red; }

            



        }




        private void FPasswordRI__Click(object sender, RoutedEventArgs e)
        {


            List<Person> persons = new List<Person>();

            persons = JsonSerializer.Deserialize<List<Person>>(File.ReadAllText("../../../person.json"));

            bool yoxla = false;

            for (int i = 0; i < persons.Count; i++)
            {
                if (persons[i].email == loginTextBox.Text)
                {
                    yoxla = true;
                    break;
                }
            }


            if (yoxla)
            {
                NavigationService.Navigate(new Email());
            }
            else { loginTextBox.Foreground = Brushes.Red; }


            
        }
    }
}
