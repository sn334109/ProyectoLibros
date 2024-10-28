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

        public IActionResult AgregarLibro()
        {
            return View();

        }

        [HttpPost]

        public IActionResult AgregarLibro(Libro unLi)
        {
            try
            {
                unS.AgregarLibro(unLi);
                ViewBag.Mensaje = "Libro agregado con exito";
            }
            catch (Exception ex)
            {

                ViewBag.Error = ex.Message;
            }
            return View(unLi);
        }
    }
}


