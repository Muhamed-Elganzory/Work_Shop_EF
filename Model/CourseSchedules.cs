namespace WorkShop.Model;

public class CourseSchedules
{
    public int ScheduleId { get; set; }
    
    public string DayOfWeek { get; set; } = null!;
    
    public TimeOnly StartTime { get; set; }
    
    public TimeOnly EndTime { get; set; }
    
    public int CourseId { get; set; }
    
    public Course Course { get; set; } = null!;
    
    public int InstructorId { get; set; }
    
    public Instructor Instructor { get; set; } = null!;
    
    public int ClassRoomId { get; set; }
    
    public ClassRoom ClassRoom { get; set; } = null!;
}