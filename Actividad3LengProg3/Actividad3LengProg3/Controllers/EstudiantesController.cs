using Actividad3LengProg3.Models;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;
namespace Actividad3LengProg3.Controllers

{
    public class EstudiantesController : Controller
    {
        private static List<EstudianteViewModel> estudiantes = new List<EstudianteViewModel>();
        public IActionResult Registrar(EstudianteViewModel model)

        {
            if (ModelState.IsValid)
            {
                estudiantes.Add(model);
                TempData["Mensaje"] = "Estudiante registrado satisfactoriamente.";
                return RedirectToAction("Index");
            }
            return View(model);
        }

        [HttpPost]
        public IActionResult Editar (EstudianteViewModel model)
        {
            if (ModelState.IsValid)
            {
                EstudianteViewModel estudianteActual = estudiantes.FirstOrDefault(e => e.matricula_estudiante.Equals(model.matricula_estudiante));


                if (estudianteActual != null)
                {
                    TempData["MensajeError"] = "Estudiante no existe";
                    return RedirectToAction("Index");
                }

                estudianteActual.matricula_estudiante = model.matricula_estudiante;
                estudianteActual.nombre_estudiante = model.nombre_estudiante;
                estudianteActual.carrera_estudiante = model.carrera_estudiante;
                estudianteActual.correo_estudiante = model.correo_estudiante;
                estudianteActual.telefono_estudiante = model.telefono_estudiante;
                estudianteActual.fecha_nacimiento = model.fecha_nacimiento;
                estudianteActual.genero_estudiante = model.genero_estudiante;
                estudianteActual.turno = model.turno;
                estudianteActual.tipo_ingreso = model.tipo_ingreso;
                estudianteActual.becado = model.becado;
                estudianteActual.porcentaje_beca = model.porcentaje_beca;
            }

            return View(model);
        }


        public IActionResult Eliminar(string matricula)
        {
            EstudianteViewModel estudiante = new EstudianteViewModel();
            if (!ModelState.IsValid)
            {
                estudiantes.Remove(estudiante);
            }
            return RedirectToAction("Index");
        }
    }
}