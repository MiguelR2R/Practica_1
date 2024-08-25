using Microsoft.AspNetCore.Mvc;
using MiProyecto.Models;

namespace MiProyecto.Controllers
{
    public class InversionController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Invertir(InversionModel model)
        {
            if (ModelState.IsValid)
            {
                // Procesar los datos
                return RedirectToAction("Confirmacion");
            }
            return View("Index", model);
        }

        public IActionResult Confirmacion()
        {
            return View();
        }
    }
}
