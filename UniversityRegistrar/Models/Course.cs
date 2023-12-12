using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Registrar.Models
{
  public class Course
  {
    [Required(ErrorMessage = "Input a name")]
    public string Name { get; set; }
    [Required(ErrorMessage = "Input a number")]
    public string Number { get; set; }
    public int CourseId { get; set; }
    public List<StudentCourse> JoinEntities { get; }
  }
}