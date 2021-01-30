using System;
using System.Collections.Generic;

#nullable disable

namespace DataBaseFirstNetCore.Data
{
    public partial class Backup
    {
        public ulong Id { get; set; }
        public string Date { get; set; }
        public string Type { get; set; }
        public string Database { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
