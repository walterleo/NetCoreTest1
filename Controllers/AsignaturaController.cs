using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using NetCoreTest1.Models;
using System.Linq;
using System;

namespace NetCoreTest1.Controllers
{
    public class AsignaturaController : Controller
    {
         public IActionResult Index()
        {

            return View(_context.Asignaturas.FirstOrDefault());
            // return View(new Asignatura{Nombre="Programación",
            //                     Id= Guid.NewGuid().ToString()
            //                 });
        }
        public IActionResult MultiAsignatura()
        {
            
            ViewBag.CosaDinamica = "La Monja";
            ViewBag.Fecha = DateTime.Now;

            return View("MultiAsignatura", _context.Asignaturas);
        }

        private EscuelaContext _context;
        public AsignaturaController(EscuelaContext context) 
        {
            _context = context;

        }
    }
}