using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Point = System.Drawing.Point;

namespace ADPP_CW
{
    class CarModel : IGraphicComponent
    {
        System.Windows.Point position;
        GraphicLine wheelVector;
        GraphicLine forwardVector;
        Graphics2D parentGraphic;
        Vehicle parentVehicle;
        Bitmap model;
        double max;
        Point center;

        public Vector2D WheelVector => wheelVector.Vector;
        public Vector2D ForwardVector => forwardVector.Vector;

        public CarModel(String modelFile, System.Drawing.Size size)
        {
            model = new Bitmap(modelFile);
            model = new Bitmap(model, size);
            max = Math.Max(model.Width, model.Height) + 10;
            center = new Point(((int)max - model.Width) / 2, ((int)max - model.Height) / 2);
            Color pixel;
            for (int i = 0; i < model.Height; i++)
                for (int j = 0; j < model.Width; j++)
                {
                    pixel = model.GetPixel(j, i);
                    if (pixel.R == Color.White.R &&
                        pixel.B == Color.White.B &&
                        pixel.G == Color.White.G) model.SetPixel(j, i, Color.FromArgb(byte.MinValue, pixel.R, pixel.G, pixel.B));
                }
        }

        public CarModel(String modelFile, System.Drawing.Size size,Point startPos):this(modelFile,size)
        {
            position = Graphics2D.Convert(startPos);
            System.Windows.Point p1 = new System.Windows.Point(startPos.X, startPos.Y);
            System.Windows.Point p2 = new System.Windows.Point(startPos.X + 70, startPos.Y);
            forwardVector = new GraphicLine(p1,p2,Color.Yellow);

            wheelVector = new GraphicLine(p1, p2, Color.Aqua);
        }

        public System.Drawing.Point Position
        {
            get => Graphics2D.Convert(position);
            set
            {
                position = Graphics2D.Convert(value);
                forwardVector.Position = Graphics2D.Convert(position);
            }
        }

        double angle = 0;
        Bitmap newPic;
        public void Draw(Graphics gr)
        {
            if (model == null) return;
            
            if (newPic == null)
            {
                newPic = new Bitmap((int)max, (int)max);
                using(Graphics graphics = Graphics.FromImage(newPic))
                {
                    graphics.DrawImage(model, center);
                }
            }
            
            gr.DrawImage(newPic, new PointF(Position.X - (newPic.Width / 2), Position.Y - (newPic.Height / 2)));
            gr.DrawString("Тачка", new Font("Arial", 16), new SolidBrush(Color.Black), Position);
            forwardVector.Draw(gr);
            wheelVector.Draw(gr);
        }

        public void Move(double dx, double dy)
        {
            position.X += dx;
            position.Y += dy;
            forwardVector.Move(dx, dy);
            wheelVector.Move(dx, dy);
        }

        public void Rotate(System.Drawing.Point center, Vector axis, double angle)
        {
            throw new NotImplementedException();
        }

        public void Rotate(Vector axis, double angle)
        {
            throw new NotImplementedException();
        }

        public double Arrangment => -((wheelVector.Point2.X - Position.X) * (forwardVector.Point2.Y - Position.Y) - (wheelVector.Point2.Y - Position.Y) * (forwardVector.Point2.X - Position.X));

        private double ToRad(double angle) => angle * Math.PI / 180;

        public void Rotate(double alpha)
        {
            this.angle += alpha;
            double rad = ToRad(alpha);
            forwardVector.Rotate(rad);
            wheelVector.Rotate(rad);
            
            newPic = new Bitmap((int)max, (int)max);
            using (Graphics g = Graphics.FromImage(newPic))
            {
                g.TranslateTransform(newPic.Width / 2, newPic.Height / 2);
                g.RotateTransform((float)(angle));
                g.TranslateTransform(-(newPic.Width / 2), -(newPic.Height / 2));
                g.DrawImage(model, center);
            }
        }

        public void RotateWheelVector(double alpha)
        {
            wheelVector.Rotate(ToRad(alpha));
        }

        public void SetGraphics2D(Graphics2D graphics2D)
        {
            this.parentGraphic = graphics2D;
        }
    }
}
