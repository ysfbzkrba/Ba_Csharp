using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_Encapsulation_3.Models
{
    class Bank
    {
        private double _balance; // bank account.


        public double GetBalance()
        {
            //may add validation process.
            return this._balance;
        }
        public void SetBalance(double balance)
        {
            //may add validation process.
            this._balance = balance;
        }



    }
}
