using BusinessObject;
using DataAccessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class FloorRoomRepository : IFloorRoomRepository
    {
        public List<Floor> GetFloors() => FloorRoomDAO.Instance.GetFloors();
        public List<Room> GetRooms() => FloorRoomDAO.Instance.GetRooms();
        public List<Room> GetAllRoomsByFloorId(int floorId) => FloorRoomDAO.Instance.GetAllRoomsByFloorId(floorId);
        public Room GetRoomById(int id) => FloorRoomDAO.Instance.GetRoomById(id);
        public Room GetRoomByName(int roomNo) => FloorRoomDAO.Instance.GetRoomByName(roomNo);
        public Floor GetFloorById(int id) => FloorRoomDAO.Instance.GetFloorById(id);
    }
}
