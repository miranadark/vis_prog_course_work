using System;
using System.Collections.Generic;

namespace vpcurs.Models.Database
{
    public partial class Match
    {
        public string Date { get; set; } = null!;
        public string? Score { get; set; }
        public string? Team1 { get; set; }
        public string? Team2 { get; set; }
    }
}
