using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADPP_CW
{
    class Instructor : ICarListener
    {
        State state;
        protected bool clutch = false;
        protected bool engine = false;
        protected bool handbrake = false;
        protected int gear = 0;
        protected double angle = 0;

        public double Angle => angle;

        public bool HasClutch
        {
            get => clutch;
            set => clutch = value;
        }

        public bool HasEngine
        {
            get => engine;
            set => engine = value;
        }

        public bool HasHandbrake
        {
            get => handbrake;
            set => handbrake = value;
        }

        public int Gear
        {
            get => gear;
            set => gear = value;
        }

        public Instructor(State state)
        {
            this.state = state;
        }

        public Instructor()
        {
            this.state = new PrepareToMove(this);
        }

        public void ChangeState(State state)
        {
            this.state = state;
        }

        public void brakePedalHandler(object sender, object obj)
        {
            state.brakePedalHandler(sender, obj);
        }

        public void clutchPedalHandler(object sender, object obj)
        {
            state.clutchPedalHandler(sender, obj);
        }

        public void engineHandler(object sender, object obj)
        {
            state.engineHandler(sender, obj);
        }

        public void gasPedalHandler(object sender, object obj)
        {
            state.gasPedalHandler(sender, obj);
        }

        public void handbrakeHandler(object sender, object obj)
        {
            state.handbrakeHandler(sender, obj);
        }

        public void steeringWheelHandler(object sender, object obj)
        {
            angle += (obj as SteeringWheel).Angle;
            state.steeringWheelHandler(sender, obj);
        }

        public void transmissionHandler(object sender, object obj)
        {
            state.transmissionHandler(sender, obj);
        }
    }
}
