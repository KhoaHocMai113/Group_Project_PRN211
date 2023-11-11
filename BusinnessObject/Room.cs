using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObject
{
    public partial class Room
    {
        public Room()
        {
            Devices = new HashSet<Device>();
        }

        public int Id { get; set; }
        public int FloorId { get; set; }
        public int RoomNo { get; set; }

        public virtual Floor Floor { get; set; }
        public virtual ICollection<Device> Devices { get; set; }
    }
}
