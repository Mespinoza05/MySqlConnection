using System;
using System.Collections.Generic;

#nullable disable

namespace Julieth.Data
{
    public partial class Lastpayday
    {
        public int PaymentId { get; set; }
        public int CreditId { get; set; }
        public decimal? DiasMora { get; set; }
    }
}
