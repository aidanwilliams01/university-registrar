using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Registrar.Models;
using Microsoft.EntityFrameworkCore;

namespace Registrar.Controllers
{
  public class StudentsController : Controller
  {
    private readonly UniversityRegistrarContext _db;

    public StudentsController(UniversityRegistrarContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Student> model = _db.Students
                            .ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Student student)
    {
      if (!ModelState.IsValid)
      {
        return View(student);
      }
      _db.Students.Add(student);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      Student thisStudent = _db.Students
                          .Include(student => student.JoinEntities)
                          .ThenInclude(join => join.Course)
                          .FirstOrDefault(student => student.StudentId == id);
      return View(thisStudent);
    }
  }
}