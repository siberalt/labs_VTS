using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADPP_CW
{
    class BrakePedal : Pedal
    {
        public BrakePedal()
        {
            Form1.Form.KeyDown += new System.Windows.Forms.KeyEventHandler(keyDown);
            Form1.Form.KeyUp += new KeyEventHandler(keyUp);
        }

        private void keyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.S) return;
            pressure = 0;
            base.Update(Pressure);
        }

        private void keyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.S) return;
            pressure = 1;
            base.Update(Pressure);
        }

        public override DeviceType Type => DeviceType.BrakePedal;

        public override Device Clone()
        {
            return null;
        }

        public override void Execute(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
