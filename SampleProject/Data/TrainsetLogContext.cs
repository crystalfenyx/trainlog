using SampleProject.Models;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data
{
    public class TrainsetLogContext : DbContext
    {
        public DbSet<TrainsetLog> TrainsetLogs { get; set; }
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data source=TrainsetLog.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new TrainsetLogConfiguration()).Seed(); ;
        }
    }
}
