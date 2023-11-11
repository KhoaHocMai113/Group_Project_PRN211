using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObject
{
    public class DeviceTypeDAO
    {
        private static DeviceTypeDAO instance = null;
        public static readonly object Lock = new object();
        private DeviceTypeDAO() { }
        public static DeviceTypeDAO Instance
        {
            get
            {
                lock (Lock)
                {
                    if (instance == null)
                    {
                        instance = new DeviceTypeDAO();
                    }
                    return instance;
                }
            }
        }
        public List<DeviceType> GetDevices()
        {
            using var db = new FeedbackFacilitiesDBContext();
            return db.DeviceTypes.ToList();
        }
        public DeviceType GetDeviceById(int id)
        {
            var tmp = GetDevices().SingleOrDefault(m => m.Id == id);
            return tmp;
        }
        public DeviceType GetDeviceByName(string name)
        {
            var tmp = GetDevices().SingleOrDefault(m => m.DeviceName == name);
            return tmp;
        }
        public List<DeviceType> GetDeviceByNameList(string name)
        {
            var tmp = GetDevices().FindAll(m => m.DeviceName.ToLower().Contains(name.ToLower()));
            return tmp;
        }
        public List<DeviceType> GetDeviceByTypeList(string type)
        {
            var tmp = GetDevices().FindAll(m => m.Type.ToLower().Contains(type.ToLower()));
            return tmp;
        }
        public void SaveDevice(DeviceType dt)
        {
            using var db = new FeedbackFacilitiesDBContext();
            db.DeviceTypes.Add(dt);
            db.SaveChanges();
        }
        public void UpdateDevice(DeviceType dt)
        {
            using var db = new FeedbackFacilitiesDBContext();
            db.DeviceTypes.Update(dt);
            db.SaveChanges();
        }
        public void RemoveDevice(DeviceType dt)
        {
            using var db = new FeedbackFacilitiesDBContext();
            var tmp = db.DeviceTypes.SingleOrDefault(m => m.Id == dt.Id);
            db.DeviceTypes.Remove(tmp);
            db.SaveChanges();
        }
    }
}
