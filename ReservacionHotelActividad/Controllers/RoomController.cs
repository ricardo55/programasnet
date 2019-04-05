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
    public class RoomController : Controller
    {
        private readonly ReservacionHotelContext _context;

        public RoomController(ReservacionHotelContext context)
        {
            _context = context;
        }

        // GET: Room
        public async Task<IActionResult> Index()
        {
            var reservacionHotelContext = _context.Room.Include(r => r.RoomBand).Include(r => r.RoomPrice).Include(r => r.RoomType);
            return View(await reservacionHotelContext.ToListAsync());
        }

        // GET: Room/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var room = await _context.Room
                .Include(r => r.RoomBand)
                .Include(r => r.RoomPrice)
                .Include(r => r.RoomType)
                .FirstOrDefaultAsync(m => m.RoomID == id);
            if (room == null)
            {
                return NotFound();
            }

            return View(room);
        }

        // GET: Room/Create
        public IActionResult Create()
        {
            ViewData["RoomBandID"] = new SelectList(_context.RoomBand, "RoomBandID", "RoomBandID");
            ViewData["RoomPriceID"] = new SelectList(_context.RoomPrice, "RoomPriceID", "RoomPriceID");
            ViewData["RoomTypeID"] = new SelectList(_context.RoomType, "RoomTypeID", "RoomTypeID");
            return View();
        }

        // POST: Room/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("RoomID,RoomTypeID,RoomBandID,RoomPriceID,Floor,AdditionalNotes")] Room room)
        {
            if (ModelState.IsValid)
            {
                _context.Add(room);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["RoomBandID"] = new SelectList(_context.RoomBand, "RoomBandID", "RoomBandID", room.RoomBandID);
            ViewData["RoomPriceID"] = new SelectList(_context.RoomPrice, "RoomPriceID", "RoomPriceID", room.RoomPriceID);
            ViewData["RoomTypeID"] = new SelectList(_context.RoomType, "RoomTypeID", "RoomTypeID", room.RoomTypeID);
            return View(room);
        }

        // GET: Room/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var room = await _context.Room.FindAsync(id);
            if (room == null)
            {
                return NotFound();
            }
            ViewData["RoomBandID"] = new SelectList(_context.RoomBand, "RoomBandID", "RoomBandID", room.RoomBandID);
            ViewData["RoomPriceID"] = new SelectList(_context.RoomPrice, "RoomPriceID", "RoomPriceID", room.RoomPriceID);
            ViewData["RoomTypeID"] = new SelectList(_context.RoomType, "RoomTypeID", "RoomTypeID", room.RoomTypeID);
            return View(room);
        }

        // POST: Room/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("RoomID,RoomTypeID,RoomBandID,RoomPriceID,Floor,AdditionalNotes")] Room room)
        {
            if (id != room.RoomID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(room);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RoomExists(room.RoomID))
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
            ViewData["RoomBandID"] = new SelectList(_context.RoomBand, "RoomBandID", "RoomBandID", room.RoomBandID);
            ViewData["RoomPriceID"] = new SelectList(_context.RoomPrice, "RoomPriceID", "RoomPriceID", room.RoomPriceID);
            ViewData["RoomTypeID"] = new SelectList(_context.RoomType, "RoomTypeID", "RoomTypeID", room.RoomTypeID);
            return View(room);
        }

        // GET: Room/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var room = await _context.Room
                .Include(r => r.RoomBand)
                .Include(r => r.RoomPrice)
                .Include(r => r.RoomType)
                .FirstOrDefaultAsync(m => m.RoomID == id);
            if (room == null)
            {
                return NotFound();
            }

            return View(room);
        }

        // POST: Room/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var room = await _context.Room.FindAsync(id);
            _context.Room.Remove(room);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RoomExists(int id)
        {
            return _context.Room.Any(e => e.RoomID == id);
        }
    }
}
