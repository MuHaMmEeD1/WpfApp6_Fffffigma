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
    /// Interaction logic for newPass.xaml
    /// </summary>
    public partial class newPass : Page
    {

        int y_newpass = 0;
        int y_confirmpass = 0;

        string email;

        public newPass(string email)
        {
            InitializeComponent();


            newpassTextBox.Text = "new pass";

            confirmpassTextBox.Text = "confirm pass";


            y_newpass = 2;
            y_confirmpass = 2;
            this.email = email;
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



            if (newpassTextBox.Text == confirmpassTextBox.Text && newpassTextBox.Text.Length >= 7)
            {


                List<Person> list = new List<Person>();


                list = JsonSerializer.Deserialize<List<Person>>(File.ReadAllText("../../../person.json"));


                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].email == email) { list[i].password = newpassTextBox.Text; break; }
                }


                File.WriteAllText("../../../person.json", JsonSerializer.Serialize(list, new JsonSerializerOptions() { WriteIndented = true }));


                NavigationService.Navigate(new Done());
            }
            else
            {

                newpassTextBox.Foreground = Brushes.Red;
                confirmpassTextBox.Foreground = Brushes.Red;

            };


           
        }
    }
}
