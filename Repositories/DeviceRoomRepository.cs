using BusinessObject;
using DataAccessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class DeviceRoomRepository : IDeviceRoomRepository
    {
        public List<Device> GetDevice() => DeviceRoomDAO.Instance.GetDevice();
        public List<Device> GetDeviceByRoomId(int roomId) => DeviceRoomDAO.Instance.GetDeviceByRoomId(roomId);
        public List<Device> GetDeviceByDeviceTypeId(int deviceTypeId) => DeviceRoomDAO.Instance.GetDeviceByDeviceTypeId(deviceTypeId);
        public Device GetDeviceById(int Id) => DeviceRoomDAO.Instance.GetDeviceById(Id);
        public void SaveDeviceRoom(Device dr) => DeviceRoomDAO.Instance.SaveDeviceRoom(dr);
        public void RemoveDeviceRoom(int RoomId, int DeviceTypeId) 
            => DeviceRoomDAO.Instance.RemoveDeviceRoom(RoomId, DeviceTypeId);    
    }
}
