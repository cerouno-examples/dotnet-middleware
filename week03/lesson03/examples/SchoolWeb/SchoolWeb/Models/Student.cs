using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SchoolWeb.Models
{
    public class Student
    {
        // Las anotaciones/atributos [Required]
        // sirven para especificar detalles sobr el modelo
        // Esto se ve reflejado en la BD al realizar las migraciones
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        [Required]
        [StringLength(200)]
        public string LastName { get; set; }

        [Required]
        public int Age { get; set; }

        [Required]
        public int CourseId { get; set; }

        // Para establecer una relación con la FK CourseId
        // se debe hacer uso de la Composición entre clases.
        // Ejemplo: [Course]*..1[Student]
        public Course Course { get; set; }
    }
}