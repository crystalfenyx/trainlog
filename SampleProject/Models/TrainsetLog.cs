
using System.ComponentModel.DataAnnotations;

namespace SampleProject.Models
{
    public class TrainsetLog
    {
        [Key]
        public int Trainset { get; set; }
        public int? Trainset2 { get; set; }
        public int? Trainset3 { get; set; }
        public string? DisplayTrainset { get; set; }
        public string? RollingStock { get; set; }
        public string? Line { get; set; }
        public string? Line2 { get; set; }
        public string? Remarks { get; set; }

        public List<SpottingRecord> SpottingRecords { get; set; }
    }
}
