﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_Interface_13.Models
{
    class Forvette : IFootballer
    {//CTRL + H = sihir
        public string Name { get ; set ; }
        public string LastName { get ; set ; }
        public string Number { get ; set ; }
        public string Team { get ; set ; }
        public bool National { get ; set ; }
        public byte Control { get ; set ; }
        public byte Aggro { get ; set ; }
        public string Pos { get; set; }

        public void Shoot()
        {
            
        }
        public override string ToString()
        {
            return this.Name + " " + this.LastName;
        }
    }
}