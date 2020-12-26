using System;
using System.Collections.Generic;
using System.Text;

namespace WCA_Polymorphism_8.Models
{
    public class CoreEntity<T>
    {
        public CoreEntity() { this.CreatedDate = DateTime.Now; }
        public T ID { get; set; }
        public virtual DateTime CreatedDate { get; }
    }

    public class Category : CoreEntity<int>
    {
        public override DateTime CreatedDate => base.CreatedDate.AddDays(5);
    }

    public class Product : CoreEntity<int> { }
    public class Shipper : CoreEntity<int> { }
    public class Customer : CoreEntity<string> { }
    public class Employee : CoreEntity<Guid> { }
}
