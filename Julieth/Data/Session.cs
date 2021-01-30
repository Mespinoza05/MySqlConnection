using System;
using System.Collections.Generic;

#nullable disable

namespace Julieth.Data
{
    public partial class Session
    {
        public string Id { get; set; }
        public ulong? UserId { get; set; }
        public string IpAddress { get; set; }
        public string UserAgent { get; set; }
        public string Payload { get; set; }
        public int LastActivity { get; set; }
    }
}
