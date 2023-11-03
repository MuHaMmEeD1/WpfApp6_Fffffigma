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
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class Register : Page
    {

        int y_firstname = 0;
        int y_lastname = 0;
        int y_email = 0;

        bool yoxlaEmail = false;

        public Person person = new();
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


            if (emailTextBox.Text.Length >= 11)
            {

                bool yoxla = true;
                string gml = "@gmail.com";

                for (int i = 0; i < 10; i++)
                {

                    if (emailTextBox.Text[emailTextBox.Text.Length - (1 + i)] == gml[9 - i]) { }
                    else { yoxla = false; break; }
                }


                if (yoxla) { emailTextBox.Foreground = Brushes.Green; yoxlaEmail = true; }
                else { emailTextBox.Foreground = Brushes.Red; yoxlaEmail = false; }


            }
            else { emailTextBox.Foreground = Brushes.Red; yoxlaEmail = false; }


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if (emailTextBox.Text.Length >= 11)
            {

                bool yoxla = true;
                string gml = "@gmail.com";

                for (int i = 0; i < 10; i++)
                {

                    if (emailTextBox.Text[emailTextBox.Text.Length - (1 + i)] == gml[9 - i]) { }
                    else { yoxla = false; break; }
                }


                if (yoxla) { emailTextBox.Foreground = Brushes.Green; yoxlaEmail = true; }
                else { emailTextBox.Foreground = Brushes.Red; yoxlaEmail = false; }


            }
            else { emailTextBox.Foreground = Brushes.Red; yoxlaEmail = false; }

            bool yoxla11 = true;

            List<Person> list = new List<Person>();


            list = JsonSerializer.Deserialize<List<Person>>(File.ReadAllText("../../../person.json"));
                ;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].email == emailTextBox.Text) { yoxla11 = false; }
            }



            if (yoxlaEmail && firstnameTextBox.Text.Length != 0 && lastnameTextBox.Text.Length != 0 && yoxla11)
            {
                person.firstName = firstnameTextBox.Text;
                person.lastName = lastnameTextBox.Text;
                person.email = emailTextBox.Text;

                NavigationService.Navigate(new Password(person));

            }
            else
            {
                if (firstnameTextBox.Text.Length != 0) { firstnameTextBox.Foreground = Brushes.Red; }
                if (lastnameTextBox.Text.Length != 0) { lastnameTextBox.Foreground = Brushes.Red; }

            }














            



        }
    }
}
