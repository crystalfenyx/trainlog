using SampleProject.Models;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data
{
    public class TrainsetLogContext : DbContext
    {
        public DbSet<TrainsetLog> TrainsetLogs { get; set; }
        public DbSet<SpottingRecord> SpottingRecords { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           
           optionsBuilder.UseSqlite(@"Data source=SpottingRecord.db");
           optionsBuilder.UseSqlite(@"Data source=TrainsetLog.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new TrainsetLogConfiguration()).Seed();
          modelBuilder.ApplyConfiguration(new TrainsetLogConfiguration()).Seed2();

           modelBuilder.Entity<SpottingRecord>()
              .HasOne(p => p.TrainsetLog)
              .WithMany(b => b.SpottingRecords)
              .HasForeignKey(p => p.TrainsetForeignKey);
           
        }
    }
}
