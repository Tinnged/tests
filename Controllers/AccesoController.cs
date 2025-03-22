using Microsoft.AspNetCore.Mvc;

namespace UI.WebAPIEntregas.Controllers
{
    public class AccesoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login()
        {
            return RedirectToAction("Index", "Home");
        }
    }
}
