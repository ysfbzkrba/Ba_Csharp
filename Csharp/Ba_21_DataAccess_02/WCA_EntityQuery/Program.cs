using System;
using System.Collections.Generic;
using System.Reflection;
using WCA_EntityQuery.Models;
using WCA_EntityQuery.Data;
using System.Linq;

namespace WCA_EntityQuery
{
    class Program
    {
        #region Functions
        public static void WriteToConsole(IEnumerable<object> items)
        {
            string header = default;
            foreach (PropertyInfo pName in items.FirstOrDefault().GetType().GetProperties())
            {
                header += $"{pName.Name.PadRight(35)}";

            }
            Console.WriteLine(header);
            Console.WriteLine(new string('-', header.Length - 35));
            foreach (var item in items)
            {
                string body = default;
                foreach (PropertyInfo property in item.GetType().GetProperties())
                {
                    body += $"{property.GetValue(item)}".PadRight(35);
                }
                Console.WriteLine(body);
            }
        }
        /// <summary>
        /// Gets products priced between a to b
        /// </summary>
        /// <param BiggerThan="a"></param>
        /// <param SmallerThan="b"></param>
        static void UnitPrice(int a, int b)
        {
            //using (NorthwindContext db = new NorthwindContext())
            //{

            //}

            //  ^^old version^^
            using NorthwindContext context = new NorthwindContext();
            //var result = context.Products; // SELECT * FROM Products;

            //var result = context.Products.Select(x=> new 
            //{
            //    x.ProductId,
            //    x.ProductName,
            //    x.UnitPrice,
            //    x.UnitsInStock
            //});

            var result = context.Products
                .Where(x => x.UnitPrice >= a && x.UnitPrice <= b)
                .OrderBy(x => x.UnitPrice)
                .Select(x => new
                {
                    UrunID = x.ProductId,
                    UrunADI = x.ProductName,
                    Fiyat = x.UnitPrice,
                    StokAdedi = x.UnitsInStock
                });

            var q = from pd in context.Products
                    join cd in context.Categories on pd.CategoryId equals cd.CategoryId
                    where pd.UnitPrice >= a && pd.UnitPrice <= b
                    orderby pd.UnitPrice
                    select new

                    {
                        pd.ProductId,
                        pd.ProductName,
                        cd.CategoryName,
                        pd.UnitPrice,
                        pd.UnitsInStock
                    };


            WriteToConsole(q);


        }
        /// <summary>
        /// Gets Shipper and customer companies.
        /// </summary>
        static void ShipperToCustomer()
        {
            // note :: Use if u dont want to make any changes on the object. usually used for listing.
            // 
            //
            using NorthwindContext context = new NorthwindContext();
            //
            var q = from ed in context.Employees
                    join od in context.Orders on ed.EmployeeId equals od.EmployeeId
                    join cd in context.Customers on od.CustomerId equals cd.CustomerId
                    join sd in context.Shippers on od.ShipVia equals sd.ShipperId
                    //where (condition) (operator) (condition)
                    orderby od.OrderDate
                    select new

                    {
                        CompanyName = cd.CompanyName,
                        Employee = ed.FirstName + " " + ed.LastName,
                        od.OrderId,
                        Date = od.OrderDate.Value.ToShortDateString(),
                        Shipper = sd.CompanyName,
                        od.ShipName
                    };


            WriteToConsole(q);

        }
        /// <summary>
        /// Gets employee ages
        /// </summary>
        static void EmployeeAge()
        {
            using NorthwindContext context = new NorthwindContext();

            var q = from ed in context.Employees
                    where (ed.BirthDate.Value.Month < 10)
                    select new

                    {
                        Employee = ed.FirstName + " " + ed.LastName,
                        BirthDate = "0" + ed.BirthDate.Value.ToShortDateString(),
                        Age = DateTime.Today.Year - ed.BirthDate.Value.Year
                    };
            var a = from ed in context.Employees
                    where (ed.BirthDate.Value.Month >= 10)
                    select new

                    {
                        Employee = ed.FirstName + " " + ed.LastName,
                        BirthDate = ed.BirthDate.Value.ToShortDateString(),
                        Age = DateTime.Today.Year - ed.BirthDate.Value.Year
                    };

            WriteToConsole(q);
            WriteToConsole(a);
        }
        /// <summary>
        /// Gets customer company names containing given string
        /// </summary>
        /// <param string="contain"></param>
        static void CustomersContain(string contain)
        {
            using NorthwindContext context = new NorthwindContext();

            var q = from cs in context.Customers
                    where cs.CompanyName.Contains(contain)
                    select new
                    {
                        cs.CompanyName
                    };
            WriteToConsole(q);
        }
        /// <summary>
        /// adds given product to products
        /// </summary>
        /// <param name="prod"></param>
        /// <param name="CName"></param>
        //static void AddtoProducts(Product prod, string CName)
        //{
        //    using NorthwindContext context = new NorthwindContext();

