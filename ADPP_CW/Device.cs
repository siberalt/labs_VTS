using System;
using System.Collections.Generic;

namespace ADPP_CW
{
    public enum DeviceType
    {
        Undefined,
        SteeringWheel,
        Transmission,
        GasPedal,
        BrakePedal,
        Handbrake,
        Windshield,
        ClutchPedal,
        Headlights,
        EngineIgnition
    }
    public delegate void HandleProc(Device sender,object obj);
    abstract public class Device
    {
        protected static int sequenceId = 0;
        protected int id;
        protected String description;
        protected List<HandleProc> handlers = new List<HandleProc>();    

        public Device()
        {
            this.id = sequenceId++;
        }

        public string Description { get => description; set => description = value; }
        public int ID { get => id; }    

        public void AddHandler(HandleProc handler)
        {
            handlers.Add(handler);
        }

        public void RemoveHandler(HandleProc handler)
        {
            handlers.Remove(handler);
        }

        public void Update(object value)
        {
            foreach (HandleProc handler in handlers)
                handler(this, value);
        }

        public abstract DeviceType Type { get; }
        public abstract object Data { get; }
        public abstract bool DevicesFound { get; }
        public abstract Device Clone();
        public abstract void Execute(object obj);
    }
}
