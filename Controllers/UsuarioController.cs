using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PracticaSofia.Data;
using PracticaSofia.Models;

namespace PracticaSofia.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly ILogger<UsuarioController> _logger;

        private readonly WebContext _context;

        public UsuarioController(ILogger<UsuarioController> logger, WebContext context)
        {
            _logger = logger;
            _context = context;
        }
        public IActionResult Usuario()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Usuario(Usuario u)
        {
            if(ModelState.IsValid)
            {
                _context.Add(u);
                _context.SaveChanges();
                return RedirectToAction("Listar");
            }
            return View();
        }

        public IActionResult Listar()
        {
            var usuario = _context.Usuarios.ToList();
            return View();
        }

    }
}
