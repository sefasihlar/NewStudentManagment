using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core.Concreate;

namespace NLayer.Repository.Seeds
{
    public class ClassSeed : IEntityTypeConfiguration<Class>
    {
        public void Configure(EntityTypeBuilder<Class> builder)
        {
            builder.HasData(
                new Class { Id = 1, Name = "Python", Condition = true, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
                new Class { Id = 2, Name = "Java", Condition = true, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
                new Class { Id = 3, Name = "Php", Condition = true, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
                new Class { Id = 4, Name = "R", Condition = true, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
                new Class { Id = 5, Name = "Javascript", Condition = true, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now }
                );
        }
    }
}
