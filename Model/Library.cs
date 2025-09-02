namespace WorkShop.Model;

public class Library
{
    public int LibrariesId { get; set; }
    
    public string Name { get; set; } = null!;
    
    public string Location { get; set; } = null!;
    
    public ICollection <Book> Books { get; set; } = new List <Book>();
}