namespace WorkShop.Model;

public class Assignment
{
    public int AssignmentId { get; set; }

    public string Title { get; set; } = null!;
    
    public string Description { get; set; } = null!;
    
    public DateTime DueDate { get; set; }
    
    public int CourseId { get; set; }
    
    public Course Course { get; set; } = null!;
    
    public ICollection <Submission> Submissions { get; set; } = new List <Submission>();
}