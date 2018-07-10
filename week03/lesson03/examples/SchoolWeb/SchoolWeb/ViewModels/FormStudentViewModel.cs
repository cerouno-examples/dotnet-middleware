using SchoolWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolWeb.ViewModels
{
    public class FormStudentViewModel
    {
        public Student Student { get; set; }
        public List<Course> Courses { get; set; }
    }
}