using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IDeviceTypeRepository
    {
        List<DeviceType> GetDevices();
        DeviceType GetDeviceById(int id);
        DeviceType GetDeviceByName(string name);
        List<DeviceType> GetDeviceByNameList(string name);
        List<DeviceType> GetDeviceByTypeList(string type);
        void SaveDevice(DeviceType dt);
        void UpdateDevice(DeviceType dt);
        void RemoveDevice(DeviceType dt);
    }
}
