using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core.Concreate;

namespace NLayer.Repository.Seeds
{
    public class ClassDaySeed : IEntityTypeConfiguration<ClassDay>
    {
        public void Configure(EntityTypeBuilder<ClassDay> builder)
        {
            builder.HasData(
                new ClassDay { ClassId = 1, DayId = 1 },
                new ClassDay { ClassId = 2, DayId = 2 },
                new ClassDay { ClassId = 3, DayId = 3 });

        }
    }
}
