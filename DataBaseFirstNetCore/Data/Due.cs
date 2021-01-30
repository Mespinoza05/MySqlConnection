using System;
using System.Collections.Generic;

#nullable disable

namespace DataBaseFirstNetCore.Data
{
    public partial class Due
    {
        public ulong Id { get; set; }
        public int PaymentCuotaId { get; set; }
        public int PaymentId { get; set; }
        public int CreditId { get; set; }
        public int ClientId { get; set; }
        public int GestorId { get; set; }
        public int PromotorId { get; set; }
        public int UserId { get; set; }
        public DateTime? FechaPago { get; set; }
        public DateTime? FechaIngreso { get; set; }
        public decimal InteresMoratorio { get; set; }
        public decimal MontoMora { get; set; }
        public decimal SaldoPrincipal { get; set; }
        public decimal SaldoInteres { get; set; }
        public decimal SaldoMora { get; set; }
        public decimal AbonoPrincipal { get; set; }
        public decimal AbonoInteres { get; set; }
        public decimal AbonoMora { get; set; }
        public int DiasMora { get; set; }
        public int Moneda { get; set; }
        public int Nulo { get; set; }
        public DateTime? FechaNulo { get; set; }
        public string Concepto { get; set; }
        public decimal TotalPagado { get; set; }
        public decimal TipoCambio { get; set; }
        public decimal Equivalencia { get; set; }
        public long Transaccion { get; set; }
        public int Office { get; set; }
        public int DueStatus { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
