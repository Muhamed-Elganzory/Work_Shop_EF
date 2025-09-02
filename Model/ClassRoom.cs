namespace WorkShop.Model;

public class ClassRoom
{
    public int ClassRoomId { get; set; }
    
    public string Building { get; set; } = null!;
    
    public string RoomNumber { get; set; } = null!;
    
    public int Capacity { get; set; }
    
    public ICollection <CourseSchedules> CourseSchedules { get; set; } = new List <CourseSchedules>();
}