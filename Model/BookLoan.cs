namespace WorkShop.Model;

public class BookLoan
{
    public int LoanId { get; set; }
    
    public DateTime LoanDate { get; set; }
    
    public DateTime ReturnDate { get; set; }
    
    public int BookId { get; set; }
    
    public Book Book { get; set; } = null!;
    
    public int StudentId { get; set; }
    
    public Student Student { get; set; } = null!;
}