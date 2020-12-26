using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_Inheritance_5.Models
{
    public class Mobile :BasePhone
    {
        public Mobile()
        {
            base._phoneType = "Mobile";
        }
        public Mobile(string brand, string connectionType, bool camera) : base(brand, connectionType)
        {
            this.HasCamera = camera;
            base._phoneType = "Mobile";
        }
        
        public bool HasCamera = true;
        public string TakePhoto() => this.HasCamera ? "You can take a photo" : "senin telefonunun kamerası yok beni çıldırtmakmı istiyorsun (bymügeanlı)";

        public override string Sound()
        {
            return "Mobile Sound" ;
        }


    }
}
