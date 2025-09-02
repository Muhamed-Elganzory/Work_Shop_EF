namespace WorkShop.Model;

public class Book
{
    public int BookId { get; set; }

    public string Title { get; set; } = null!;
    
    public string Author { get; set; } = null!;
    
    public string ISBN { get; set; } = null!;
    
    public int LibraryId { get; set; }
    
    public Library Library { get; set; } = null!;
    
    public ICollection <BookLoan> BookLoans { get; set; } = new List <BookLoan>();
}