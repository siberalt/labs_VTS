using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Point = System.Windows.Point;

namespace ADPP_CW
{
    class Vector2D
    {
        double x;
        double y;

        public double X
        {
            get => x;
            set => x = value;
        }

        public double Y
        {
            get => y;
            set => y = value;
        }

        public Vector2D(double x,double y)
        {
            this.x = x;
            this.y = y;
        }

        public double Length => Math.Sqrt(x * x + y * y);

        public static double Angle(Vector2D v1,Vector2D v2)
        {
            return Math.Acos(Product(v1, v2) / (v1.Length * v2.Length));
        }
        public void Negate()
        {
            this.X *= -1;
            this.Y *= -1;
        }

        public static Vector2D Negate(Vector2D vec) => new Vector2D(-vec.X, -vec.Y);

        public static double Product(Vector2D v1, Vector2D v2) => v1.X * v2.X + v1.Y * v2.Y;

        public static Vector2D Normilize(Vector2D vector)
        {
            double len = vector.Length;
            vector.X /= len;
            vector.Y /= len;
            return vector;
        }
        
    }

    class GraphicLine : IGraphicComponent
    {
        Point point1;
        Point point2;
        Color color = Color.Black;

        public Point Point1
        {
            get => point1;
            set => point1 = value;
        }

        public Point Point2
        {
            get => point2;
            set => point2 = value;
        }

        

        public System.Drawing.Point Position { get => Graphics2D.Convert(point1); set => point1 = Graphics2D.Convert(value); }

        public Vector2D Vector => new Vector2D(point2.X - point1.X,point2.Y - point1.Y);

        public static double Angle(GraphicLine l1, GraphicLine l2) => Vector2D.Angle(l1.Vector, l2.Vector);

        

        public GraphicLine()
        {

        }

        public GraphicLine(Point point1,Point point2)
        {
            this.point1 = point1;
            this.point2 = point2;
        }

        public GraphicLine(Point point1, Point point2, Color color) : this(point1, point2)
        {
            this.color = color;
        }

        public void Draw(Graphics gr)
        {
            gr.DrawLine(new Pen(color),
                        Graphics2D.Convert(point1),
                        Graphics2D.Convert(point2));
        }

        public void Move(double dx, double dy)
        {
            point1.X += dx;
            point1.Y += dy;
            point2.X += dx;
            point2.Y += dy;
        }

        public void Rotate(System.Drawing.Point center, Vector axis, double angle)
        {
            throw new NotImplementedException();
        }

        public void Rotate(Vector axis, double angle)
        {
            throw new NotImplementedException();
        }

        public void Rotate(double alpha)
        {
            point2.X = -Math.Sin(alpha) * (point2.Y - point1.Y) + Math.Cos(alpha) * (point2.X - point1.X) + point1.X;
            point2.Y = Math.Cos(alpha) * (point2.Y - point1.Y) + Math.Sin(alpha) * (point2.X - point1.X) + point1.Y;
        }

        public void SetGraphics2D(Graphics2D graphics2D)
        {
            throw new NotImplementedException();
        }
    }
}
