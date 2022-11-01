using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using vpcurs.Models.Database;
using System.Linq;

namespace vpcurs.Models.StaticTabs
{
    public class MatchTab : StaticTab
    {
        public MatchTab(string h = "", DbSet<Match>? dBS = null) : base(h)
        {
            DBS = dBS;
            DataColumns = new List<string>();
            DataColumns.Add("Date");
            DataColumns.Add("Score");
            DataColumns.Add("Team1");
            DataColumns.Add("Team2");
            ObjectList = DBS.ToList<object>();
        }

        new public DbSet<Match>? DBS { get; set; }
    }
}
