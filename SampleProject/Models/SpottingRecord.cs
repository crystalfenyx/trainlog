
using System.ComponentModel.DataAnnotations;

using System.ComponentModel.DataAnnotations.Schema;

namespace SampleProject.Models
{
    public class SpottingRecord
    {

        [Key]
        public string? SpottingRecordID { get; set; }

        [ForeignKey("Trainset")]
        public int? TrainsetForeignKey { get; set; }
        public TrainsetLog? TrainsetLog { get; set; }
    }
}
