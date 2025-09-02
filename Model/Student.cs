namespace WorkShop.Model;

public class Student
{
    public int StudentId { get; set; }

    public string FullName { get; set; } = null!;
    
    public string Email { get; set; } = null!;
    
    public string Phone { get; set; } = null!;
    
    public DateOnly BirthDate { get; set; }
    
    public string Address { get; set; } = null!;
    
    public int DepartmentId { get; set; }
    
    public Department Department { get; set; } = null!;
    
    public ICollection <Enrollment> Enrollments { get; set; } = new List <Enrollment>();
    
    public ICollection <Submission> Submissions { get; set; } = new List <Submission>();
    
    public ICollection <ExamResults> ExamResults { get; set; } = new List <ExamResults>();
    
    public ICollection <BookLoan> BookLoans { get; set; } = new List <BookLoan>();
    
}