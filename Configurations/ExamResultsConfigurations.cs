using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorkShop.Model;

namespace WorkShop.Configurations;

public class ExamResultsConfigurations: IEntityTypeConfiguration <ExamResults>
{
    public void Configure(EntityTypeBuilder<ExamResults> builder)
    {
        builder.HasKey (x => x.ExamResultsId);
        
        builder.Property (x => x.Score).IsRequired().HasColumnType ("decimal(5,2)");
        
        // builder. HasKey(er => new {er.ExamId, er.StudentId });
        
        builder
            .HasOne(er => er.Exam)
            .WithMany(e => e.ExamResults)
            .HasForeignKey(e => e.ExamId)
            .OnDelete(deleteBehavior: DeleteBehavior.Restrict);
        
        builder
            .HasOne(er => er.Student)
            .WithMany(s => s.ExamResults)
            .HasForeignKey(er => er.ExamResultsId)
            .OnDelete(deleteBehavior: DeleteBehavior.Restrict);
    }
}