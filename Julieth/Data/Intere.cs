using System;
using System.Collections.Generic;

#nullable disable

namespace Julieth.Data
{
    public partial class Intere
    {
        public ulong Id { get; set; }
        public string Interes { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
