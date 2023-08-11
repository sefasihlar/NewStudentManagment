using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core.Concreate;

namespace NLayer.Repository.Configurations
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasOne(p => p.Class)
              .WithMany(s => s.Students)
              .HasForeignKey(p => p.ClassId)
              .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
