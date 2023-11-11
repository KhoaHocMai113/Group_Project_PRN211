using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObject
{
    public partial class Feedback
    {
        public Feedback()
        {
            TaskFbs = new HashSet<TaskFb>();
        }

        public int Id { get; set; }
        public int Sender { get; set; }
        public int DeviceId { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }
        public DateTime Day { get; set; }
        public int Status { get; set; }

        public virtual Device Device { get; set; }
        public virtual MemberAccount SenderNavigation { get; set; }
        public virtual ICollection<TaskFb> TaskFbs { get; set; }
    }
}
