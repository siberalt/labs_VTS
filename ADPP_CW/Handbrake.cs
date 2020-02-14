using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADPP_CW
{
    class Handbrake : Device
    {
        protected bool anchored = true;
        public bool Anchored => anchored;
        public override DeviceType Type => DeviceType.Handbrake;

        public override object Data => anchored;

        public override bool DevicesFound => true;

        public override Device Clone()
        {
            return null;
        }

        public override void Execute(object obj)
        {
            
        }
    }
}
