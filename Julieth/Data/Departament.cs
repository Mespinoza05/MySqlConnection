using System;
using System.Collections.Generic;

#nullable disable

namespace Julieth.Data
{
    public partial class Departament
    {
        public ulong Id { get; set; }
        public string Name { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
