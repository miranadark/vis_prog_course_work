using System;
using System.Collections.Generic;

namespace vpcurs.Models.Database
{
    public partial class Team
    {
        public string Name { get; set; } = null!;
        public long? Players { get; set; }
        public long? GoalsScored { get; set; }
        public long? GoalsСonce { get; set; }
        public long? RecentResults { get; set; }
        public string? NameCoach { get; set; }
    }
}
