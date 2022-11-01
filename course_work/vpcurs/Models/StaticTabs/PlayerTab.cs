using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using vpcurs.Models.Database;
using System.Linq;

namespace vpcurs.Models.StaticTabs
{
    public class PlayerTab : StaticTab
    {
        public PlayerTab(string h = "", DbSet<Player>? dBS = null) : base(h)
        {
            DBS = dBS;
            DataColumns = new List<string>();
            DataColumns.Add("Name");
            DataColumns.Add("TeamName");
            DataColumns.Add("Growth");
            DataColumns.Add("Weight");
            DataColumns.Add("SuccessRate");
            ObjectList = DBS.ToList<object>();
        }

        new public DbSet<Player>? DBS { get; set; }
    }
}
