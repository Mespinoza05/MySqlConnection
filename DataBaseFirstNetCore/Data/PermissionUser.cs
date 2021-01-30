using System;
using System.Collections.Generic;

#nullable disable

namespace DataBaseFirstNetCore.Data
{
    public partial class PermissionUser
    {
        public ulong Id { get; set; }
        public ulong PermissionId { get; set; }
        public ulong UserId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public virtual Permission Permission { get; set; }
        public virtual User User { get; set; }
    }
}
