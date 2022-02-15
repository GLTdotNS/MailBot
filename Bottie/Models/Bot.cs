using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace botMail
{
    public class Bot : IBot
    {
        private string username;
        private string password;


        public Bot(string username, string password)
        {
            this.Username = username;
            this.Password = password;
        }

        public string Username
        {
            get => this.username;
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new InvalidDataException("The username cannot be empty");
                }
                this.username = value;
            }
        }

        public string Password
        {
            get => this.password;
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new InvalidDataException("The password cannot be empty");
                }
                this.password = value;
            }
        }

        public void StartBot(string nameOfEmails, string fileExtensionOfEmails, string nameOfText, string fileExtensionOfText)
        {
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");


            string pathEmails = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), $"{nameOfEmails}.{fileExtensionOfEmails}");
            string pathText = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), $"{nameOfText}.{fileExtensionOfText}");
            StreamReader sr = new StreamReader(pathEmails);
            StreamReader sr2 = new StreamReader(pathText);

            List<string> emailRecievers = new List<string>();
            StringBuilder sb = new StringBuilder();


            while (!sr.EndOfStream)
            {
                emailRecievers.Add(sr.ReadLine());

            }
            sb.AppendLine(sr2.ReadToEnd());


            foreach (var e in emailRecievers)
            {
                mail.From = new MailAddress(this.Username);
                mail.To.Add(e);
                mail.Subject = "Test Mail";
                mail.Body = sb.ToString();
                //Attachment attachment = new Attachment(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "text.docx"));
                //mail.Attachments.Add(attachment);
                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential(this.Username, this.Password);
                SmtpServer.EnableSsl = true;

            }
            SmtpServer.Send(mail);




        }
    }
}
