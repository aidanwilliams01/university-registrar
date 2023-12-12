using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Registrar.Models
{
  public class Student
  {
    [Required(ErrorMessage = "Input a name")]
    public string Name { get; set; }
    public DateTime EnrollmentDate { get; set; }
    public int StudentId { get; set; }
    public List<StudentCourse> JoinEntities { get; }
  }
}