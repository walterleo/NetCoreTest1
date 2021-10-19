using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using NetCoreTest1.Models;
using System.Linq;
using System;

namespace NetCoreTest1.Controllers
{
    public class AlumnoController : Controller
    {
         public IActionResult Index()
        {
            return View(_context.Alumnos.FirstOrDefault());
        }
        public IActionResult MultiAlumno()
        {
            //var listaAlumnos = GenerarAlumnosAlAzar();
            ViewBag.CosaDinamica = "La Monja";
            ViewBag.Fecha = DateTime.Now;

            return View("MultiAlumno", _context.Alumnos);
        }



        private EscuelaContext _context;
        public AlumnoController(EscuelaContext context) 
        {
            _context = context;

        }

    }
}