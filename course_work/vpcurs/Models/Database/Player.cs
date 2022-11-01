using System;
using System.Collections.Generic;

namespace vpcurs.Models.Database
{
    public partial class Player
    {
        public string Name { get; set; } = null!;
        public string? TeamName { get; set; }
        public long? Growth { get; set; }
        public long? Weight { get; set; }
        public long? SuccessRate { get; set; }
        public long? WrestlingPer { get; set; }
        public long? Mvp { get; set; }

        public virtual PlayerResult PlayerResult { get; set; } = null!;
    }
}
