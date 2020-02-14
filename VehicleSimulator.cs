using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADPP_CW
{
    class VehicleSimulator
    {
        Car car;
        Graphics2D graphics;
        Instructor instructor;
        bool instructorEnabled = false;

        public VehicleSimulator(Car current, Instructor instructor)
        {
            this.car = current;
            this.instructor = instructor;
            this.graphics = new Graphics2D();
        }

        public Car CurrentCar
        {
            get => car;
            set => car = value;
        }

        public bool InstructorEnabled
        {
            get => instructorEnabled;
            set
            {
                instructorEnabled = value;
                if (value)
                {
                    
                }
                else
                {

                }
            }
        }
    }
}
