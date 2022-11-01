using System;
using System.Collections.Generic;

namespace vpcurs.Models.Database
{
    public partial class PlayerResult
    {
        public string Name { get; set; } = null!;
        public long? Speeches { get; set; }
        public long? Time { get; set; }
        public long? GoalsScored { get; set; }
        public long? Assists { get; set; }
        public long? HitsPer { get; set; }

        public virtual Player NameNavigation { get; set; } = null!;
    }
}
