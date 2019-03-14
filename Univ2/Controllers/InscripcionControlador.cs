using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Univ2.Models;

namespace Univ2.Controllers
{
    public class InscripcionControlador : Controller
    {
        private readonly UniversidadContexto _context;

        public InscripcionControlador(UniversidadContexto context)
        {
            _context = context;
        }

        // GET: InscripcionControlador
        public async Task<IActionResult> Index()
        {
            var universidadContexto = _context.Inscripcion.Include(i => i.Curso).Include(i => i.Estudiante);
            return View(await universidadContexto.ToListAsync());
        }

        // GET: InscripcionControlador/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var inscripcion = await _context.Inscripcion
                .Include(i => i.Curso)
                .Include(i => i.Estudiante)
                .FirstOrDefaultAsync(m => m.InscripcionId == id);
            if (inscripcion == null)
            {
                return NotFound();
            }

            return View(inscripcion);
        }

        // GET: InscripcionControlador/Create
        public IActionResult Create()
        {
            ViewData["CursoId"] = new SelectList(_context.Curso, "CursoId", "CursoId");
            ViewData["EstudianteId"] = new SelectList(_context.Estudiante, "EstudianteId", "EstudianteId");
            return View();
        }

        // POST: InscripcionControlador/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("InscripcionId,CursoId,EstudianteId,Grado")] Inscripcion inscripcion)
        {
            if (ModelState.IsValid)
            {
                _context.Add(inscripcion);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CursoId"] = new SelectList(_context.Curso, "CursoId", "CursoId", inscripcion.CursoId);
            ViewData["EstudianteId"] = new SelectList(_context.Estudiante, "EstudianteId", "EstudianteId", inscripcion.EstudianteId);
            return View(inscripcion);
        }

        // GET: InscripcionControlador/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var inscripcion = await _context.Inscripcion.FindAsync(id);
            if (inscripcion == null)
            {
                return NotFound();
            }
            ViewData["CursoId"] = new SelectList(_context.Curso, "CursoId", "CursoId", inscripcion.CursoId);
            ViewData["EstudianteId"] = new SelectList(_context.Estudiante, "EstudianteId", "EstudianteId", inscripcion.EstudianteId);
            return View(inscripcion);
        }

        // POST: InscripcionControlador/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("InscripcionId,CursoId,EstudianteId,Grado")] Inscripcion inscripcion)
        {
            if (id != inscripcion.InscripcionId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(inscripcion);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InscripcionExists(inscripcion.InscripcionId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["CursoId"] = new SelectList(_context.Curso, "CursoId", "CursoId", inscripcion.CursoId);
            ViewData["EstudianteId"] = new SelectList(_context.Estudiante, "EstudianteId", "EstudianteId", inscripcion.EstudianteId);
            return View(inscripcion);
        }

        // GET: InscripcionControlador/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var inscripcion = await _context.Inscripcion
                .Include(i => i.Curso)
                .Include(i => i.Estudiante)
                .FirstOrDefaultAsync(m => m.InscripcionId == id);
            if (inscripcion == null)
            {
                return NotFound();
            }

            return View(inscripcion);
        }

        // POST: InscripcionControlador/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var inscripcion = await _context.Inscripcion.FindAsync(id);
            _context.Inscripcion.Remove(inscripcion);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InscripcionExists(int id)
        {
            return _context.Inscripcion.Any(e => e.InscripcionId == id);
        }
    }
}
