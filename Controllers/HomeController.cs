using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PC1.Models;

namespace PC1.Controllers;

public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Operacion()
        {
            return View();
        }

        public IActionResult Acerca()
        {
            return View();
        }
    }
