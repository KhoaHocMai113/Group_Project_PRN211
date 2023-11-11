using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObject
{
    public partial class MemberAccount
    {
        public MemberAccount()
        {
            Feedbacks = new HashSet<Feedback>();
        }

        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Feedback> Feedbacks { get; set; }
    }
}
