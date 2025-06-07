using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace Actividad3LengProg3.Models
{
    public class EstudianteViewModel
    {
        [Required(ErrorMessage = "Nombre es obligatorio")]
        [StringLength(100)]
        [Display(Name = "Nombre completo del estudiante")]
        public string nombre_estudiante { get; set; }





        [Required(ErrorMessage = "Nombre es obligatorio")]
        [StringLength(15), MinLength(6)]
        [Display(Name = "Matrícula")]
        public string matricula_estudiante { get; set; }



        [Required(ErrorMessage = "Eliga una carrera")]
        public string carrera { get; set; }
        public List<SelectListItem> carreras { get; } = new()
    {
        new SelectListItem { Value = "Ingeniería en Software", Text = "Ingeniería en Sistemas" },
        new SelectListItem { Value = "Administración de Empresas", Text = "Administración de Empresas" },
        new SelectListItem { Value = "Odontología", Text = "Odontología" },
    };


        [Required(ErrorMessage = "Correo Obligatorio.")]
        [EmailAddress (ErrorMessage = "Correo no válido")]
        [Display (Name= "Correo Institucional")]
        public string correo { get; set; }


        [Phone]
        [MinLength(10)]
        [Display(Name = "Número")]
        public string telefono { get; set; }


        [Required(ErrorMessage = "Escriba su fecha de nacimiento")]
        [DataType (DataType.Date)]
        [Display(Name = "Fecha de Nacimiento")]
        public DateTime fecha_nacimiento { get; set; }

        [Required]
        public string Genero { get; set; }

        [Required]
        public string Turno { get; set; }

        [Required]
        public string TipoIngreso { get; set; }

        public bool EstaBecado { get; set; }

        [Range(0, 100)]
        public int? PorcentajeBeca { get; set; }

        [Required, Range(typeof(bool), "true", "true", ErrorMessage = "Debe aceptar los términos.")]
        public bool AceptaTerminos { get; set; }

    }
}
 


