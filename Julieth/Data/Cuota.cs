using System;
using System.Collections.Generic;

#nullable disable

namespace Julieth.Data
{
    public partial class Cuota
    {
        public int Creditid { get; set; }
        public decimal SaldoPrincipal { get; set; }
        public decimal SaldoInteres { get; set; }
        public string Fechapago { get; set; }
    }
}
