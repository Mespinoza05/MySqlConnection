using System;
using System.Collections.Generic;

#nullable disable

namespace Julieth.Data
{
    public partial class User
    {
        public User()
        {
            PermissionUsers = new HashSet<PermissionUser>();
            RoleUsers = new HashSet<RoleUser>();
        }

        public ulong Id { get; set; }
        public int GestorId { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string LastName { get; set; }
        public string SecondLastname { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Sex { get; set; }
        public int Supervisor { get; set; }
        public int Office { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string ApiToken { get; set; }
        public int? Code { get; set; }
        public int Theme { get; set; }
        public string Vehiculotype { get; set; }
        public string Placa { get; set; }
        public int Status { get; set; }
        public int Suspend { get; set; }
        public string RememberToken { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public virtual ICollection<PermissionUser> PermissionUsers { get; set; }
        public virtual ICollection<RoleUser> RoleUsers { get; set; }
    }
}
