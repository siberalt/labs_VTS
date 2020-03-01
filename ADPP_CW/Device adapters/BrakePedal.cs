
namespace ADPP_CW
{
    public class BrakePedal : Pedal
    {
        public BrakePedal()
        {

        }

        public override DeviceType Type => DeviceType.BrakePedal;

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
