using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADPP_CW
{
    class KeyboardEngine:EngineIgnition
    {
        public KeyboardEngine()
        {
            Form1.Form.KeyDown += new System.Windows.Forms.KeyEventHandler(keyDown);
        }

        private void keyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.E) return;
            hasIgnition = !hasIgnition;
            base.Update(HasIngnition);
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
