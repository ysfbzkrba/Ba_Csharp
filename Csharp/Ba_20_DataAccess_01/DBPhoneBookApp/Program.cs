using System;
using DBPhoneBookApp.Models;
using DBPhoneBookApp.Data;

namespace DBPhoneBookApp
{
    class Program
    {
        static void Main(string[] args)
        {
            PhoneBookEntities db = new PhoneBookEntities();
            // var people = db.People;
            // foreach (Person person in people)
            // {
            //     Console.WriteLine($"{person.Id} - {person.FirstName.ToString().PadRight(15)} - {person.LastName.ToString().PadRight(15)} - {person.Phone.ToString().PadRight(15)} - {person.Mail}");
            // }

            bool result = true;
            while (result)
            {
                Console.Clear();

                Console.WriteLine("Please select what you want.");
                Console.WriteLine("To add    press :: a");
                Console.WriteLine("To delete press :: d");
                Console.WriteLine("To update press :: u");
                Console.WriteLine("To list   press :: l");
                Console.WriteLine("press any key to exit.");
                string key = Console.ReadLine();

                switch (key)
                {
                    case "a":
                    {
                        Person person = new Person();
                        Console.WriteLine("Please enter name :");
                        person.FirstName=Console.ReadLine();
                        Console.WriteLine("Please enter last name :");
                        person.LastName=Console.ReadLine();
                        Console.WriteLine("Please enter phone number :");
                        person.Phone=Console.ReadLine();
                        Console.WriteLine("Please enter Mail address :");
                        person.Mail=Console.ReadLine();

                        db.People.Add(person);
                        db.SaveChanges();
                        Console.ForegroundColor=ConsoleColor.Green;
                        Console.WriteLine("Succesfully Added.");
                        Console.ForegroundColor=default;

                        break;
                    }
                    case "d":
                    {
                        Person x = new Person();
                        Console.WriteLine("Please enter id number for deletion.");

                        int id = int.Parse(Console.ReadLine());
                        db.People.Remove(x);
                        db.SaveChanges();
                        Console.ForegroundColor=ConsoleColor.Green;
                        Console.WriteLine("Succesfully Deleted.");
                        Console.ForegroundColor=default;
                        break;
                    }
                    case "u":
                    {
                        Person update = new Person();

                        Console.WriteLine("Please enter name :");
                        string firstname = Console.ReadLine();
                        if (firstname is not null or "")
                        {
                            update.FirstName=firstname;                            
                        }

                        Console.WriteLine("Please enter last name :");
                        string lastname = Console.ReadLine();
                        if (lastname is not null or "")
                        {
                            update.LastName=lastname;
                        }

                        Console.WriteLine("Please enter phone number :");
                        string phone = Console.ReadLine();
                        if (phone is not null or "")
                        {
                            update.Phone=phone;
                        }

                        Console.WriteLine("Please enter Mail address :");
                        string mail = Console.ReadLine();
                        if (mail is not null or "")
                        {
                        update.Mail=mail;
                        }

                        db.People.Add(update);
                        db.SaveChanges();
                        Console.ForegroundColor=ConsoleColor.Green;
                        Console.WriteLine("Succesfully Updated.");
                        Console.ForegroundColor=default;
                        break;
                    }
                    case "l":
                    {
                        foreach (Person person in db.People)
                        {
                            Console.WriteLine($"{person.Id} | {person.FirstName.ToString().PadRight(5)} | {person.LastName.ToString().PadRight(5)} | {person.Phone.ToString().PadRight(10)} | {person.Mail}");
                        }

                        break;
                    }
                    default:
                    {
                        result=false;
                        break;
                    }
                }
            }



        }
    }
}


// dotnet add package Microsoft.EntityFrameworkCore.Design
// dotnet add package Microsoft.EntityFramworkCore.SqlServer

// dotnet ef dbcontext scaffold "server=DESKTOP-JB4FO9V\MSSQLEXPRESS;database=PhoneBook;uid=sa;pwd=123" Microsoft.EntityFrameworkCore.SqlServer -o Models --context-dir Data -c PhoneBookEntities