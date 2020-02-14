using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            Form1.Form.KeyDown += new System.Windows.Forms.KeyEventHandler(keyDown);
        }

        private void keyDown(object sender, KeyEventArgs e)
        {
            if (Keys.D0 <= e.KeyCode && e.KeyCode <= 1 + Keys.D0)
            {
                currentGear = e.KeyCode - Keys.D0;
                base.Update(currentGear);
            }
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

        }
    }
}
