using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADPP_CW
{
    enum CarTypes
    {
        M_Vas2120
    }

    class CarBuilder
    {
        Car car;
        CarTypes type;
        String steeringWheelAdapter;

        public CarBuilder(CarTypes type)
        {
            car = new Car();
            this.type = type;
        }

        public CarBuilder(CarTypes type,String steeringWheelAdapter):this(type)
        {
            this.steeringWheelAdapter = steeringWheelAdapter;
        }

        public void BuildFromPool()
        {
            switch (type)
            {
                case CarTypes.M_Vas2120:
                    car.Width = 60;
                    car.Length = 100;
                    car.ModelFromFile = "car.jpg";
                    if(steeringWheelAdapter!=null)
                        car.SteeringWheel = (SteeringWheel)DevicePool.Instance[DeviceType.SteeringWheel, steeringWheelAdapter];
                    else
                        car.SteeringWheel = (SteeringWheel)DevicePool.Instance[DeviceType.SteeringWheel];
                    car.Transmission = (Transmission)DevicePool.Instance[DeviceType.Transmission];
                    car.Handbrake = (Handbrake)DevicePool.Instance[DeviceType.Handbrake];
                    car.Windshield = (Windshield)DevicePool.Instance[DeviceType.Windshield];
                    car.GasPedal = (GasPedal)DevicePool.Instance[DeviceType.GasPedal];
                    car.ClutchPedal = (ClutchPedal)DevicePool.Instance[DeviceType.ClutchPedal];
                    car.BrakePedal = (BrakePedal)DevicePool.Instance[DeviceType.BrakePedal];
                    car.Engine = (EngineIgnition)DevicePool.Instance[DeviceType.EngineIgnition];
                    break;

            }
        }

        public void Build(Graphics2D graphics,CarModel model)
        {
            switch (type)
            {
                case CarTypes.M_Vas2120:
                    car.Width = 60;
                    car.Length = 100;
                    car.Model = model;
                    car.SteeringWheel = new KeyboardSteeringWheel();
                    car.Handbrake = new KeyboardHandbrake();
                    car.Windshield = new MonitorWindshield(graphics);
                    car.GasPedal = new GasPedal();
                    car.ClutchPedal = new ClutchPedal();
                    car.Transmission = new MechanicTransmission(0, 5, car.ClutchPedal);
                    car.BrakePedal = new BrakePedal();
                    car.Engine = new KeyboardEngine();
                    break;

            }
        }

        public Car Result => car;

    }
}
