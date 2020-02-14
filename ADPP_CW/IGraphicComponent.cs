using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Drawing;
using Point = System.Drawing.Point;

namespace ADPP_CW
{
    interface IGraphicComponent
    {
        Point Position { get; set; }
        void SetGraphics2D(Graphics2D graphics2D);

        void Draw(Graphics gr);
        void Move(double dx, double dy);
        void Rotate(Point center, Vector axis,double angle);
        void Rotate(Vector axis, double angle);
    }
}
