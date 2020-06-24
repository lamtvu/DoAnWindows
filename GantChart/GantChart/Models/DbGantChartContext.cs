using System;
using System.Data.Entity;

namespace GantChart.Models
{
    class DbGantChartContext:DbContext
    {
        public DbGantChartContext():base("name=GantChartContext")
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<TaskWork> TaskWorks { get; set; }
    }
}