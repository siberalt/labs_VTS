

namespace ADPP_CW
{
    public interface ICarListener
    {
        void steeringWheelHandler(object sender, object obj);

        void gasPedalHandler(object sender, object obj);

        void clutchPedalHandler(object sender, object obj);

        void brakePedalHandler(object sender, object obj);

        void transmissionHandler(object sender, object obj);

        void handbrakeHandler(object sender, object obj);

        void engineHandler(object sender, object obj);
    }
}
