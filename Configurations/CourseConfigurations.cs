using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorkShop.Model;

namespace WorkShop.Configurations;

public class CourseConfigurations: IEntityTypeConfiguration <Course>
{
    [Obsolete("Obsolete")]
    public void Configure(EntityTypeBuilder<Course> builder)
    {
        builder.HasKey(c=>c.CourseId);
        
        builder.Property(c=>c.CourseId).IsRequired().HasColumnType("nvarchar(200)");

        builder.Property(c => c.Credits).IsRequired();
        
        builder.HasCheckConstraint("CK_Check_Credits", "[Credits] > 0");
        
        builder
            .HasOne(c => c.Department)
            .WithMany(d => d.Courses)
            .HasForeignKey(c => c.DepartmentId)
            .OnDelete(deleteBehavior: DeleteBehavior.Restrict);
    }
}