using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CampusApp.Models
{
    internal class StudentsConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
           
            // Other configuration
            builder.HasKey(c => c.ID);
          
        }
    }
}