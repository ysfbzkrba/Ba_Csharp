using System;
using DBFirstApp.Data;
using DBFirstApp.Models;

namespace DBFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            NorthwindEntities db = new NorthwindEntities();
            var categories = db.Categories;
            foreach (Category category in categories)
            {
                Console.WriteLine($"{category.CategoryId} - {category.CategoryName.ToString().PadRight(15)} - {category.Description}");
            }
            
            //
            // 1. DB First      ::
            // 2. Code First    :: most common
            // 3. Model First   ::
            //
            //      ORM     \\ object relational mapping
        }
    }
}

// dotnet add package Microsoft.EntityFrameworkCore.Design
// dotnet add package Microsoft.EntityFramworkCore.SqlServer

// dotnet ef dbcontext scaffold "server=DESKTOP-JB4FO9V\MSSQLEXPRESS;database=Northwind;uid=sa;pwd=123" Microsoft.EntityFrameworkCore.SqlServer -o Models -t Categories -t Products -t Customers -t Shippers -t Employees --context-dir Data -c NorthwindEntities



// integrated security = yes
