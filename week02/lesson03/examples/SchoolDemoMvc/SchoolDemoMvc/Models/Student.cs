using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SchoolDemoMvc.Models
{
    public class Student
    {
        [Required(ErrorMessage = "La matrícula es obligatoria")]
        public int Matricula { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(50, ErrorMessage = "Longitud máxima de 50 caracteres")]
        [Display(Name = "Nombre del estudiante")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "La edad es obligatoria")]
        public int Edad { get; set; }

        public int CourseId { get; set; }
    }
}