using CampusApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CampusApp.Configurations
{
    internal class AddreessConfiguration : IEntityTypeConfiguration<Addreess>
    {
        public void Configure(EntityTypeBuilder<Addreess> builder)
        {
            builder.HasKey(c => c.NumericKey);
         
        }
    }
}

