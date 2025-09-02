namespace WorkShop.Model;

public class Submission
{
    public int SubmissionId { get; set; }
    
    public DateTime SubmissionDate { get; set; }

    public decimal Grade { get; set; }
    
    public int AssignmentId { get; set; }
    
    public Assignment Assignment { get; set; } = null!;
    
    public int StudentId { get; set; }
    
    public Student Student { get; set; } = null!;
}
