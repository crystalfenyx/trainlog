using SampleProject.Models;
using Microsoft.EntityFrameworkCore;


namespace SampleProject.Data
{
    public static class ModelBuilderExtensions
    {
        public static ModelBuilder Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TrainsetLog>().HasData(
                new TrainsetLog
                {
                    Trainset = 609,
                    Trainset2 = 610,
                    Trainset3 = 000,
                    DisplayTrainset = "609/610",
                    RollingStock = "C151B",
                    Line = "NSL",
                    Line2 = "EWL",
                    Date = DateTime.Now,
                    RunNo = 211,
                    DisplayRunNo = "T211",
                    Remarks = "Train"

                    /* public int Trainset { get; set; }

        public int Trainset2 { get; set; }
        public int Trainset3 { get; set; }
        public string DisplayTrainset { get; set; }
        public string RollingStock { get; set; }
        public string Line { get; set; }
        public string Line2 { get; set; }
        public DateTime Date { get; set; }
        public int RunNo { get; set; }
        public string DisplayRunNo { get; set; }
        public string Remarks { get; set; }*/

                },

                new TrainsetLog

                {
                    Trainset = 223,
                    Trainset2 = 224,
                    Trainset3 = 000,
                    DisplayTrainset = "223/224",
                    RollingStock = "C651",
                    Line = "NSL",
                    Line2 = "EWL",
                    Date = DateTime.Now,
                    RunNo = 211,
                    DisplayRunNo = "T211",
                    Remarks = "Train"
                }
                  );
            return modelBuilder;
        }
    }
}
