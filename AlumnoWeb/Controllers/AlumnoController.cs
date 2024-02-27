using AlumnoWeb.Data;
using AlumnoWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AlumnoWeb.Controllers
{
    public class AlumnoController : Controller
    {
        private readonly AlumnoWebContext _context;
        public AlumnoController(AlumnoWebContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CrearAlumno()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CrearAlumno(Alumno alumno)
        {
            if (ModelState.IsValid)
            {
                _context.Add(alumno);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(alumno);
        }

        [HttpGet]
        public async Task<IActionResult> ConsultarAlumno(int? id)
        {
            if (id == null || _context.Alumno == null)
            {
                return NotFound();
            }

            var alumno = await _context.Alumno
                .FirstOrDefaultAsync(m => m.Id == id);


            if (alumno == null)
            {
                return NotFound();
            }

            return View(alumno);
        }
    }
}
