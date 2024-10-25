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
    }
}
