namespace WorkShop.Model;

public class Department
{
    public int DepartmentId { get; set; }

    public string Name { get; set; } = null!;
    
    public string OfficeLocation { get; set; } = null!;
    
    public ICollection <Student> Students { get; set; } = new List <Student> ();

    public ICollection <Instructor> Instructors { get; set; } = new List <Instructor>();
    
    public Instructor? HeadOfDepartment { get; set; }
    
    public int HeadOfDepartmentId { get; set; }
    
    public ICollection <Course> Courses { get; set; } = new List <Course> ();
}