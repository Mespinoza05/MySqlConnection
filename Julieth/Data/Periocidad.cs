using System;
using System.Collections.Generic;

#nullable disable

namespace Julieth.Data
{
    public partial class Periocidad
    {
        public ulong Id { get; set; }
        public string Periocidad1 { get; set; }
        public string Cantidaddias { get; set; }
        public string Cuotadias { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
