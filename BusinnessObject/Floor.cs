using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObject
{
    public partial class Floor
    {
        public Floor()
        {
            Rooms = new HashSet<Room>();
        }

        public int Id { get; set; }
        public string FloorName { get; set; }

        public virtual ICollection<Room> Rooms { get; set; }
    }
}
