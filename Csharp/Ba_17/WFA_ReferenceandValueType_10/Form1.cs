using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_ReferenceandValueType_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        class Student
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }

        struct Ogrenci
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }


        private void btnRef_Click(object sender, EventArgs e)
        {
            Student st = new Student();
            st.FirstName = "Murat";
            st.LastName = "Vuranok";
            Student st1 = st;
            st1.FirstName = "Ahmet";

            MessageBox.Show($"{st.FirstName}-{st1.FirstName}");
        }

        private void btnValue_Click(object sender, EventArgs e)
        {
            Ogrenci og = new Ogrenci();
            og.FirstName = "murat";
            og.LastName = "vuranok";
            Ogrenci og1 = og;
            og1.FirstName = "ahmet";
            MessageBox.Show($"{og.FirstName}-{og1.FirstName}");
            MessageBox.Show($"{og.GetHashCode()}/{og1.GetHashCode()}");

        }

        private void btnExample_Click(object sender, EventArgs e)
        {
            int[] sayilar = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] numbers = sayilar;
            numbers[2] = 30;
            MessageBox.Show(sayilar[2].ToString()+"-"+numbers[2].ToString());
            MessageBox.Show(sayilar.GetHashCode() + "-" + numbers.GetHashCode());

            int a = 5;
            int b = a;
            b = 10;
            MessageBox.Show(a.ToString());
        }
    }
}
