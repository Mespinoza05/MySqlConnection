﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DataBaseFirstNetCore.Data
{
    public partial class Sector
    {
        public ulong Id { get; set; }
        public string Name { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
