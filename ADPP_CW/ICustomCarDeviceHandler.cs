using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADPP_CW
{
    interface ICustomCarDeviceHandler
    {
        void HandleDevice(CustomCar car,Device dev ,object obj);

    }
}
