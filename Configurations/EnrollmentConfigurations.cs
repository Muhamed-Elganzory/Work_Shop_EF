using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorkShop.Model;

namespace WorkShop.Configurations;

public class EnrollmentConfigurations: IEntityTypeConfiguration <Enrollment>
{
    public void Configure(EntityTypeBuilder<Enrollment> builder)
    {
        builder.HasKey(e=> e.EnrollmentId);
        
        builder.Property(e => e.Grade).IsRequired().HasColumnType("decimal(5,2)");
        
        builder
            .HasIndex(e => new { e.StudentId, e.CourseId })
            .HasDatabaseName("UK_Student_Course")
            .IsUnique();


        builder
            .HasOne(e => e.Student)
            .WithMany(s => s.Enrollments)
            .HasForeignKey(e => e.StudentId)
            .OnDelete(DeleteBehavior.Restrict);
        
        builder
            .HasOne(e => e.Course)
            .WithMany(c => c.Enrollments)
            .HasForeignKey(e => e.CourseId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}