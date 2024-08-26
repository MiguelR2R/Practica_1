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

    

        public IActionResult Acerca()
        {
            return View();
        }

        [HttpGet]
        public IActionResult InversionInicio()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Invertir(InversionModel model)
        {

            decimal total= model.Dinero;
            decimal comision = 0;
            decimal igv = 0.18m;

            if (model.SeleccionSP500) total += 500;
            if (model.SeleccionDowJones) total += 300;
            if (model.SeleccionBonosUS) total += 120;

            // Cálculo de la comisión
            comision = total > 300 ? 1 : 3;

            // Cálculo del monto final con IGV
            decimal montoConIGV = total + (total * igv);
            decimal montoAPagar = montoConIGV + comision;

            // Actualizar el modelo con los valores calculados
            model.Total = total;
            model.Comision = comision;
            model.MontoAPagar = montoAPagar;
            model.IGV = total * igv;

            return View("Confirmacion", model);
        }

        public IActionResult Confirmacion(InversionModel model)
        {
            return View(model);
        }
    }
    
