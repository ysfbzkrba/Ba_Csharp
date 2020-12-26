using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_Constructor_4.Models
{
    // a class is internal by default
    // internal => asmbly(project) can reach. others can't.
    class Employ
    {
        // ctor tabtab

        public Employ()
        {

        }
        public Employ(string FName)
        {
            this.FName = FName;
        }
        public Employ(string FName, string LName) : this(FName)
        {
            this.LName = LName;
        }
        public Employ(string FName, string LName, string Mail) : this(FName,LName)
        {
            this.Mail  = Mail;
        }
        public Employ(string FName, string LName, string Mail, string Phone)
        {
            this.FName = FName;
            this.LName = LName;
            this.Mail = Mail;
            this.Phone = Phone;
        }
        public Employ(string FName, string LName, string Mail, string Phone, string Address)
        {
            this.FName = FName;
            this.LName = LName;
            this.Mail = Mail;
            this.Phone = Phone;
            this.Address = Address;
        }



        public int ID { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Mail { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }





    }

}
