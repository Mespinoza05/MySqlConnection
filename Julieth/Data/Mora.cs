using System;
using System.Collections.Generic;

#nullable disable

namespace Julieth.Data
{
    public partial class Mora
    {
        public int DiasMora { get; set; }
        public decimal SaldoMora { get; set; }
        public int Creditid { get; set; }
        public string Fechapago { get; set; }
        public decimal SaldoInteres { get; set; }
        public decimal SaldoPrincipal { get; set; }
        public int Paymentstatus { get; set; }
    }
}
