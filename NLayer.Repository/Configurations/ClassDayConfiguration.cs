using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core.Concreate;

namespace NLayer.Repository.Configurations
{
    public class ClassDayConfiguration : IEntityTypeConfiguration<ClassDay>
    {
        public void Configure(EntityTypeBuilder<ClassDay> builder)
        {
            builder.HasKey(x => new { x.DayId, x.ClassId });
            builder.ToTable("ClassDays");

        }
    }
}
