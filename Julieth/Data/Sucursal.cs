using System;
using System.Collections.Generic;

#nullable disable

namespace Julieth.Data
{
    public partial class Sucursal
    {
        public ulong Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Departament { get; set; }
        public string Phone { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
