using System;
using System.Collections.Generic;

#nullable disable

namespace Julieth.Data
{
    public partial class Dollar
    {
        public ulong Id { get; set; }
        public DateTime Date { get; set; }
        public string Amount { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
