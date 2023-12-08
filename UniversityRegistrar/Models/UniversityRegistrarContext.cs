using Microsoft.EntityFrameworkCore;

namespace Registrar.Models
{
  public class UniversityRegistrarContext : DbContext
  {
    public DbSet<Student> Students { get; set; }

    public UniversityRegistrarContext(DbContextOptions options) : base(options) { }
  }
}