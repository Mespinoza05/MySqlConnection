﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Julieth.Data
{
    public partial class Migration
    {
        public uint Id { get; set; }
        public string Migration1 { get; set; }
        public int Batch { get; set; }
    }
}
