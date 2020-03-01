

namespace ADPP_CW
{
    public abstract class Pedal: Device
    {
        protected double pressure;
        public double Pressure => pressure;

        public bool HasPressure => pressure > 0;

        public override object Data => pressure;

        public override bool DevicesFound => true;
    }
}
