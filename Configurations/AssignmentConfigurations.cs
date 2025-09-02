using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorkShop.Model;

namespace WorkShop.Configurations;

public class AssignmentConfigurations: IEntityTypeConfiguration <Assignment>
{
    public void Configure(EntityTypeBuilder<Assignment> builder)
    {
        builder.HasKey (a => a.AssignmentId);
        
        builder.Property (a => a.Title).IsRequired().HasColumnType("nvarchar(200)");
        
        builder.Property (a => a.Description).IsRequired(false).HasColumnType("nvarchar(MAX)");
        
        builder.Property (a => a.DueDate).IsRequired().HasColumnType("datetime");
        
        builder
            .HasOne(a => a.Course)
            .WithMany(c => c.Assignments)
            .HasForeignKey(a => a.CourseId)
            .OnDelete(deleteBehavior: DeleteBehavior.Cascade);
    }
}