using System;
using System.Collections.Generic;

#nullable disable

namespace DataBaseFirstNetCore.Data
{
    public partial class Estadistica
    {
        public ulong Id { get; set; }
        public int GestorId { get; set; }
        public int SupervisorId { get; set; }
        public string NombreGestor { get; set; }
        public string NombreSupervisor { get; set; }
        public decimal Cartera { get; set; }
        public int TotalClientes { get; set; }
        public decimal Atrasos { get; set; }
        public decimal PorcentajeAtrasos { get; set; }
        public decimal Vencidos { get; set; }
        public decimal PorcentajeVencidos { get; set; }
        public decimal PorcentajeMora { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
