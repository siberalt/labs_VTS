using System.Collections.Generic;

namespace ADPP_CW
{
    public class Car: Vehicle
    {
        double speed = 0;
        //Поля
        bool enabled = false;
        Point pos = new Point(0,0);
        SteeringWheel steeringWheel;
        GasPedal gasPedal;
        ClutchPedal clutchPedal;
        BrakePedal brakePedal;
        Transmission transmission;
        Handbrake handbrake;
        EngineIgnition engine;
        List<ICarListener> handlers = new List<ICarListener>();

        //Свойства
        public Point Position
        {
            set => pos = value;
            get => pos;
        }
        
        public double Speed
        {
            get => speed;
        }

        public bool Enabled
        {
            get => enabled;
            set => enabled = value;
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

        //Обработчики
        private void steeringWheelHandler(Device sender, object obj)
        {
            if (!enabled) return;
            foreach (ICarListener listener in handlers)
                listener.steeringWheelHandler(this, sender);
        }

        private void gasPedalHandler(Device sender, object obj)
        {
            if (!enabled) return;
            speed = 1;
            pos.X += 1;
            pos.Y += 1;
            if (!(engine.HasIngnition && transmission.CurrentGear != 0 && !handbrake.Anchored)) return;

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
            speed = 0;
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
