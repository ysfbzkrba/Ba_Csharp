using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_Inheritance_5.Models
{
    public class BasePhone
    {
        private string _brand;
        protected string _phoneType;
        private string _connectionType;
        public BasePhone()
        {
            this._phoneType = "Ahizeli Telefon";
        }
        public BasePhone(string brand, string connectionType):this()
        {
            this._brand = brand;
            this._connectionType = connectionType;
        }

        public string PhoneType { get => _phoneType; }
        public string ConnectionType { get=>_connectionType; set=>_connectionType=value; }
        public string Brand 
        {
            get 
            {
                return _brand; 
            } 
            set 
            {
                _brand = value; 
            } 
        }
       
        
        //public string Sound() { return ""; }
        public virtual string Sound() => "default phone sound";
    }
}
