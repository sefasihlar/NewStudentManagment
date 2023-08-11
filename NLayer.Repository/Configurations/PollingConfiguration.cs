using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core.Concreate;

namespace NLayer.Repository.Configurations
{
    public class PollingConfiguration : IEntityTypeConfiguration<Polling>
    {
        public void Configure(EntityTypeBuilder<Polling> builder)
        {

        }
    }
}
