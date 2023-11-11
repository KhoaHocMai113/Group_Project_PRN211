using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IDeviceRoomRepository
    {
        List<Device> GetDevice();
        List<Device> GetDeviceByRoomId(int roomId);
        List<Device> GetDeviceByDeviceTypeId(int deviceTypeId);
        Device GetDeviceById(int Id);
        void SaveDeviceRoom(Device dr);
        void RemoveDeviceRoom(int RoomId, int DeviceTypeId);
    }
}
