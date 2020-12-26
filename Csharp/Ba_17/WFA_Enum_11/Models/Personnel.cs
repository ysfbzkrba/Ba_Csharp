using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_Enum_11.Models
{
    public enum Department
    {
        Junior_Architect, IT, Intern, HR, Sales, Management
    }

    class Personnel
    {
        public Department department { get; set; }
        public string Name { get; set; }
        public string Lname { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }

    }
}
