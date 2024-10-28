using Microsoft.AspNetCore.Mvc;
using Dominio;

namespace ProyectoLibros.Controllers
{
    public class PersonaController : Controller
    {
        Sistema unS = Sistema.Instancia;
        public IActionResult Index()
        {
            return View(unS.ordenarPersonasAlfabeticamente());
        }

        public IActionResult ListarPrestamosPersona(int id)
        {
            ViewBag.Nombre = unS.DevolverNombreDePersona(id);
            ViewBag.Lista = unS.DevolverPrestamosPersona(id);
            return View();
        }

        public IActionResult AgregarPersona() 
        {
            return View();
        
        }

        [HttpPost]

        public IActionResult AgregarPersona(Persona unaP)
        {
            try
            {
                unS.AgregarPersona(unaP);
                ViewBag.Mensaje = "Persona agregada con exito";
            }
            catch (Exception ex)
            {

                ViewBag.Error = ex.Message;
            }
            return View(unaP);
        }
    }
}
