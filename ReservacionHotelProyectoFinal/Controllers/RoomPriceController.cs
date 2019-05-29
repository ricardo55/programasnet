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
    public class RoomPriceController : Controller
    {
        private readonly ReservacionHotelContext _context;

        public RoomPriceController(ReservacionHotelContext context)
        {
            _context = context;
        }

        // GET: RoomPrice
        public async Task<IActionResult> Index()
        {
            return View(await _context.RoomPrice.ToListAsync());
        }

        // GET: RoomPrice/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var roomPrice = await _context.RoomPrice
                .FirstOrDefaultAsync(m => m.RoomPriceID == id);
            if (roomPrice == null)
            {
                return NotFound();
            }

            return View(roomPrice);
        }

        // GET: RoomPrice/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: RoomPrice/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("RoomPriceID,RoomPriceAmount")] RoomPrice roomPrice)
        {
            if (ModelState.IsValid)
            {
                _context.Add(roomPrice);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(roomPrice);
        }

        // GET: RoomPrice/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var roomPrice = await _context.RoomPrice.FindAsync(id);
            if (roomPrice == null)
            {
                return NotFound();
            }
            return View(roomPrice);
        }

        // POST: RoomPrice/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("RoomPriceID,RoomPriceAmount")] RoomPrice roomPrice)
        {
            if (id != roomPrice.RoomPriceID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(roomPrice);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RoomPriceExists(roomPrice.RoomPriceID))
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
            return View(roomPrice);
        }

        // GET: RoomPrice/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var roomPrice = await _context.RoomPrice
                .FirstOrDefaultAsync(m => m.RoomPriceID == id);
            if (roomPrice == null)
            {
                return NotFound();
            }

            return View(roomPrice);
        }

        // POST: RoomPrice/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var roomPrice = await _context.RoomPrice.FindAsync(id);
            _context.RoomPrice.Remove(roomPrice);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RoomPriceExists(int id)
        {
            return _context.RoomPrice.Any(e => e.RoomPriceID == id);
        }
    }
}
