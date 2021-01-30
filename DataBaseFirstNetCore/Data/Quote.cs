using System;
using System.Collections.Generic;

#nullable disable

namespace DataBaseFirstNetCore.Data
{
    public partial class Quote
    {
        public ulong Id { get; set; }
        public string UserId { get; set; }
        public int ClientId { get; set; }
        public int CreditId { get; set; }
        public DateTime FechaIngreso { get; set; }
        public decimal CuotaAbonada { get; set; }
        public string CuotaConcepto { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
