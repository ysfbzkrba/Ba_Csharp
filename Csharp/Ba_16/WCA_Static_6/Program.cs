using System;
using WCA_Static_6.Models;

namespace WCA_Static_6
{
    class Program
    {
        static void Main(string[] args)
        {
            double Pi = Library.pi;

            double Pin = Kutuphane.pi;

            Kutuphane kutup = new Kutuphane();
            string connection = kutup.ConnectionString;

            
        }
    }
}
