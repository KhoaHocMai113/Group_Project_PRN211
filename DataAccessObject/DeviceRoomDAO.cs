using BusinessObject;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObject
{
    public class DeviceRoomDAO
    {
        private static DeviceRoomDAO instance = null;
        public static readonly object Lock = new object();
        private DeviceRoomDAO() { }
        public static DeviceRoomDAO Instance
        {
            get
            {
                lock (Lock)
                {
                    if (instance == null)
                    {
                        instance = new DeviceRoomDAO();
                    }
                    return instance;
                }
            }
        }
        public List<Device> GetDevice()
        {
            using var db = new FeedbackFacilitiesDBContext();
            return db.Devices
                .Include(m => m.DeviceType)
                .Include(m => m.Room)
                .ToList();
        }
        public List<Device> GetDeviceByRoomId(int roomId)
        {
            var tmp = GetDevice().FindAll(m => m.RoomId.Equals(roomId));
            return tmp;
        }
        public List<Device> GetDeviceByDeviceTypeId(int deviceTypeId)
        {
            var tmp = GetDevice().FindAll(m => m.DeviceTypeId.Equals(deviceTypeId));
            return tmp;
        }
        public Device GetDeviceById(int Id)
        {
            var tmp = GetDevice().SingleOrDefault(m => m.Id.Equals(Id));
            return tmp;
        }
        public void SaveDeviceRoom(Device dr)
        {
            using var db = new FeedbackFacilitiesDBContext();
            db.Devices.Add(dr);
            db.SaveChanges();
        }
        public void RemoveDeviceRoom(int RoomId, int DeviceTypeId)
        {
            using var db = new FeedbackFacilitiesDBContext();
            var tmp = db.Devices.SingleOrDefault(m => m.RoomId == RoomId && m.DeviceTypeId == DeviceTypeId);
            db.Devices.Remove(tmp);
            db.SaveChanges();
        }
    }
}
