using System.Collections.Generic;

namespace Registrar.Models
{
  public class Course
  {
    public string Name { get; set; }
    public string Number { get; set; }
    public int CourseId { get; set; }
    public List<StudentCourse> JoinEntities { get; }
  }
}