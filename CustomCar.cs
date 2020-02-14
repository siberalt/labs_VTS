using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADPP_CW
{
    class CustomCar : Vehicle
    {
        List<Device> devices = new List<Device>();
        ICustomCarDeviceHandler commonHandler;
        Dictionary<int, ICustomCarDeviceHandler> handlers = new Dictionary<int, ICustomCarDeviceHandler>();
        IGraphicComponent model;

        public IGraphicComponent Model
        {
            get => model;
            set => model = value;
        }

        public CustomCar(IGraphicComponent component)
        {
            this.model = component;
        }

        public CustomCar(IGraphicComponent component,ICustomCarDeviceHandler handler) : this(component)
        {
            this.commonHandler = handler;
        }

        public void AddDevice(Device device,ICustomCarDeviceHandler handler)
        {
            handlers.Add(device.ID, handler);
            device.AddHandler(CommonHandler);
            devices.Add(device);
        }

        public void AddDevice(Device device)
        {
            device.AddHandler(CommonHandler);
        }

        public void RemoveDevice(Device device)
        {
            handlers.Remove(device.ID);
            device.RemoveHandler(CommonHandler);
            devices.Remove(device);          
        }

        public void CommonHandler(Device sender,object obj)
        {
            if (commonHandler != null) commonHandler.HandleDevice(this, sender, obj);
            try
            {               
                handlers[sender.ID].HandleDevice(this, sender, obj);
            }
            catch (Exception e) { }
        }

        public override void AddHandler(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