        //    //int id = context.Categories
        //    //        .Where(x => x.CategoryName == CName)
        //    //            .FirstOrDefault()
        //    //                .CategoryId;

        //    int id1 = context.Categories.FirstOrDefault(x => x.CategoryName == CName).CategoryId;

        //    Category category1 = context.Categories.FirstOrDefault(x => x.CategoryName == CName);
        //            // FirstOrDefault :: gets first item satisfies filter.
        //    //Category category2 = context.Categories.SingleOrDefault(x => x.CategoryName == CName);
        //    // SingleOrDefault :: gets if there is a single item that satisfies the filter.

        //    if (category1 is null)
        //    {
        //        Console.ForegroundColor = ConsoleColor.Red;
        //        Console.WriteLine("Can't find the category you asked for..");
        //        Console.ForegroundColor = default;
        //        return;
        //    }

        //    prod.CategoryId = id1;
        //    context.Products.Add(prod);
        //    //var q = context.Products;
        //    //WriteToConsole(q);
        //}
        static void AddtoProducts(Product prod)
        {
            using NorthwindContext context = new NorthwindContext();

            context.Products.Add(prod);

            var q = context.Products.Select(x => new
            {
                x.ProductId,
                x.ProductName,
                x.UnitPrice,
                x.UnitsInStock
            });
            
            var result = context.SaveChanges() > 0;
            Console.WriteLine($"Kategori Ekleme İşlemi {(result ? "Başarılı" : "Başarısız")}");

            //WriteToConsole(q);
        }
        /// <summary>
        /// gets products from Northwind.db
        /// </summary>
        static void GetProducts()
        {
            using NorthwindContext context = new NorthwindContext();

            //var q = context.Products;
           
            var result = context.Products.Select(x => new
            {
                x.ProductId,
                x.ProductName,
                x.UnitPrice,
                x.UnitsInStock
            });
            WriteToConsole(result);
        }

        #endregion


        static void Main(string[] args)
        {

            #region AddCoke
            Product cokeLight = new Product
            {
                ProductName = "Coke Light",
                SupplierId = 4,
                CategoryId = 1,
                UnitPrice = 5.00M,
                UnitsInStock = 500
            };

            AddtoProducts(cokeLight);
            #endregion

            //Product pepsi = new Product();
            //pepsi.ProductName = "Pepsi";
            //pepsi.UnitPrice = 4.00M;
            //pepsi.UnitsInStock = 400;

            Product pepsiMax = new Product()
            {
                ProductName = "Pepsi Max",
                UnitPrice = 4,
                UnitsInStock = 400
            };

            AddtoProducts(pepsiMax);


            GetProducts();
        }
    }
}

// dotnet ef dbcontext scaffold "server=DESKTOP-JB4FO9V\MSSQLEXPRESS;database=Northwind;uid=sa;pwd=123" Microsoft.EntityFrameworkCore.SqlServer -o Models --context-dir Data -c NorthwindContext

// 