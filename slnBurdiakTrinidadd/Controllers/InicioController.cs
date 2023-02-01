using Microsoft.AspNetCore.Mvc;

namespace slnBurdiakTrinidad.Controllers
{
    public class InicioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
