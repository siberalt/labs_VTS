using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ADPP_CW
{
    class GraphicText : IGraphicComponent
    {
        public System.Drawing.Point Position { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Draw(Graphics gr)
        {
            throw new NotImplementedException();
        }

        public void Move(double dx, double dy)
        {
            throw new NotImplementedException();
        }

        public void Rotate(System.Drawing.Point center, Vector axis, double angle)
        {
            throw new NotImplementedException();
        }

        public void Rotate(Vector axis, double angle)
        {
            throw new NotImplementedException();
        }

        public void SetGraphics2D(Graphics2D graphics2D)
        {
            throw new NotImplementedException();
        }
    }
}
