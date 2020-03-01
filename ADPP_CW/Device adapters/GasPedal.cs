

namespace ADPP_CW
{
    public class GasPedal : Pedal
    {
        public GasPedal()
        {

        }

        public override DeviceType Type => DeviceType.GasPedal;

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
