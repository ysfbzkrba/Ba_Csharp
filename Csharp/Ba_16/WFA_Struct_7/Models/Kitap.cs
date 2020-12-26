using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_Struct_7.Models
{
    public class Kitap
    {
        public Kitap()
        {

        }

        public Kitap(int id, string kitapAdi, string yazarAdi, string yayinEvi, string tur, int sayfaSayisi, DateTime basimYili)
        {
            this.ID = id;
            this.KitapAdi = kitapAdi;
            this.YazarAdi = yazarAdi;
            this.YayinEvi = yayinEvi;
            this.Tur = tur;
            this.SayfaSayisi = sayfaSayisi;
            this.BasimYili = basimYili;
        }


        public int ID { get; set; }
        public string KitapAdi { get; set; }
        public string YazarAdi { get; set; }
        public string YayinEvi { get; set; }
        public string Tur { get; set; }
        public int SayfaSayisi { get; set; }
        public DateTime BasimYili { get; set; }
    }
}