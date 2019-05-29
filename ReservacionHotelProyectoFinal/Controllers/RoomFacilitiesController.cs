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
    public class RoomFacilitiesController : Controller
    {
        private readonly ReservacionHotelContext _context;

        public RoomFacilitiesController(ReservacionHotelContext context)
        {
            _context = context;
        }

        // GET: RoomFacilities
        public async Task<IActionResult> Index()
        {
            var reservacionHotelContext = _context.RoomFacilities.Include(r => r.FacilitieList).Include(r => r.Room);
            return View(await reservacionHotelContext.ToListAsync());
        }

        // GET: RoomFacilities/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var roomFacilities = await _context.RoomFacilities
                .Include(r => r.FacilitieList)
                .Include(r => r.Room)
                .FirstOrDefaultAsync(m => m.RoomID == id);
            if (roomFacilities == null)
            {
                return NotFound();
            }

            return View(roomFacilities);
        }

        // GET: RoomFacilities/Create
        public IActionResult Create()
        {
            ViewData["FacilitieListID"] = new SelectList(_context.FacilitieList, "FacilitieListID", "FacilityDesc");
            ViewData["RoomID"] = new SelectList(_context.Room, "RoomID", "RoomID");
            return View();
        }

        // POST: RoomFacilities/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("RoomID,FacilitieListID,FacilityDetails")] RoomFacilities roomFacilities)
        {
            if (ModelState.IsValid)
            {
                _context.Add(roomFacilities);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["FacilitieListID"] = new SelectList(_context.FacilitieList, "FacilitieListID", "FacilityDesc", roomFacilities.FacilitieListID);
            ViewData["RoomID"] = new SelectList(_context.Room, "RoomID", "RoomID", roomFacilities.RoomID);
            return View(roomFacilities);
        }

        // GET: RoomFacilities/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var roomFacilities = await _context.RoomFacilities.FindAsync(id);
            if (roomFacilities == null)
            {
                return NotFound();
            }
            ViewData["FacilitieListID"] = new SelectList(_context.FacilitieList, "FacilitieListID", "FacilityDesc", roomFacilities.FacilitieListID);
            ViewData["RoomID"] = new SelectList(_context.Room, "RoomID", "RoomID", roomFacilities.RoomID);
            return View(roomFacilities);
        }

        // POST: RoomFacilities/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("RoomID,FacilitieListID,FacilityDetails")] RoomFacilities roomFacilities)
        {
            if (id != roomFacilities.RoomID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(roomFacilities);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RoomFacilitiesExists(roomFacilities.RoomID))
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
            ViewData["FacilitieListID"] = new SelectList(_context.FacilitieList, "FacilitieListID", "FacilityDesc", roomFacilities.FacilitieListID);
            ViewData["RoomID"] = new SelectList(_context.Room, "RoomID", "RoomID", roomFacilities.RoomID);
            return View(roomFacilities);
        }

        // GET: RoomFacilities/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var roomFacilities = await _context.RoomFacilities
                .Include(r => r.FacilitieList)
                .Include(r => r.Room)
                .FirstOrDefaultAsync(m => m.RoomID == id);
            if (roomFacilities == null)
            {
                return NotFound();
            }

            return View(roomFacilities);
        }

        // POST: RoomFacilities/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var roomFacilities = await _context.RoomFacilities.FindAsync(id);
            _context.RoomFacilities.Remove(roomFacilities);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RoomFacilitiesExists(int id)
        {
            return _context.RoomFacilities.Any(e => e.RoomID == id);
        }
    }
}
