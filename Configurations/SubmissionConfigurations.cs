using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorkShop.Model;

namespace WorkShop.Configurations;

public class SubmissionConfigurations: IEntityTypeConfiguration <Submission>
{
    public void Configure(EntityTypeBuilder<Submission> builder)
    {
        builder.HasKey(s => s.SubmissionId);
        
        builder.Property(s => s.SubmissionDate).IsRequired().HasColumnType("datetime");
        
        builder.Property(s => s.Grade).IsRequired().HasColumnType("decimal(5,2)");
        
        // builder.HasKey(s => new { s.StudentId, s.AssignmentId });
        
        builder
            .HasOne(s => s.Assignment)
            .WithMany(a => a.Submissions)
            .HasForeignKey(s => s.AssignmentId)
            .OnDelete(deleteBehavior: DeleteBehavior.Cascade);
        
        builder
            .HasOne(s=> s.Student)
            .WithMany(st => st.Submissions)
            .HasForeignKey(s => s.StudentId)
            .OnDelete(deleteBehavior: DeleteBehavior.Restrict);
    }
}