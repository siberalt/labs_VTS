using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADPP_CW
{
    class Car: Vehicle
    {
        //Поля
        bool enabled = false;
        SteeringWheel steeringWheel;
        GasPedal gasPedal;
        ClutchPedal clutchPedal;
        BrakePedal brakePedal;
        Transmission transmission;
        Windshield windshield;
        Handbrake handbrake;
        EngineIgnition engine;
        List<ICarListener> handlers = new List<ICarListener>();

        //Модель
        CarModel model;

        //Свойства
        public bool Enabled
        {
            get => enabled;
            set => enabled = value;
        }

        public Graphics2D Graphics
        {
            get => windshield.Graphics;
            set => windshield.Graphics = value;
        }

        public SteeringWheel SteeringWheel
        {
            get => steeringWheel;
            set
            {
                steeringWheel = value;
                steeringWheel.AddHandler(steeringWheelHandler);
            }
        }

        public GasPedal GasPedal
        {
            get => gasPedal;
            set
            {
                gasPedal = value;
                gasPedal.AddHandler(gasPedalHandler);
            }
        }

        public ClutchPedal ClutchPedal
        {
            get => clutchPedal;
            set
            {
                clutchPedal = value;
                clutchPedal.AddHandler(clutchPedalHandler);
            }
        }

        public BrakePedal BrakePedal
        {
            get => brakePedal;
            set
            {
                brakePedal = value;
                brakePedal.AddHandler(brakePedalHandler);
            }
        }

        public Transmission Transmission
        {
            get => transmission;
            set
            {
                transmission = value;
                transmission.AddHandler(transmissionHandler);
            }
        }

        public Windshield Windshield
        {
            get => windshield;
            set => windshield = value;
        }

        public Handbrake Handbrake
        {
            get => handbrake;
            set
            {
                handbrake = value;
                handbrake.AddHandler(handbrakeHandler);
            }
        }

        public EngineIgnition Engine
        {
            get => engine;
            set
            {
                engine = value;
                engine.AddHandler(engineHandler);
            }
        }

        public String ModelFromFile
        {
            set => model = new CarModel(value, new System.Drawing.Size((int)Width, (int)Length));
        }

        public CarModel Model
        {
            get => model;
            set => model = value;
        }

        //Обработчики
        private void steeringWheelHandler(Device sender, object obj)
        {
            if (!enabled) return;
            model.RotateWheelVector(steeringWheel.Angle*2);
            windshield.Execute(null);
            foreach (ICarListener listener in handlers)
                listener.steeringWheelHandler(this, sender);
        }

        private void gasPedalHandler(Device sender, object obj)
        {
            if (!enabled) return;
            if (!(engine.HasIngnition && transmission.CurrentGear != 0 && !handbrake.Anchored)) return;
            Vector2D wheel = model.WheelVector;
            Vector2D forward = model.ForwardVector;
            if(transmission.CurrentGear == 5)
            {
                wheel.Negate();
                forward.Negate();
            }
            double alpha =  Math.Sign(model.Arrangment) * Vector2D.Angle(forward,wheel);
            model.Rotate(alpha);
            forward = Vector2D.Normilize(forward);
            model.Move(forward.X,forward.Y);
            windshield.Execute(null);
            foreach (ICarListener listener in handlers) 
                listener.gasPedalHandler(this, sender);
        }

        private void clutchPedalHandler(Device sender, object obj)
        {
            if (!enabled) return;
            foreach (ICarListener listener in handlers)
                listener.clutchPedalHandler(this, sender);
        }

        private void brakePedalHandler(Device sender, object obj)
        {
            if (!enabled) return;
            foreach (ICarListener listener in handlers)
                listener.brakePedalHandler(this, sender);
        }

        private void transmissionHandler(Device sender, object obj)
        {
            if (!enabled) return;
            foreach (ICarListener listener in handlers)
                listener.transmissionHandler(this, sender);
        }

        private void handbrakeHandler(Device sender, object obj)
        {
            if (!enabled) return;
            foreach (ICarListener listener in handlers)
                listener.handbrakeHandler(this, sender);
        }

        private void engineHandler(Device sender, object obj)
        {
            if (!enabled) return;
            foreach (ICarListener listener in handlers)
                listener.engineHandler(this, sender);
        }

        //Методы
        public void AddHandler(ICarListener handler)
        {
            handlers.Add(handler);
        }

        public void RemoveHandler(ICarListener handler)
        {
            handlers.Remove(handler);
        }

        public override void AddHandler(object obj)
        {
            AddHandler(obj as ICarListener);
        }

        public Car()
        {

        }

        public Car(ICarListener listener)
        {
            AddHandler(listener);
        }

    }
}
