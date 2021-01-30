using System;
using System.Collections.Generic;

#nullable disable

namespace Julieth.Data
{
    public partial class MigrateSup
    {
        public ulong Id { get; set; }
        public int SupId { get; set; }
        public int OfficeId { get; set; }
        public int UserId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
