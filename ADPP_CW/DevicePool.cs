using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADPP_CW
{
    class DevicePool: IEqualityComparer<Tuple<int, String, DeviceType>>
    {
        static DevicePool pool = new DevicePool();
        Dictionary<Tuple<int, String, DeviceType>, Device> Devices = new Dictionary<Tuple<int, string, DeviceType>, Device>(Instance);

        private DevicePool() { }

        public static DevicePool Instance => pool;

        public void IntitialziePool(Device[] adapters)
        {
            foreach(Device adapter in adapters)
            {
                if (!adapter.DevicesFound) continue;
                Device device = adapter;
                while (device != null) 
                {
                    Devices.Add(new Tuple<int, string, DeviceType>(device.ID, device.Description, device.Type), device);
                    device = adapter.Clone();
                }
            }
        }

        Device ErrorHandler(Device device)
        {
            if (device == null) MessageBox.Show("Запрашиваемое устройство не найдено в пуле устройств!","Ошибка!",MessageBoxButtons.OK, MessageBoxIcon.Error);
            return device;
        }

        public Device this[DeviceType type]
        {
            get => ErrorHandler(Devices[new Tuple<int, string, DeviceType>(-1, null, type)]);
        }

        public Device this[DeviceType type, String Name]
        {
            get => ErrorHandler(Devices[new Tuple<int, string, DeviceType>(-1, Name, type)]);
        }

        public void Detach(int id)
        {
            Devices.Remove(new Tuple<int, string, DeviceType>(id, null, DeviceType.Undefined));
        }

        public bool Equals(Tuple<int, string, DeviceType> y, Tuple<int, string, DeviceType> x)
        {
            if (x.Item1 == -1 && x.Item2 == null && x.Item3 == y.Item3) return true;
            if (x.Item1 == y.Item1 && x.Item2 == null && x.Item3 == DeviceType.Undefined) return true;
            if (x.Item1 == -1 && x.Item2 == y.Item2 && x.Item3 == y.Item3) return true;
            return false;
        }

        public int GetHashCode(Tuple<int, string, DeviceType> obj)
        {
            return obj.Item1.GetHashCode() ^ obj.Item2.GetHashCode() ^ obj.Item3.GetHashCode();   
        }
    }
}
