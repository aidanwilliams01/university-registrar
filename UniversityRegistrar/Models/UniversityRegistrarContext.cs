using Microsoft.EntityFrameworkCore;

namespace Registrar.Models
{
  public class UniversityRegistrarContext : DbContext
  {
    public DbSet<Student> Students { get; set; }
    public DbSet<Course> Courses { get; set; }
    public DbSet<StudentCourse> StudentCourses { get; set; }
    public UniversityRegistrarContext(DbContextOptions options) : base(options) { }
  }
}