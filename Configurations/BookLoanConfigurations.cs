using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorkShop.Model;

namespace WorkShop.Configurations;

public class BookLoanConfigurations: IEntityTypeConfiguration <BookLoan>
{
    public void Configure(EntityTypeBuilder<BookLoan> builder)
    {
        builder.HasKey (bl => bl.LoanId);
        
        builder.Property(bl => bl.LoanDate).IsRequired().HasColumnType("datetime");
        
        builder.Property(bl => bl.ReturnDate).IsRequired().HasColumnType("datetime");
        
        builder
            .HasOne(bl => bl.Book)
            .WithMany(b => b.BookLoans)
            .HasForeignKey(bl => bl.BookId)
            .OnDelete(deleteBehavior: DeleteBehavior.Restrict);
        
        builder
            .HasOne(bl => bl.Student)
            .WithMany(s => s.BookLoans)
            .HasForeignKey(bl => bl.StudentId)
            .OnDelete(deleteBehavior: DeleteBehavior.Restrict);
    }
}