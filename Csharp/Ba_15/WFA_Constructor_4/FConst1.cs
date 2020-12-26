using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFA_Constructor_4.Models;

namespace WFA_Constructor_4
{
    public partial class FConst1 : Form
    {
        public FConst1()
        {
            InitializeComponent();
        }

        private void FConst1_Load(object sender, EventArgs e)
        {
            
            Employ employee = new Employ();
            employee.FName   =   "Ysf";
            employee.LName   =   "Bzkr";
            employee.Phone   =   "5555555";
            employee.Mail    =   "ysf.bkzr@hotmail.com";
            employee.Address =   "ist";

            Employ emp1 = new Employ("Murat");
            emp1.LName   =  "Vrnk";
            emp1.Phone   =  "5555555";
            emp1.Mail    =  "mrt.vrnk@hotmail.com";
            emp1.Address =  "ist";

            Employ emp2 = new Employ("Murat","Vrnk");
            emp2.Phone = "5555555";
            emp2.Mail = "mrt.vrnk@hotmail.com";
            emp2.Address = "ist";

            Employ emp3 = new Employ("Murat", "Vrnk","5555555");
            emp3.Mail = "mrt.vrnk@hotmail.com";
            emp3.Address = "ist";

            Employ emp4 = new Employ("Murat", "Vrnk", "5555555", "mrt.vrnk@hotmail.com");
            emp4.Address = "ist";

            Employ emp5 = new Employ("Murat", "Vrnk", "5555555", "mrt.vrnk@hotmail.com", "ist");

        }
    }
}
