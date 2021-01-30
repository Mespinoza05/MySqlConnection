using System;
using System.Collections.Generic;

#nullable disable

namespace Julieth.Data
{
    public partial class Fiador
    {
        public ulong Id { get; set; }
        public string Creditid { get; set; }
        public string Name { get; set; }
        public string Parents { get; set; }
        public string Civilstatus { get; set; }
        public string Identification { get; set; }
        public string Phone { get; set; }
        public string Sector { get; set; }
        public string Activity { get; set; }
        public string Ocupation { get; set; }
        public string Departament { get; set; }
        public string Municipality { get; set; }
        public string Company { get; set; }
        public string Companyrole { get; set; }
        public string Companytime { get; set; }
        public string Address { get; set; }
        public string Companyaddress { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
