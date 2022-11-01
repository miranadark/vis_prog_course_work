using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using vpcurs.Models.Database;
using System.Linq;

namespace vpcurs.Models.StaticTabs
{
    public class PlayerResultTab : StaticTab
    {
        public PlayerResultTab(string h = "", DbSet<PlayerResult>? dBS = null) : base(h)
        {
            DBS = dBS;
            DataColumns = new List<string>();
            DataColumns.Add("Name");
            DataColumns.Add("Speeches");
            DataColumns.Add("Time");
            DataColumns.Add("GoalsScored");
            DataColumns.Add("Assists");
            DataColumns.Add("HitsPer");
            ObjectList = DBS.ToList<object>();
        }

        new public DbSet<PlayerResult>? DBS { get; set; }
    }
}
