using System;
using System.Collections.Generic;

#nullable disable

namespace Julieth.Data
{
    public partial class RoleUser
    {
        public ulong Id { get; set; }
        public ulong RoleId { get; set; }
        public ulong UserId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public virtual Role Role { get; set; }
        public virtual User User { get; set; }
    }
}
