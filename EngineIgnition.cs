using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADPP_CW
{
    abstract class EngineIgnition : Device
    {
        protected bool hasIgnition = false;
        public bool HasIngnition => hasIgnition;
        public override DeviceType Type => DeviceType.EngineIgnition;

        public override object Data => hasIgnition;

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
