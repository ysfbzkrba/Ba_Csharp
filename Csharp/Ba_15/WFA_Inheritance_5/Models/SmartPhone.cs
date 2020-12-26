using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_Inheritance_5.Models
{
    class SmartPhone : Mobile
    {
        public SmartPhone()
        {
            base._phoneType = "5G Mobile";

        }
        public SmartPhone(string brand, string connectionType, bool camera, bool frontCamera, bool isTouch) : base(brand, connectionType, camera)
        {
            base._phoneType = "5G Mobile";
            this.HasFrontCamera = frontCamera;
            this.isTouch = isTouch;
        }
        public bool HasFrontCamera { get; set; }
        public bool isTouch { get; set; }

        public string DoVideoCall() => this.HasFrontCamera? "You can make video calls" : "senin telefonunun kamerası yok beni çıldırtmakmı istiyorsun (bymügeanlı)";

        public string Touch() => this.isTouch ? "Touch Me!" : "senin telefonunun dokunmatiği yok beni çıldırtmak mı istiyorsun?!(bymügeanlı)";

        public override string Sound()
        {
            return "Smart Sound";
        }

    }
}
