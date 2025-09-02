using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorkShop.Model;

namespace WorkShop.Configurations;

public class ExamConfigurations: IEntityTypeConfiguration <Exam>
{
    [Obsolete("Obsolete")]
    public void Configure(EntityTypeBuilder<Exam> builder)
    {
        builder.HasKey(e => e.CourseId);
        
        builder.Property(e=> e.ExamDate).IsRequired().HasColumnType("datetime");
        
        builder.Property(e => e.Type).IsRequired().HasColumnType("nvarchar(50)");
        builder.HasCheckConstraint("CK_Exam_Type", "[Type] IN ('Midterm', 'Final')");
        
        builder
            .HasOne(e => e.Course)
            .WithOne(c => c.Exam)
            .HasForeignKey<Exam>(e => e.CourseId)
            .OnDelete(deleteBehavior: DeleteBehavior.Restrict);
    }
}