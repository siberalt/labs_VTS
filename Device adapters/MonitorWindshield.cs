using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADPP_CW
{
    class MonitorWindshield : Windshield
    {
        public MonitorWindshield(Graphics2D graphics)
        {
            this.graphics = graphics;
            Form1.Picture.Paint += new System.Windows.Forms.PaintEventHandler(paint);
        }

        public MonitorWindshield()
        {
            Form1.Picture.Paint += new System.Windows.Forms.PaintEventHandler(paint);
        }

        private void paint(object sender, PaintEventArgs e)
        {
            if (graphics == null) return;
            graphics.Draw(e.Graphics);
        }

        public override void Execute(object obj)
        {
            if (obj != null) graphics = (Graphics2D)obj;
            Form1.Picture.Invalidate();
        }

        public void Execute()
        {
            Execute(null);
        }
    }
}
