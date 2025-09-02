using System.Reflection;
using Microsoft.EntityFrameworkCore;
using WorkShop.Model;

namespace WorkShop.Data;

public class SisDbContext: DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server= localhost,1433; Database= SIS; User Id= sa;Password= YourStrong@Passw0rd; TrustServerCertificate=True;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
    
    public DbSet <Student> Students { get; set; }
    public DbSet <Department> Departments { get; set; }
    public DbSet <Instructor> Instructors { get; set; }
    public DbSet <Course> Courses { get; set; }
    public DbSet <Enrollment> Enrollments { get; set; }
    public DbSet <ClassRoom> ClassRooms { get; set; }
    public DbSet <CourseSchedules> CourseSchedules { get; set; }
    public DbSet <Assignment> Assignments { get; set; }
    public DbSet <Submission> Submissions { get; set; }
    public DbSet <Exam> Exams { get; set; }
    public DbSet <ExamResults> ExamResults { get; set; }
    public DbSet <Library> Libraries { get; set; }
    public DbSet <Book> Books { get; set; }
    public DbSet <BookLoan> BookLoans { get; set; }
}