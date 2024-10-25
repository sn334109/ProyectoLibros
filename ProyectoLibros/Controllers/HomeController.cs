using Microsoft.AspNetCore.Mvc;

namespace ProyectoLibros.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
