﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DataBaseFirstNetCore.Data
{
    public partial class Cartera
    {
        public int? GestorId { get; set; }
        public string GestorName { get; set; }
        public decimal? SaldoCapital { get; set; }
    }
}
