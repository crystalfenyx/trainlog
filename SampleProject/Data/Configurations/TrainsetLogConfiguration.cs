using SampleProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SampleProject.Data
{
    public class TrainsetLogConfiguration : IEntityTypeConfiguration<TrainsetLog>
    {
        public void Configure(EntityTypeBuilder<TrainsetLog> builder)
        {
            builder.Property(p => p.Trainset).HasColumnName("Trainset");
        }
    }
}
