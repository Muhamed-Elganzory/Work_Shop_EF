using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorkShop.Model;

namespace WorkShop.Configurations;

public class LibraryConfigurations: IEntityTypeConfiguration <Library>
{
    public void Configure(EntityTypeBuilder<Library> builder)
    {
        builder.HasKey (l => l.LibrariesId);
        
        builder.Property (l => l.Name).IsRequired().HasColumnType("nvarchar(100)");
        
        builder.Property (l => l.Location).IsRequired().HasColumnType("nvarchar(200)");
    }
}