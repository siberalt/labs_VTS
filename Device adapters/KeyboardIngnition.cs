using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADPP_CW
{
    class KeyboardIngnition: EngineIgnition
    {
        public KeyboardIngnition()
        {
            Form1.Form.KeyDown += new System.Windows.Forms.KeyEventHandler(keyDown);
        }

        private void keyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.E) return;
            hasIgnition = !hasIgnition;
            base.Update(HasIngnition);
        }
    }
}
