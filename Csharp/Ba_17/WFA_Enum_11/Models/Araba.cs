using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_Enum_11.Models
{

    public enum Color
    {
        white, green, blue, black
    }
    public enum DoorCount
    {
        Two,Four,Six
    }
    public enum Rims
    {
        Alloy, Aluminum, Gold, Chrome, CarbonFiber
    }

    public enum Engine
    {
        e_2k,e_16,e_1,e_12,_e4k,e_2jz
    }
        

    class Araba
    {


        public Color Color { get; set; }

        public DoorCount DoorCount { get; set; }

        public Rims Rims { get; set; }

        public Engine Engine { get; set; }

    }
}
