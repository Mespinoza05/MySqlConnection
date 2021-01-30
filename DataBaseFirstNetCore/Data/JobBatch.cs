﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DataBaseFirstNetCore.Data
{
    public partial class JobBatch
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int TotalJobs { get; set; }
        public int PendingJobs { get; set; }
        public int FailedJobs { get; set; }
        public string FailedJobIds { get; set; }
        public string Options { get; set; }
        public int? CancelledAt { get; set; }
        public int CreatedAt { get; set; }
        public int? FinishedAt { get; set; }
    }
}
