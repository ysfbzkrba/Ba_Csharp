using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_Interface_13.Models
{
    public interface IFootballer
    {
        string Name { get; set; }
        string LastName { get; set; }
        string Number { get; set; }
        string Team { get; set; }
        bool National { get; set; }
        byte Control { get; set; }
        byte Aggro { get; set; }
        string Pos { get; set; }
        void Shoot();
    }
}
