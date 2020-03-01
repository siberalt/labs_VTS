
namespace ADPP_CW
{
    public class Handbrake : Device
    {
        protected bool anchored = true;
        public bool Anchored => anchored;
        public override DeviceType Type => DeviceType.Handbrake;

        public override object Data => anchored;

        public override bool DevicesFound => true;

        public override Device Clone()
        {
            return null;
        }

        public override void Execute(object obj)
        {
            anchored = (bool)obj;
            base.Update(obj);
        }
    }
}
