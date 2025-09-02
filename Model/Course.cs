namespace WorkShop.Model;

public class Course
{
    public int CourseId { get; set; }
    
    public string Title { get; set; } = null!;
    
    public int Credits { get; set; }
    
    public int DepartmentId { get; set; }
    
    public Department Department { get; set; } = null!;
    
    public ICollection <Enrollment> Enrollments { get; set; } = new List <Enrollment>();
    
    public ICollection <CourseSchedules> CourseSchedules { get; set; } = new List <CourseSchedules>();
    
    public ICollection <Assignment> Assignments { get; set; } = new List <Assignment>();
    
    public Exam Exam { get; set; } = null!;
}