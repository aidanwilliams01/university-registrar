using System;
using System.Collections.Generic;
using System.Data.Common;
namespace Registrar.Models
{
  public class Student
  {
    public string Name { get; set; }
    public DateTime EnrollmentDate { get; set; }
    public int StudentId { get; set; }
  }
}