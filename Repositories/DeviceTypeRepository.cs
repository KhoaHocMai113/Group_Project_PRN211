using BusinessObject;
using DataAccessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class DeviceTypeRepository : IDeviceTypeRepository
    {
        public List<DeviceType> GetDevices() => DeviceTypeDAO.Instance.GetDevices();
        public DeviceType GetDeviceById(int id) => DeviceTypeDAO.Instance.GetDeviceById(id);
        public DeviceType GetDeviceByName(string name) => DeviceTypeDAO.Instance.GetDeviceByName(name);
        public List<DeviceType> GetDeviceByNameList(string name) => DeviceTypeDAO.Instance.GetDeviceByNameList(name);
        public List<DeviceType> GetDeviceByTypeList(string type) => DeviceTypeDAO.Instance.GetDeviceByTypeList(type);
        public void SaveDevice(DeviceType dt) => DeviceTypeDAO.Instance.SaveDevice(dt);
        public void UpdateDevice(DeviceType dt) => DeviceTypeDAO.Instance.UpdateDevice(dt);
        public void RemoveDevice(DeviceType dt) => DeviceTypeDAO.Instance.RemoveDevice(dt);
    }
}
