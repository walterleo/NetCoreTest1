using Microsoft.AspNetCore.Mvc;
using NetCoreTest1.Models;
using System.Linq;
using System;

namespace NetCoreTest1.Controllers
{
    public class EscuelaController : Controller
    {
        private EscuelaContext _context;
        public IActionResult Index()
        {
            

            ViewBag.CosaDinamica = "La Monja";
            var escuela = _context.Escuelas.FirstOrDefault();
            return View(escuela);
        }

        public EscuelaController(EscuelaContext context) 
        {
            _context = context;

        }
    }
}