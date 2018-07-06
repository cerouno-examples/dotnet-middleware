using System.Collections.Generic;
using SchoolDemoMvc.Models;

namespace SchoolDemoMvc.DummyDb
{
    public static class Db
    {
        public static List<Student> Students = new List<Student>
        {
            new Student { Matricula = 123, Nombre = "Miguel", Edad = 31 },
            new Student { Matricula = 456, Nombre = "Pepe", Edad = 20 },
            new Student { Matricula = 789, Nombre = "Luis", Edad = 25 },
        };
        
        public static List<Course> Courses = new List<Course>
        {
            new Course { Id = 1, Name = "Angular 1" },
            new Course { Id = 2, Name = ".NET Middleware" },
            new Course { Id = 3, Name = "Lua" },
            new Course { Id = 4, Name = "LabView" },
            new Course { Id = 5, Name = "Dart" },
            new Course { Id = 6, Name = "Ada" },
            new Course { Id = 7, Name = "Hipster JS" },
            new Course { Id = 8, Name = "Arnold C" },
            new Course { Id = 9, Name = "ABAP" },
            new Course { Id = 10, Name = "Haskell" },
        };
    }
}