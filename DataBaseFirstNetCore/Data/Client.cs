using System;
using System.Collections.Generic;

#nullable disable

namespace DataBaseFirstNetCore.Data
{
    public partial class Client
    {
        public ulong Id { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string LastName { get; set; }
        public string SecondLastname { get; set; }
        public string Identification { get; set; }
        public string Phone { get; set; }
        public string Sex { get; set; }
        public string Civilstatus { get; set; }
        public string Profession { get; set; }
        public string Departament { get; set; }
        public string Municipality { get; set; }
        public string Community { get; set; }
        public string Address { get; set; }
        public string Peoples { get; set; }
        public string Register { get; set; }
        public int Clientstatus { get; set; }
        public string Company { get; set; }
        public string Companyrole { get; set; }
        public string Companytime { get; set; }
        public string Companypayment { get; set; }
        public string Companyphone { get; set; }
        public string Companyaddress { get; set; }
        public string Business { get; set; }
        public string Businesstime { get; set; }
        public string Businesssector { get; set; }
        public string Businessactivity { get; set; }
        public string Businessaddress { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
