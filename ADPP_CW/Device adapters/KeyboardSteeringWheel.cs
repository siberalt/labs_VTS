
using System;

namespace ADPP_CW
{
    public class KeyboardSteeringWheel : SteeringWheel
    {
        public KeyboardSteeringWheel()
        {
            
        }

        public KeyboardSteeringWheel(KeyboardSteeringWheel value)
        {
            this.Description = value.Description;
        }

        public override Device Clone()
        {
            return null;
        }
        

        public override void Execute(object obj)
        {
            Tuple<int, double> tuple = (Tuple<int, double>)obj;
            this.angle = tuple.Item2;
            this.turn = tuple.Item1;
            base.Update(obj);
        }
    }
}
