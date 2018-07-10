using SchoolWeb.Models;
using SchoolWeb.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SchoolWeb.Controllers
{
    /// <summary>
    /// Clase controlador para el CRUD de estudiantes
    /// Se muestran diferentes formas de utilizar EF
    /// </summary>
    public class StudentsController : Controller
    {
        SchoolContext context;

        public StudentsController()
        {
            context = new SchoolContext();
        }

        // GET: Students
        public ActionResult Index()
        {
            var students = context.Student.Include("Course").ToList();

            return View(students);
        }

        // GET: Students/Save/<<id>>
        // Sirve tanto para agregar(id=null) como editar(id!=null)
        [HttpGet]
        public ActionResult Save(int? id)
        {
            FormStudentViewModel viewModel = new FormStudentViewModel
            {
                Courses = context.Course.ToList(), // lista de cursos
                Student = id.HasValue ?
                    context.Student.Find(id.Value) // buscar estudiante
                    : new Student(), // nuevo estudiante
            };

            return View(viewModel);
        }

        // POST: Students/Save
        // Este método se utiliza tanto para agregar como para editar un estudiante
        [HttpPost]
        public ActionResult Save(FormStudentViewModel viewModel)
        {
            if (viewModel.Student.Id == 0)
            {
                // agregar nuevo estudiante
                context.Student.Add(viewModel.Student);
            }
            else 
            {
                // edita estudiante (Attach)
                // y notifica (EntityState) que el modelo sufrió un cambio
                context.Student.Attach(viewModel.Student);
                context.Entry(viewModel.Student).State = EntityState.Modified;
            }

            context.SaveChanges();

            return RedirectToAction("Index");
        }

        // GET /Students/Delete/id
        [HttpGet]
        public ActionResult Delete(int id)
        {
            var student = context.Student.Find(id);

            return View(student);
        }

        [HttpPost]
        public ActionResult Delete(Student student)
        {
            // Puede utilizarse directamente Student.Remove(student) si se especificaran todas sus propiedades en la vista.
            // Actualmente solo se utiliza el ID, por lo cual, se tiene que ubicar previamente el objeto a eliminar

            var studentToRemove = context.Student.Find(student.Id);
            context.Student.Remove(studentToRemove);

            context.SaveChanges();
            
            return RedirectToAction("Index");
        }

        /// <summary>
        /// Libera recursos
        /// </summary>
        /// <param name="disposing"></param>
        protected override void Dispose(bool disposing)
        {
            context.Dispose();
            base.Dispose(disposing);
        }
    }
}