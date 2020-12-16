using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using PracticaSofia.Data;
using PracticaSofia.Models;

namespace PracticaSofia.Controllers
{
    public class ProductoController : Controller
    {
        private readonly ILogger<ProductoController> _logger;

        private readonly WebContext _context;

        public ProductoController(ILogger<ProductoController> logger, WebContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Producto()
        {
            var productos = _context.Productos.ToList();
            ViewBag.productos = productos.Select(d => new SelectListItem(d.Nombre, d.Id.ToString()));
            
            return View();
        }

        [HttpPost]
        public IActionResult Producto(Producto p)
        {
            if(ModelState.IsValid)
            {
                _context.Add(p);
                _context.SaveChanges();
                return RedirectToAction("Listar");
            }
            return View();
        }

        public IActionResult Listar()
        {
            var productos = _context.Productos.ToList();
            return View();
        }

    }
}