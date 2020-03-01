

namespace ADPP_CW
{
    public class ClutchPedal : Pedal
    {
        public ClutchPedal()
        {

        }

        public override DeviceType Type => DeviceType.ClutchPedal;

        public override Device Clone()
        {
            return null;
        }

        public override void Execute(object obj)
        {
            base.Update(obj);
        }
    }
}
