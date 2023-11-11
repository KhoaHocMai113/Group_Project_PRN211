using System;
using System.Collections;
using System.Collections.Generic;

#nullable disable

namespace BusinessObject
{
    public partial class TaskFb
    {
        public int Id { get; set; }
        public int FeedbackId { get; set; }
        public int StaffId { get; set; }

        public virtual Feedback Feedback { get; set; }
        public virtual Staff Staff { get; set; }
    }
}
