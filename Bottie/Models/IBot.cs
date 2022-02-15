using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace botMail
{
    public interface IBot
    {
        public string Username { get; }
        public string Password { get; }

        public void StartBot(string nameOfEmails, string fileExtensionOfEmails, string nameOfText, string fileExtensionOfText);

    }
}
