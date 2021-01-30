using System;
using System.Collections.Generic;

#nullable disable

namespace Julieth.Data
{
    public partial class Role
    {
        public Role()
        {
            PermissionRoles = new HashSet<PermissionRole>();
            RoleUsers = new HashSet<RoleUser>();
        }

        public ulong Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string Special { get; set; }

        public virtual ICollection<PermissionRole> PermissionRoles { get; set; }
        public virtual ICollection<RoleUser> RoleUsers { get; set; }
    }
}
