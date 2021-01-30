using System;
using System.Collections.Generic;

#nullable disable

namespace Julieth.Data
{
    public partial class Permission
    {
        public Permission()
        {
            PermissionRoles = new HashSet<PermissionRole>();
            PermissionUsers = new HashSet<PermissionUser>();
        }

        public ulong Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public virtual ICollection<PermissionRole> PermissionRoles { get; set; }
        public virtual ICollection<PermissionUser> PermissionUsers { get; set; }
    }
}
