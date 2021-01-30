using System;
using System.Collections.Generic;

#nullable disable

namespace Julieth.Data
{
    public partial class Gestore
    {
        public ulong Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Supervisor { get; set; }
        public int Office { get; set; }
        public int Status { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
