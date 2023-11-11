using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObject
{
    public class FloorRoomDAO
    {
        private static FloorRoomDAO instance = null;
        public static readonly object Lock = new object();
        private FloorRoomDAO() { }
        public static FloorRoomDAO Instance
        {
            get
            {
                lock (Lock)
                {
                    if (instance == null)
                    {
                        instance = new FloorRoomDAO();
                    }
                    return instance;
                }
            }
        }
        public List<Floor> GetFloors()
        {
            using var db = new FeedbackFacilitiesDBContext();
            return db.Floors.ToList();
        }
        public List<Room> GetRooms()
        {
            using var db = new FeedbackFacilitiesDBContext();
            return db.Rooms.ToList();
        }
        public List<Room> GetAllRoomsByFloorId(int floorId) 
        {
            var tmp = GetRooms().FindAll(m => m.FloorId.Equals(floorId));
            return tmp;
        }
        public Room GetRoomById(int id)
        {
            var tmp = GetRooms().SingleOrDefault(m => m.Id == id);
            return tmp;
        }
        public Room GetRoomByName(int roomNo)
        {
            var tmp = GetRooms().SingleOrDefault(m => m.RoomNo.Equals(roomNo));
            return tmp;
        }
        public Floor GetFloorById(int id)
        {
            var tmp = GetFloors().SingleOrDefault(m => m.Id == id);
            return tmp;
        }
    }
}
