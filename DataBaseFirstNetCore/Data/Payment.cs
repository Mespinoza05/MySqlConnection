using System;
using System.Collections.Generic;

#nullable disable

namespace DataBaseFirstNetCore.Data
{
    public partial class Payment
    {
        public ulong Id { get; set; }
        public int Creditid { get; set; }
        public int Numcuota { get; set; }
        public int? Periodicidad { get; set; }
        public decimal? Interescorriente { get; set; }
        public decimal Interesmoratorio { get; set; }
        public string Fechapago { get; set; }
        public decimal Saldoanterior { get; set; }
        public decimal Cuotaprincipal { get; set; }
        public decimal Montointeres { get; set; }
        public decimal Montomora { get; set; }
        public decimal AbonoPrincipal { get; set; }
        public decimal AbonoInteres { get; set; }
        public decimal AbonoMora { get; set; }
        public decimal SaldoPrincipal { get; set; }
        public decimal SaldoInteres { get; set; }
        public decimal SaldoMora { get; set; }
        public int DiasMora { get; set; }
        public decimal Cuotapagar { get; set; }
        public decimal Nuevosaldo { get; set; }
        public int Paymentstatus { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
