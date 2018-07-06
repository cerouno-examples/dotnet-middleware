using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SchoolDemoMvc.DummyDb;
using SchoolDemoMvc.Models;
using SchoolDemoMvc.ViewModels;

namespace SchoolDemoMvc.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            List<Student> students = Db.Students;

            return View(students);
        }

        // 
        public ActionResult Create()
        {
            return View(new StudentViewModel());
        }

        [HttpPost]
        public ActionResult Create(Student student)
        {
            if (ModelState.IsValid)
            {
                Db.Students.Add(student);

                return RedirectToAction("Index");
            }

            return View(student);
        }

        public ActionResult Edit(int matricula)
        {
            List<Student> students = Db.Students;

            Student student = students.First(s => s.Matricula == matricula);

            return View(student);
        }

        [HttpPost]
        public ActionResult Edit(Student student)
        {
            int index = Db.Students.FindIndex(s => s.Matricula == student.Matricula);

            Db.Students[index].Nombre = student.Nombre;
            Db.Students[index].Edad = student.Edad;

            return RedirectToAction("Index");
        }

        public ActionResult Delete(int matricula)
        {
            Student student = Db.Students.First(s => s.Matricula == matricula);

            return View(student);
        }

        [HttpPost]
        public ActionResult Delete(Student student)
        {
            Db.Students.RemoveAll(s => s.Matricula == student.Matricula);
   
            return RedirectToAction("Index");
        }

    }
}