namespace WorkShop.Model;

public class ExamResults
{
    public int ExamResultsId { get; set; }
    
    public decimal Score { get; set; }
    
    public int ExamId { get; set; }
    
    public Exam Exam { get; set; } = null!;
    
    public int StudentId { get; set; }
    
    public Student Student { get; set; } = null!;
}