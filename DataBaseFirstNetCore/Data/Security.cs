using System;
using System.Collections.Generic;

#nullable disable

namespace DataBaseFirstNetCore.Data
{
    public partial class Security
    {
        public ulong Id { get; set; }
        public DateTime UserId { get; set; }
        public DateTime Device { get; set; }
        public DateTime Token { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
