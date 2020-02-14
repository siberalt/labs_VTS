using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace ADPP_CW
{
    class Graphics2D
    {
        PictureBox picbox;
        GraphicGroup group = new GraphicGroup();
        Color backColor = Color.GreenYellow;

        public Graphics2D()
        {

        }

        public Graphics2D(Color backColor)
        {
            this.backColor = backColor;
        }

        public void AddModel(IGraphicComponent component)
        {
            group.AddComponent(component);
        }

        public Graphics2D(PictureBox picbox)
        {
            picbox.Paint += new PaintEventHandler(paint);
            this.picbox = picbox;
        }

        public void Draw(Graphics e)
        {
            if (picbox != null) e.Clear(picbox.BackColor);
            else e.Clear(backColor);
            group.Draw(e);
        }

        private void paint(object sender, PaintEventArgs e)
        {
            Draw(e.Graphics);
        }

        public static System.Windows.Point Convert(System.Drawing.Point point) => new System.Windows.Point(point.X, point.Y);
        public static System.Drawing.Point Convert(System.Windows.Point point) => new System.Drawing.Point((int)point.X, (int)point.Y);
    }
}
