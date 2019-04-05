using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ReservacionHotelExamen2.Models;

namespace ReservacionHotelExamen2.Controllers
{
    public class FacilitieListController : Controller
    {
        private readonly ReservacionHotelContext _context;

        public FacilitieListController(ReservacionHotelContext context)
        {
            _context = context;
        }

        // GET: FacilitieList
        public async Task<IActionResult> Index()
        {
            return View(await _context.FacilitieList.ToListAsync());
        }

        // GET: FacilitieList/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var facilitieList = await _context.FacilitieList
                .FirstOrDefaultAsync(m => m.FacilitieListID == id);
            if (facilitieList == null)
            {
                return NotFound();
            }

            return View(facilitieList);
        }

        // GET: FacilitieList/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: FacilitieList/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FacilitieListID,FacilityDesc")] FacilitieList facilitieList)
        {
            if (ModelState.IsValid)
            {
                _context.Add(facilitieList);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(facilitieList);
        }

        // GET: FacilitieList/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var facilitieList = await _context.FacilitieList.FindAsync(id);
            if (facilitieList == null)
            {
                return NotFound();
            }
            return View(facilitieList);
        }

        // POST: FacilitieList/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("FacilitieListID,FacilityDesc")] FacilitieList facilitieList)
        {
            if (id != facilitieList.FacilitieListID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(facilitieList);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FacilitieListExists(facilitieList.FacilitieListID))
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
            return View(facilitieList);
        }

        // GET: FacilitieList/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var facilitieList = await _context.FacilitieList
                .FirstOrDefaultAsync(m => m.FacilitieListID == id);
            if (facilitieList == null)
            {
                return NotFound();
            }

            return View(facilitieList);
        }

        // POST: FacilitieList/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var facilitieList = await _context.FacilitieList.FindAsync(id);
            _context.FacilitieList.Remove(facilitieList);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FacilitieListExists(int id)
        {
            return _context.FacilitieList.Any(e => e.FacilitieListID == id);
        }
    }
}
