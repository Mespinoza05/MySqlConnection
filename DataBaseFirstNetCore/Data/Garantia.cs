using System;
using System.Collections.Generic;

#nullable disable

namespace DataBaseFirstNetCore.Data
{
    public partial class Garantia
    {
        public ulong Id { get; set; }
        public int CreditId { get; set; }
        public string Article { get; set; }
        public string Mark { get; set; }
        public string Color { get; set; }
        public string Model { get; set; }
        public string Serie { get; set; }
        public decimal Value { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
