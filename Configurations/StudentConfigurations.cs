using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorkShop.Model;

namespace WorkShop.Configurations;

public class StudentConfigurations: IEntityTypeConfiguration <Student>
{
    public void Configure(EntityTypeBuilder<Student> builder)
    {
        builder.HasKey(s => s.StudentId);
        
        builder.Property(s => s.FullName).IsRequired().HasColumnType("nvarchar(200)");
        
        builder.Property(s => s.Email).IsRequired().HasColumnType("nvarchar(150)");
        builder.HasIndex(s => s.Email).IsUnique();
        
        builder.Property(s => s.Phone).IsRequired(false).HasColumnType("nvarchar(20)");
        
        builder.Property(s => s.BirthDate).IsRequired().HasColumnType("date");
        
        builder.Property(s => s.Address).IsRequired(false).HasColumnType("nvarchar(300)");
        
        // Relations - FK_Department
        builder
            .HasOne(s=> s.Department)
            .WithMany(d => d.Students)
            .HasForeignKey(s=> s.DepartmentId)
            .OnDelete(DeleteBehavior.Restrict);
        
    }
}