using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DVDCollection.Models;

namespace DVDCollection.Controllers
{
    public class FilmTitleController : Controller
    {
        private readonly DVDContext _context;

        public FilmTitleController(DVDContext context)
        {
            _context = context;
        }

        // GET: FilmTitle
        public async Task<IActionResult> Index()
        {
            var dVDContext = _context.FilmTitle.Include(f => f.Certificate).Include(f => f.Genre);
            return View(await dVDContext.ToListAsync());
        }

        // GET: FilmTitle/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var filmTitle = await _context.FilmTitle
                .Include(f => f.Certificate)
                .Include(f => f.Genre)
                .FirstOrDefaultAsync(m => m.FilmTitleID == id);
            if (filmTitle == null)
            {
                return NotFound();
            }

            return View(filmTitle);
        }

        // GET: FilmTitle/Create
        public IActionResult Create()
        {
            ViewData["CertificateID"] = new SelectList(_context.Certificate, "CertificateID", "CertificateName");
            ViewData["GenreID"] = new SelectList(_context.Genre, "GenreID", "GenreName");
            return View();
        }

        // POST: FilmTitle/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FilmTitleID,GenreID,CertificateID,FilmName,FilmStory,FilmReleaseDate,FilmDuration,FilmAdditionalInfo")] FilmTitle filmTitle)
        {
            if (ModelState.IsValid)
            {
                _context.Add(filmTitle);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CertificateID"] = new SelectList(_context.Certificate, "CertificateID", "CertificateName", filmTitle.CertificateID);
            ViewData["GenreID"] = new SelectList(_context.Genre, "GenreID", "GenreName", filmTitle.GenreID);
            return View(filmTitle);
        }

        // GET: FilmTitle/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var filmTitle = await _context.FilmTitle.FindAsync(id);
            if (filmTitle == null)
            {
                return NotFound();
            }
            ViewData["CertificateID"] = new SelectList(_context.Certificate, "CertificateID", "CertificateName", filmTitle.CertificateID);
            ViewData["GenreID"] = new SelectList(_context.Genre, "GenreID", "GenreName", filmTitle.GenreID);
            return View(filmTitle);
        }

        // POST: FilmTitle/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("FilmTitleID,GenreID,CertificateID,FilmName,FilmStory,FilmReleaseDate,FilmDuration,FilmAdditionalInfo")] FilmTitle filmTitle)
        {
            if (id != filmTitle.FilmTitleID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(filmTitle);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FilmTitleExists(filmTitle.FilmTitleID))
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
            ViewData["CertificateID"] = new SelectList(_context.Certificate, "CertificateID", "CertificateName", filmTitle.CertificateID);
            ViewData["GenreID"] = new SelectList(_context.Genre, "GenreID", "GenreName", filmTitle.GenreID);
            return View(filmTitle);
        }

        // GET: FilmTitle/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var filmTitle = await _context.FilmTitle
                .Include(f => f.Certificate)
                .Include(f => f.Genre)
                .FirstOrDefaultAsync(m => m.FilmTitleID == id);
            if (filmTitle == null)
            {
                return NotFound();
            }

            return View(filmTitle);
        }

        // POST: FilmTitle/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var filmTitle = await _context.FilmTitle.FindAsync(id);
            _context.FilmTitle.Remove(filmTitle);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FilmTitleExists(int id)
        {
            return _context.FilmTitle.Any(e => e.FilmTitleID == id);
        }
    }
}
