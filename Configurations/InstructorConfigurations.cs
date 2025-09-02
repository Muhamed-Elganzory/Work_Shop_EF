using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorkShop.Model;

namespace WorkShop.Configurations;

public class InstructorConfigurations: IEntityTypeConfiguration <Instructor>
{
    public void Configure(EntityTypeBuilder<Instructor> builder)
    {
        builder.HasKey(i => i.InstructorId);
        
        builder.Property(i => i.FullName).IsRequired().HasColumnType("nvarchar(200)");
        
        builder.Property(i => i.Email).IsRequired().HasColumnType("nvarchar(150)");
        builder.HasIndex(i=> i.Email).IsUnique();
        
        builder.Property(i => i.Phone).IsRequired(false).HasColumnType("nvarchar(20)");
        
        builder.Property(i => i.HireDate).IsRequired().HasColumnType("Date");
        
        builder
            .HasOne(i => i.WorkInDepartment)
            .WithMany(d => d.Instructors)
            .HasForeignKey (i => i.DepartmentId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}