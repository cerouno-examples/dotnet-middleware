using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SchoolDemoMvc.DummyDb;
using SchoolDemoMvc.Models;

namespace SchoolDemoMvc.ViewModels
{
    public class StudentViewModel
    {
        public Student Student { get; set; }
        public List<Course> Courses { get; private set; }

        public StudentViewModel()
        {
            this.Courses = Db.Courses;
        }
    }
}