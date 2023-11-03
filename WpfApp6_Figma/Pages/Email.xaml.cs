using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
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
        int randomSay = Random.Shared.Next(100000, 999999);
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


            bool tap = true;

            string email_ = "@gmail.com";
            if (emailTextBox.Text.Length >= email_.Length)
            {
                for (int i = 0; i < email_.Length; i++)
                {
                    if (emailTextBox.Text[emailTextBox.Text.Length - (i + 1)] != email_[9 - i]) { tap = false; break; }
                }
            }

            if (tap)
            {


                string senderEmail = "figmaf098@gmail.com";
                string senderPassword = "sjce rmeu scnr yrmz";

                string recipientEmail = $"{emailTextBox.Text}";

                MailMessage mailMessage = new MailMessage(senderEmail, recipientEmail);
                mailMessage.Subject = "Email Notification";
                mailMessage.Body = $"{randomSay}";


                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
                smtpClient.Port = 587;
                smtpClient.Credentials = new NetworkCredential(senderEmail, senderPassword);
                smtpClient.EnableSsl = true;

                smtpClient.Send(mailMessage);


                NavigationService.Navigate(new Code(randomSay, emailTextBox.Text));
            }





            
        }
    }
}
