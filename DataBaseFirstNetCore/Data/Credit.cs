using System;
using System.Collections.Generic;

#nullable disable

namespace DataBaseFirstNetCore.Data
{
    public partial class Credit
    {
        public ulong Id { get; set; }
        public int Clientid { get; set; }
        public decimal Montoprincipal { get; set; }
        public decimal? Gastosadmin { get; set; }
        public decimal? Interescorriente { get; set; }
        public decimal? Interesmoratorio { get; set; }
        public string Fechaentrega { get; set; }
        public string Fecha1cuota { get; set; }
        public string Fechavencimiento { get; set; }
        public int? Plazo { get; set; }
        public int? Periodicidad { get; set; }
        public decimal Montoentregado { get; set; }
        public decimal Montointeres { get; set; }
        public decimal Cuotaprincipal { get; set; }
        public decimal Tazacambio { get; set; }
        public decimal Cuotapagar { get; set; }
        public decimal Cuotafixed { get; set; }
        public decimal Montofixed { get; set; }
        public int? Gestorcobro { get; set; }
        public int? Promotor { get; set; }
        public int? Supervisor { get; set; }
        public int Active { get; set; }
        public int Entregado { get; set; }
        public decimal Cantidadpagar { get; set; }
        public int? Days { get; set; }
        public string Special { get; set; }
        public int Moneda { get; set; }
        public string Destino { get; set; }
        public int? Recurrent { get; set; }
        public string Fechasolicitud { get; set; }
        public int? Statussolicitud { get; set; }
        public decimal Atraso { get; set; }
        public decimal MontoCancelacion { get; set; }
        public int DiasMora { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
