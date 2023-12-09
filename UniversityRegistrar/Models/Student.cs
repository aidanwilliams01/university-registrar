using System;
using System.Collections.Generic;

namespace Registrar.Models
{
  public class Student
  {
    public string Name { get; set; }
    public DateTime EnrollmentDate { get; set; }
    public int StudentId { get; set; }
    public List<StudentCourse> JoinEntities { get; }
  }
}