using EFDemo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDemo.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students= null;

            using (var db = new EFDemoContext())
            {
                students = db.Student.Include("Course").ToList();
            }

            foreach (var item in students)
            {
                Console.WriteLine(item.Identity);
                Console.WriteLine(item.Name);
                Console.WriteLine(item.LastName);
                Console.WriteLine(item.Age);
                Console.WriteLine(item.CourseId);
                Console.WriteLine(item.Course.Name);
            }

            Console.ReadKey();
        }
    }
}
