using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorkShop.Model;

namespace WorkShop.Configurations;

public class BookConfigurations: IEntityTypeConfiguration <Book>
{
    public void Configure(EntityTypeBuilder<Book> builder)
    {
        builder.HasKey (b => b.BookId);
        
        builder.Property (b => b.Title).IsRequired().HasColumnType("nvarchar(200)");
        
        builder.Property (b => b.Author).IsRequired().HasColumnType("nvarchar(200)");
        
        builder.Property (b => b.ISBN).IsRequired().HasColumnType("nvarchar(20)");
        builder.HasIndex(b=> b.ISBN).IsUnique();
        
        builder
            .HasOne (b => b.Library)
            .WithMany (l => l.Books)
            .HasForeignKey (b => b.LibraryId)
            .OnDelete (deleteBehavior: DeleteBehavior.Cascade);
    }
}