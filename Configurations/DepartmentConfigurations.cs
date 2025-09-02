using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorkShop.Model;

namespace WorkShop.Configurations;

public class DepartmentConfigurations: IEntityTypeConfiguration <Department>
{
    public void Configure(EntityTypeBuilder <Department> builder)
    {
        builder.HasKey(d => d.DepartmentId);
        
        builder.Property(d => d.Name).IsRequired().HasColumnType("nvarchar(200)");
        builder.HasIndex(d=> d.Name).IsUnique();
        
        builder.Property(d => d.OfficeLocation).IsRequired(false).HasColumnType("nvarchar(100)");

        builder
            .HasOne(d => d.HeadOfDepartment)
            .WithOne(i => i.HeadOfDepartment)
            .HasForeignKey <Department> (d=> d.HeadOfDepartmentId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}