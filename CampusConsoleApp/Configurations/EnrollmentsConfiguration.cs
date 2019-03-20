using CampusApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace CampusApp.Configurations
{
    internal class EnrollmentsConfiguration : IEntityTypeConfiguration<Enrollment>
    {

        public void Configure(EntityTypeBuilder<Enrollment> builder)
        {

           // builder.ToTable("Enrollments", "dbo");
            // Other configuration
            builder.HasKey(c => c.EnrollmentID);

            // .HasOne<UserGroup>(e => e.UserGroup)
            //.WithMany(t => t.ProxyUserGroups)
            builder.HasOne(c => c.Student).WithMany().HasForeignKey(c => c.StudentID).IsRequired();

            // builder.HasMany(c => c.StudentID);


        }

    }
}