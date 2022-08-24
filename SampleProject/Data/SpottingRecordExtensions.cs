using SampleProject.Models;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data
{
    public static class SpottingRecordExtensions
    {

        public static ModelBuilder Seed2(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SpottingRecord>().HasData(
                new SpottingRecord
                {
                    SpottingRecordID = "MRT93742",
                    TrainsetForeignKey = 714,

                });

            return modelBuilder;
        }

        /*
          public string? SpottingRecordID { get; set; }

[ForeignKey("Trainset")]
public int? TrainsetSpottedID { get; set; }
public TrainsetLog? TrainsetLog { get; set; }
        */
    }
}
