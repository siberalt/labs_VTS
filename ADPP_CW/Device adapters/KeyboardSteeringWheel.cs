using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace ADPP_CW
{
    class KeyboardSteeringWheel : SteeringWheel
    {
        public KeyboardSteeringWheel()
        {
            Form1.Form.KeyDown += new System.Windows.Forms.KeyEventHandler(keyDown);
        }

        private void keyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.D && e.KeyCode != Keys.A) return;
            if (e.KeyCode == Keys.D) angle = 1;
            if (e.KeyCode == Keys.A) angle = -1;
            base.Update(Angle);
        }

        public KeyboardSteeringWheel(KeyboardSteeringWheel value)
        {
            this.Description = value.Description;
        }

        public override Device Clone()
        {
            return null;
        }
        
        void Handle()
        {

        }

        public override void Execute(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
