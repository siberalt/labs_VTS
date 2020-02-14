using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADPP_CW
{
    abstract class Windshield : Device
    {
        protected Graphics2D graphics;
        public Graphics2D Graphics { get => graphics; set => graphics = value; }

        public override object Data => null;

        public override bool DevicesFound => true;

        public override DeviceType Type => DeviceType.Windshield;

        public override Device Clone()
        {
            return null;
        }
    }
}
