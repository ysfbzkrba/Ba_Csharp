using System;
using System.Collections.Generic;
using System.Text;

namespace WCA_Abstract_12.Models
{
    public abstract class Enstruman
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public string Aciklama { get; set; }
        public decimal Fiyat { get; set; }
        public Hammadde Hammadde { get; set; }




        //abstract
        public abstract string Sound();

        //requires override.!

        //public virtual string Sound() => "Enstruman Sesi";  does not require override.

    }
    public class Muzisyen
    {
        public string Name { get; set; }
        public string Soyadi { get; set; }
        public Enstruman Enstruman { get; set; }
    }

    // right click > quick actions > move type to "".cs
}
