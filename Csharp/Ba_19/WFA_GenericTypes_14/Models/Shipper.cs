using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_GenericTypes_14.Models
{
    class Shipper
    {
        public string CompanyName { get; set; }
        public string Phone { get; set; }

        public override string ToString()
        {
            return this.CompanyName;
        }
    }
}
