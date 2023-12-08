using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Registrar.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

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
                            // .OrderBy(student => student.DueDate)
                            // .Include(student => student.Category)
                            .ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      // ViewBag.CategoryId = new SelectList(_db.Categories, "CategoryId", "Name");
      return View();
    }

    [HttpPost]
    public ActionResult Create(Student student)
    {
      // if (student.CategoryId == 0)
      // {
      //   return RedirectToAction("Create");
      // }
      _db.Students.Add(student);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      Student thisStudent = _db.Students
                          // .Include(student => student.Category)
                          // .Include(student => student.JoinEntities)
                          // .ThenInclude(join => join.Tag)
                          .FirstOrDefault(student => student.StudentId == id);
      return View(thisStudent);
    }
  }
}