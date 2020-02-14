using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ADPP_CW
{
    class GraphicGroup: IGraphicComponent
    {
        List<IGraphicComponent> list = new List<IGraphicComponent>();

        public System.Drawing.Point Position { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Draw(Graphics gr)
        {
            foreach(IGraphicComponent comp in list)
                comp.Draw(gr);
        }

        public void AddComponent(IGraphicComponent component)
        {
            list.Add(component);
        }

        public void RemoveComponent(IGraphicComponent component)
        {
            list.Remove(component);
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
