using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADPP_CW
{
    public abstract class Transmission: Device
    {
        protected int currentGear;
        protected int minGear;
        protected int maxGear;

        public int CurrentGear => currentGear;

        public override object Data => currentGear;

        public override bool DevicesFound => true;

        public override DeviceType Type => DeviceType.Transmission;

        public abstract override Device Clone();

        public abstract override void Execute(object obj);
    }
}
