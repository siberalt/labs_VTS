
namespace ADPP_CW
{
    public class Point
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

        public Point(double x,double y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
