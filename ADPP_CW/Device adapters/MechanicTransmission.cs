

namespace ADPP_CW
{
    public class MechanicTransmission : Transmission
    {
        ClutchPedal clutch = null;
        public MechanicTransmission(int min,int max)
        {
            maxGear = max;
            minGear = min;
            currentGear = 0;
        }

        public MechanicTransmission(int min, int max,ClutchPedal clutch) : this(min,max)
        {
            this.clutch = clutch;
        }

        public ClutchPedal ClutchPedal
        {
            get => clutch;
            set => clutch = value;
        }


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
