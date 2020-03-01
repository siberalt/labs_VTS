using System;

namespace ADPP_CW
{
    public abstract class Vehicle
    {
        static Vehicle currentVehicle;
        public static Vehicle CurrentVehicle => currentVehicle;

        double weight;
        double acceleration;
        double maxSpeed;
        double height;
        double width;
        double length;
        String description;

        public double Weight
        {
            get => weight;
            set => weight = value;
        }

        public double Acceleration
        {
            get => acceleration;
            set => acceleration = value;
        }

        public double MaxSpeed
        {
            get => maxSpeed;
            set => maxSpeed = value;
        }

        public double Height
        {
            get => height;
            set => height = value;
        }

        public double Width
        {
            get => width;
            set => width = value;
        }

        public double Length
        {
            get => length;
            set => length = value;
        }


        public Vehicle()
        {
            currentVehicle = this;
        }

        public String Description
        {
            get => description;
            set => description = value;
        }

        public abstract void AddHandler(object obj);
        
    }
}
