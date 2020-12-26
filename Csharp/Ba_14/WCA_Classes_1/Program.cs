using System;
using WCA_Classes_1.Models;

namespace WCA_Classes_1
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Say Somethig..");
            
            
            //WCA_Classes_1.Models.FirstClass = new Models.FirstClass();
            FirstClass firstClass1 = new FirstClass();
            firstClass1.FirstName = "Yusuf";
            firstClass1.LastName = "Bozkır";
            firstClass1.Mail = "yusuf.bozkir@hotmail.com";
            firstClass1.Phone = "5550550";
            firstClass1.Address = "istanbul";
            firstClass1.Age = 55;

        }
    }
}
