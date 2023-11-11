using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IFloorRoomRepository
    {
        List<Floor> GetFloors();
        List<Room> GetRooms();
        List<Room> GetAllRoomsByFloorId(int floorId);
        Room GetRoomById(int id);
        Room GetRoomByName(int roomNo);
        Floor GetFloorById(int id);
    }
}
