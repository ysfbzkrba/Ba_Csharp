using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFA_Struct_7.Models;

namespace WFA_Struct_7
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        Kitap kitap;
        private void btnClass_Click(object sender, EventArgs e)
        {
            kitap = new Kitap();
            kitap.BasimYili = DateTime.Now;
            kitap.KitapAdi = "Fakirler";
            kitap.SayfaSayisi = 1;
            kitap.Tur = "Yoksulluk";
            kitap.YayinEvi = "Fakirler Sendikası";
            kitap.YazarAdi = "Tolstoy";
        }

        Book book;
        private void btnStruct_Click(object sender, EventArgs e)
        {
            book = new Book();
            book.BasimYili = DateTime.Now;
            book.KitapAdi = "Züğürtler";
            book.SayfaSayisi = 1;
            book.Tur = "Züğürtlük";
            book.YayinEvi = "Züğürtlük Yüksek Okulu";
            book.YazarAdi = "Dosdoyevski";
        }
    }
}
