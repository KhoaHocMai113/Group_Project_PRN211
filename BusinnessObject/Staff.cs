using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObject
{
    public partial class Staff
    {
        public Staff()
        {
            TaskFbs = new HashSet<TaskFb>();
        }

        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

        public virtual ICollection<TaskFb> TaskFbs { get; set; }
    }
}
