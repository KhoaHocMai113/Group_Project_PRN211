using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObject
{
    public partial class DeviceType
    {
        public DeviceType()
        {
            Devices = new HashSet<Device>();
        }

        public int Id { get; set; }
        public string DeviceName { get; set; }
        public string Type { get; set; }

        public virtual ICollection<Device> Devices { get; set; }
    }
}
