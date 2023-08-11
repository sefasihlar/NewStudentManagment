using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core.Concreate;

namespace NLayer.Repository.Configurations
{
    public class StudentPollingConfiguration : IEntityTypeConfiguration<StudentPolling>
    {
        public void Configure(EntityTypeBuilder<StudentPolling> builder)
        {
            builder.HasKey(x => new { x.PollingId, x.StudentId });
        }
    }
}
