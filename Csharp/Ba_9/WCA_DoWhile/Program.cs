using System;

namespace WCA_DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            //string username = "admin";
            //string password = "123";

            //string Uname = "";
            //string Upass = "";
            //while (Uname != username || Upass != password)
            //{
            //    Console.Clear();
            //    Console.WriteLine("Please enter your username.");
            //    Uname = Console.ReadLine();

            //    Console.WriteLine("Please enter your password.");
            //    Upass = Console.ReadLine();
            //}

            //do
            //{
            //    Console.Clear();
            //    Console.WriteLine("Please enter your username.");
            //    Uname = Console.ReadLine();

            //    Console.WriteLine("Please enter your password.");
            //    Upass = Console.ReadLine();
            //} while (Uname != username || Upass != password);

            (string username, string password, bool isLogin) user = ("", "", false); // = (default,default,default);
            do
            {
                Console.Clear();
                   Console.WriteLine("Please enter your username.");
                   user.username = Console.ReadLine();

                  Console.WriteLine("Please enter your password.");
                   user.password = Console.ReadLine();
                if (user.username == "admin" && user.password == "123") 
                {
                    Console.Clear();
                    user.isLogin = true;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Congragulations! User Login Successful!");
                    Console.ResetColor();
                }
            } while (!user.isLogin);


        }
    }
}
