using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADPP_CW
{
    class KeyboardHandbrake:Handbrake
    {
        public KeyboardHandbrake()
        {
            anchored = true;
            Form1.Form.KeyDown += new System.Windows.Forms.KeyEventHandler(keyDown);
        }

        private void keyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.H) return;
            anchored = !anchored;
            base.Update(Anchored);
        }
    }
}
