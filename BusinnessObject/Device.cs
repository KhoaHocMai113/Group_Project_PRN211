using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObject
{
    public partial class Device
    {
        public Device()
        {
            Feedbacks = new HashSet<Feedback>();
        }

        public int Id { get; set; }
        public int DeviceTypeId { get; set; }
        public int RoomId { get; set; }

        public virtual DeviceType DeviceType { get; set; }
        public virtual Room Room { get; set; }
        public virtual ICollection<Feedback> Feedbacks { get; set; }
    }
}
