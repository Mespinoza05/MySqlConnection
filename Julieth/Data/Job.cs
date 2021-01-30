using System;
using System.Collections.Generic;

#nullable disable

namespace Julieth.Data
{
    public partial class Job
    {
        public ulong Id { get; set; }
        public string Queue { get; set; }
        public string Payload { get; set; }
        public byte Attempts { get; set; }
        public uint? ReservedAt { get; set; }
        public uint AvailableAt { get; set; }
        public uint CreatedAt { get; set; }
    }
}
