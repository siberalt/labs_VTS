using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADPP_CW
{
    class MechanicTransmission : Transmission
    {
        ClutchPedal clutch = null;
        public MechanicTransmission(int min,int max)
        {
            maxGear = max;
            minGear = min;
            currentGear = 0;
            Form1.Form.KeyDown += new System.Windows.Forms.KeyEventHandler(keyDown);
        }

        public MechanicTransmission(int min, int max,ClutchPedal clutch) : this(min,max)
        {
            this.clutch = clutch;
        }

        public ClutchPedal ClutchPedal
        {
            get => clutch;
            set => clutch = value;
        }

        private void keyDown(object sender, KeyEventArgs e)
        {
            if (!clutch.HasPressure) return;
            if (Keys.D0 <= e.KeyCode && e.KeyCode <= maxGear + Keys.D0)
            {
                currentGear = e.KeyCode - Keys.D0;
                base.Update(currentGear);
            }
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
