using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADPP_CW
{

    abstract class State
    {


        protected Instructor instructor;
        public State(Instructor instructor)
        {
            this.instructor = instructor;
        }

        public abstract void brakePedalHandler(object sender, object obj);

        public abstract void clutchPedalHandler(object sender, object obj);

        public abstract void engineHandler(object sender, object obj);

        public abstract void gasPedalHandler(object sender, object obj);

        public abstract void handbrakeHandler(object sender, object obj);

        public abstract void steeringWheelHandler(object sender, object obj);

        public abstract void transmissionHandler(object sender, object obj);
    }
}
        
            
        
    

