namespace WorkShop.Model;

public class Instructor
{
    public int InstructorId { get; set; }

    public string FullName { get; set; } = null!;
    
    public string Email { get; set; } = null!;
    
    public string Phone { get; set; } = null!;
    
    public DateOnly HireDate { get; set; }
    
    public Department? HeadOfDepartment { get; set; }
    
    public Department WorkInDepartment { get; set; } = null!;
    
    public int DepartmentId { get; set; }
    
    public ICollection <CourseSchedules> CourseSchedules { get; set; } = new List <CourseSchedules>();
}