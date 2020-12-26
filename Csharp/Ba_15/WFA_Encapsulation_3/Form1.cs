using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFA_Encapsulation_3.Models;

namespace WFA_Encapsulation_3
{
    public partial class F_BankAccount : Form
    {
        public F_BankAccount()
        {
            InitializeComponent();
        }

        private void F_BankAccount_Load(object sender, EventArgs e)
        {
            Bank bank = new Bank();
            bank.SetBalance(700);
            MessageBox.Show(bank.GetBalance().ToString());
        }

        private void btnStock_Click(object sender, EventArgs e)
        {

            Product product = new Product();
            product.UnitsInStock = int.Parse() ;
            this.BackColor = Color.product.RGBColor;
        }
    }
}
