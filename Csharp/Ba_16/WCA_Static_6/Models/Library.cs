using System;
using System.Collections.Generic;
using System.Text;

namespace WCA_Static_6.Models
{
    // STATIC CLASS
    public static class Library
    {
        public static double pi = 3.14;
    }

    public class Kutuphane
    {
        public static double pi = 3.14;

        public string  ConnectionString = "server=.;database=Northwind;uid=sa;pwd=123";

        public readonly string Connection = "read only connection.";

        public static readonly string StaticConnection = "static read only connection.";

        public const string NewConnectionString = "new connection";

        public string MyConnectionString1 { get; } = "server=.;database=Northwind;uid=sa;=pwd=123";
      
        public string MyConnectionString2
        {
            get
            {
                return "server=.;database=Northwind;uid=sa;=pwd=123";
            }
        }
      
        public string MyConnectionString3 { get => "server=.;database=Northwind;uid=sa;=pwd=123"; }

        public Library()
        {
            this.MyConnectionString4 = "server=.;database=Northwind;uid=sa;=pwd=123";
        }
        public string MyConnectionString4 { get; }



    }
}
