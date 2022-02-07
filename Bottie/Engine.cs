using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace botMail
{
    internal class Engine
    {
        public Engine()
        {

        }
        public void StartEnging()
        {
            while (true)
            {
                Logo();
                Console.WriteLine("Please press [ENTER]...");
                ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();
                if (consoleKeyInfo.Key != ConsoleKey.Enter)
                {
                    continue;
                }
                Menu("Enter your account ");
                Console.WriteLine("Example: your_account@gmail.com");
                Console.WriteLine();
                string mail = Console.ReadLine();

                Menu("Enter your password");
                string password = Console.ReadLine();

                try
                {
                    IBot bot = new Bot(mail, password);
                    bot.StartBot();
                    Console.Clear();
                    Logo();
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Emails are sent successfully");
                    Environment.Exit(0);
                }
                catch (Exception)
                {

                    Console.Clear();
                    Console.WriteLine("Invalid username or password");
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine("Do you want to continue y/n ?");
                    string command = Console.ReadLine();

                    if (command.ToLower() == "y")
                    {

                        continue;
                    }
                    else if (command.ToLower() == "n")
                    {
                        Console.WriteLine("Goodbye :)");
                        return;
                    }


                }
            }
        }
        private void Menu(string text)
        {

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("╔══════════════════════════════╗");
            Console.WriteLine($"║      {text}     ║");
            Console.WriteLine("╚══════════════════════════════╝");
            Console.ResetColor();
        }
        private void Logo()
        {
            string pattern = @"
 ▄▄▄▄▄▄▄▄▄▄▄  ▄▄       ▄▄  ▄▄▄▄▄▄▄▄▄▄▄  ▄▄▄▄▄▄▄▄▄▄▄  ▄           
▐░░░░░░░░░░░▌▐░░▌     ▐░░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░▌          
▐░█▀▀▀▀▀▀▀▀▀ ▐░▌░▌   ▐░▐░▌▐░█▀▀▀▀▀▀▀█░▌ ▀▀▀▀█░█▀▀▀▀ ▐░▌          
▐░▌          ▐░▌▐░▌ ▐░▌▐░▌▐░▌       ▐░▌     ▐░▌     ▐░▌          
▐░▌ ▄▄▄▄▄▄▄▄ ▐░▌ ▐░▐░▌ ▐░▌▐░█▄▄▄▄▄▄▄█░▌     ▐░▌     ▐░▌          
▐░▌▐░░░░░░░░▌▐░▌  ▐░▌  ▐░▌▐░░░░░░░░░░░▌     ▐░▌     ▐░▌          
▐░▌ ▀▀▀▀▀▀█░▌▐░▌   ▀   ▐░▌▐░█▀▀▀▀▀▀▀█░▌     ▐░▌     ▐░▌          
▐░▌       ▐░▌▐░▌       ▐░▌▐░▌       ▐░▌     ▐░▌     ▐░▌          
▐░█▄▄▄▄▄▄▄█░▌▐░▌       ▐░▌▐░▌       ▐░▌ ▄▄▄▄█░█▄▄▄▄ ▐░█▄▄▄▄▄▄▄▄▄ 
▐░░░░░░░░░░░▌▐░▌       ▐░▌▐░▌       ▐░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌
 ▀▀▀▀▀▀▀▀▀▀▀  ▀         ▀  ▀         ▀  ▀▀▀▀▀▀▀▀▀▀▀  ▀▀▀▀▀▀▀▀▀▀▀ 
                                                                 
 ▄▄▄▄▄▄▄▄▄▄   ▄▄▄▄▄▄▄▄▄▄▄  ▄▄▄▄▄▄▄▄▄▄▄                           
▐░░░░░░░░░░▌ ▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌                          
▐░█▀▀▀▀▀▀▀█░▌▐░█▀▀▀▀▀▀▀█░▌ ▀▀▀▀█░█▀▀▀▀                           
▐░▌       ▐░▌▐░▌       ▐░▌     ▐░▌                               
▐░█▄▄▄▄▄▄▄█░▌▐░▌       ▐░▌     ▐░▌                               
▐░░░░░░░░░░▌ ▐░▌       ▐░▌     ▐░▌                               
▐░█▀▀▀▀▀▀▀█░▌▐░▌       ▐░▌     ▐░▌                               
▐░▌       ▐░▌▐░▌       ▐░▌     ▐░▌                               
▐░█▄▄▄▄▄▄▄█░▌▐░█▄▄▄▄▄▄▄█░▌     ▐░▌                               
▐░░░░░░░░░░▌ ▐░░░░░░░░░░░▌     ▐░▌                               
 ▀▀▀▀▀▀▀▀▀▀   ▀▀▀▀▀▀▀▀▀▀▀       ▀                                
                                                                 
";

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(pattern);
        }


    }


}
