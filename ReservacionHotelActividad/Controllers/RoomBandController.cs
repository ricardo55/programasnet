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
    public class RoomBandController : Controller
    {
        private readonly ReservacionHotelContext _context;

        public RoomBandController(ReservacionHotelContext context)
        {
            _context = context;
        }

        // GET: RoomBand
        public async Task<IActionResult> Index()
        {
            return View(await _context.RoomBand.ToListAsync());
        }

        // GET: RoomBand/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var roomBand = await _context.RoomBand
                .FirstOrDefaultAsync(m => m.RoomBandID == id);
            if (roomBand == null)
            {
                return NotFound();
            }

            return View(roomBand);
        }

        // GET: RoomBand/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: RoomBand/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("RoomBandID,BandDesc")] RoomBand roomBand)
        {
            if (ModelState.IsValid)
            {
                _context.Add(roomBand);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(roomBand);
        }

        // GET: RoomBand/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var roomBand = await _context.RoomBand.FindAsync(id);
            if (roomBand == null)
            {
                return NotFound();
            }
            return View(roomBand);
        }

        // POST: RoomBand/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("RoomBandID,BandDesc")] RoomBand roomBand)
        {
            if (id != roomBand.RoomBandID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(roomBand);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RoomBandExists(roomBand.RoomBandID))
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
            return View(roomBand);
        }

        // GET: RoomBand/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var roomBand = await _context.RoomBand
                .FirstOrDefaultAsync(m => m.RoomBandID == id);
            if (roomBand == null)
            {
                return NotFound();
            }

            return View(roomBand);
        }

        // POST: RoomBand/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var roomBand = await _context.RoomBand.FindAsync(id);
            _context.RoomBand.Remove(roomBand);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RoomBandExists(int id)
        {
            return _context.RoomBand.Any(e => e.RoomBandID == id);
        }
    }
}
