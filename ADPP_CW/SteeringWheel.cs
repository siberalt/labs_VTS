using System;

namespace ADPP_CW
{
    public abstract class SteeringWheel:Device
    {
        protected int turn;
        protected double angle;
        protected double leftLimit;
        protected double rightLimit;

        public int Turn => turn;
        public double Angle => angle;

        public override DeviceType Type => DeviceType.SteeringWheel;

        public override object Data => new Tuple<int,double>(turn,angle);

        public override bool DevicesFound => true;

        public override abstract Device Clone();

        public override abstract void Execute(object obj);
    }
}
