using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core.Concreate;

namespace NLayer.Repository.Configurations
{
    public class ProjectEmployeesConfiguration : IEntityTypeConfiguration<ProjectEmployees>
    {
        public void Configure(EntityTypeBuilder<ProjectEmployees> builder)
        {
            builder.HasKey(x => new { x.ProjectId, x.EmployeesId });
            builder.ToTable("ProjectEmployees");
        }
    }
}
