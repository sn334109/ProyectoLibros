using Microsoft.AspNetCore.Mvc;
using Dominio;


namespace ProyectoLibros.Controllers
{
    public class LibroController : Controller
    {
        //instancia sistema
        Sistema unS = Sistema.Instancia;

        public IActionResult Index()
        {
            return View(unS.ordenarLibrosPorISBN());
        }
    }
}
