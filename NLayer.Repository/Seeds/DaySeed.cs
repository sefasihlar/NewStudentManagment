using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core.Concreate;

namespace NLayer.Repository.Seeds
{
    public class DaySeed : IEntityTypeConfiguration<Day>
    {
        public void Configure(EntityTypeBuilder<Day> builder)
        {
            builder.HasData(
                new Day { Id = 1, Name = "Pazatesi", Condition = true, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
                new Day { Id = 2, Name = "Salı", Condition = true, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
                new Day { Id = 3, Name = "Çarşamba", Condition = true, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
                new Day { Id = 4, Name = "Perşembe", Condition = true, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
                new Day { Id = 5, Name = "Cuma", Condition = true, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
                new Day { Id = 6, Name = "Cumartesi", Condition = true, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
                new Day { Id = 7, Name = "Pazar", Condition = true, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now });


        }
    }
}
