using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorkShop.Model;

namespace WorkShop.Configurations;

public class CourseSchedulesConfigurations: IEntityTypeConfiguration <CourseSchedules>
{
    public void Configure(EntityTypeBuilder<CourseSchedules> builder)
    {
        builder.HasKey(cs => cs.ScheduleId);
        
        builder.Property(cs=> cs.DayOfWeek).IsRequired().HasColumnType("nvarchar(20)");
        
        builder.Property(cs=> cs.StartTime).IsRequired().HasColumnType("time");
        
        builder.Property(cs=> cs.EndTime).IsRequired().HasColumnType("time");
        
        // builder.HasIndex(cs => new { cs.CourseId, cs.InstructorId, cs.ClassRoomId }).IsUnique();
        
        builder
            .HasOne(cs => cs.Course)
            .WithMany(c => c.CourseSchedules)
            .HasForeignKey(cs => cs.CourseId)
            .OnDelete(deleteBehavior: DeleteBehavior.Restrict);
        
        builder
            .HasOne(cs => cs.Instructor)
            .WithMany(i => i.CourseSchedules)
            .HasForeignKey(cs => cs.InstructorId)
            .OnDelete(deleteBehavior: DeleteBehavior.Restrict);
        
        builder
            .HasOne(cs => cs.ClassRoom)
            .WithMany(r => r.CourseSchedules)
            .HasForeignKey(cs => cs.ClassRoomId)
            .OnDelete(deleteBehavior: DeleteBehavior.Restrict);
    }
}