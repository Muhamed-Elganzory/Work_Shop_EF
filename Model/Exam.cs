namespace WorkShop.Model;

public class Exam
{
    public int ExamId { get; set; }
    
    public DateTime ExamDate { get; set; }

    public string Type { get; set; } = null!;
    
    public int CourseId { get; set; }
    
    public Course Course { get; set; } = null!;
    
    public ICollection <ExamResults> ExamResults { get; set; } = new List <ExamResults>();
}