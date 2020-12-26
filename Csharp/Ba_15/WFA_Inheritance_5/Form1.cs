using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFA_Inheritance_5.Models;

namespace WFA_Inheritance_5
{
    public partial class Form1 : Form
    {
        //string phoneType = "Telefonun Türü";
        //string connectionType = "Telefonun Bağlantı Türü";
        //string sound = "Telefonun Zil Sesi";
        //string brand = "Telefonun Markası";
        //string name = "Sınıfın Adı";


        public string Space (string text)
        {
            string aligned = "                                   :";
            int count = aligned.Length - text.Length;
            //aligned.Remove(0, count);
            //aligned.Concat(text + aligned.Remove(0, count));
            
            return string.Concat(text + new String(' ', 25 - text.Length));
        }



        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BasePhone phone = new BasePhone();
            phone.Brand = "Alcatel";
            phone.ConnectionType = "Kablolu Telefon";

            MessageBox.Show($"Telefonun Türü\t\t : {phone.GetType().Name}\nTelefonun Markası\t\t : {phone.Brand}\nTelefonun Bağlantı Türü\t : {phone.ConnectionType}\nTelefonun sesi\t\t : {phone.Sound()}");

            //MessageBox.Show($"{name.PadRight(25)} : {phone.GetType().Name}\n{brand.PadRight(25)} : {phone.Brand}\n{connectionType.PadRight(35)} : {phone.ConnectionType}\n{phoneType.PadRight(25)} : {phone.PhoneType}\n{sound.PadRight(25)} : {phone.Sound()}");
        }

        private void btnMobile_Click(object sender, EventArgs e)
        {
            Mobile phone = new Mobile();
            phone.Brand = "Nokia";
            phone.ConnectionType = "4G Mobile";

            MessageBox.Show($"Telefonun Türü\t\t : {phone.GetType().Name}\nTelefonun Markası\t\t : {phone.Brand}\nTelefonun Bağlantı Türü\t : {phone.ConnectionType}\nTelefonun sesi\t\t : {phone.Sound()}\nTelefonun Kamerası\t : {(phone.HasCamera?"Var":"Yok")}");
        }

        private void btnSmart_Click(object sender, EventArgs e)
        {
            SmartPhone phone = new SmartPhone();
            phone.Brand = "Samsung";
            phone.ConnectionType = "5G Mobile";
            phone.HasFrontCamera = true;
            phone.isTouch = true;

            //MessageBox.Show($"Telefonun Türü\t\t : {phone.GetType().Name}\nTelefonun Markası\t\t : {phone.Brand}\nTelefonun Bağlantı Türü\t : {phone.ConnectionType}\nTelefonun sesi\t\t : {phone.Sound()}\nTelefonun Kamerası\t : {(phone.HasCamera ? "Var" : "Yok")}\nTelefonun Ön Kamerası\t : {(phone.HasFrontCamera ? "Var" : "Yok")}\nTelefonun Dokunmatiği\t : {(phone.isTouch ? "Var" : "Yok")}");
            MessageBox.Show(Space("Telefonun türü") + ":" + phone.GetType().Name + "\n" + Space("Telefonun Markası") + phone.Brand + "\n" + Space("Telefonun Bağlantı Türü") + phone.ConnectionType + "\n" + Space("Telefonun Sesi")+phone.Sound());
        }
    }
}
