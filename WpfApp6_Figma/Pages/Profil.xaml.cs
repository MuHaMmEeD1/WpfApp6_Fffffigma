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
    /// Interaction logic for Profil.xaml
    /// </summary>
    public partial class Profil : Page
    {

        bool goz = false;
        public Profil(int index)
        {
            InitializeComponent();


            List<Person> persons = new List<Person>();

            persons = JsonSerializer.Deserialize<List<Person>>(File.ReadAllText("../../../person.json"));

            FirstName.Text = persons[index].firstName;
            LastName.Text = persons[index].lastName;
            PasswordName.Password = persons[index].password;
            Mail.Text = persons[index].email;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Landing());
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            if (goz)
            {
                BtGoz.Background = new ImageBrush() { ImageSource = new BitmapImage(new Uri("../Images/aciqGoz1.png")) };
                PasswordName.PasswordChar = '\0';
            }
            else
            {
                BtGoz.Background = new ImageBrush() { ImageSource = new BitmapImage(new Uri("../Images/bagliGoz1.png")) };
                PasswordName.PasswordChar = '*';
            }
            goz = !goz;
        }

        private void ImageBrush_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (goz)
            {
                BtGoz.Background = new ImageBrush() { ImageSource = new BitmapImage(new Uri("../Images/aciqGoz1.png")) };
                PasswordName.PasswordChar = '\0';
            }
            else
            {
                BtGoz.Background = new ImageBrush() { ImageSource = new BitmapImage(new Uri("../Images/bagliGoz1.png")) };
                PasswordName.PasswordChar = '*';
            }
            goz = !goz;
        }
    }
}
