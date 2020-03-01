using System;

namespace ADPP_CW.Device_adapters
{
    public class AutomaticTransmission : Transmission
    {
        GasPedal gasPedal;
        int move = 0;
        public AutomaticTransmission(int min,int max, GasPedal pedal)
        {
            this.minGear = min;
            this.maxGear = max;
            this.gasPedal = pedal;
            this.gasPedal.AddHandler(gasHandler);
        }

        private void gasHandler(Device sender, object obj)
        {
            if (currentGear != 0 && currentGear != 1) return;
            
            move++;
            if (move == 100) 
            {
                move = 0;
                if (currentGear < maxGear) currentGear++;
            }
            
            base.Update(obj);
        }

        public override Device Clone()
        {
            return null;
        }

        public override void Execute(object obj)
        {
            currentGear = (int)obj;
            base.Update(currentGear);
        }
    }
}
