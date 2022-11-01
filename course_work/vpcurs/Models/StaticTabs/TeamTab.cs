using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using vpcurs.Models.Database;
using System.Linq;

namespace vpcurs.Models.StaticTabs
{
    public class TeamTab : StaticTab
    {
        public TeamTab(string h = "", DbSet<Team>? dBS = null) : base(h)
        {
            DBS = dBS;
            DataColumns = new List<string>(); 
            DataColumns.Add("Name");
            DataColumns.Add("Players");
            DataColumns.Add("GoalsScored");
            DataColumns.Add("GoalsСonce");
            DataColumns.Add("RecentResults");
            DataColumns.Add("NameCoach");
            ObjectList = DBS.ToList<object>();
        }

        new public DbSet<Team>? DBS { get; set; }
    }
}
