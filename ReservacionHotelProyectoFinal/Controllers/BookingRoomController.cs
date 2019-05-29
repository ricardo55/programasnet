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
    public class BookingRoomController : Controller
    {
        private readonly ReservacionHotelContext _context;

        public BookingRoomController(ReservacionHotelContext context)
        {
            _context = context;
        }

        // GET: BookingRoom
        public async Task<IActionResult> Index()
        {
            var reservacionHotelContext = _context.BookingRoom.Include(b => b.Booking).Include(b => b.Guest).Include(b => b.Room);
            return View(await reservacionHotelContext.ToListAsync());
        }

        // GET: BookingRoom/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bookingRoom = await _context.BookingRoom
                .Include(b => b.Booking)
                .Include(b => b.Guest)
                .Include(b => b.Room)
                .FirstOrDefaultAsync(m => m.BookingID == id);
            if (bookingRoom == null)
            {
                return NotFound();
            }

            return View(bookingRoom);
        }

        // GET: BookingRoom/Create
        public IActionResult Create()
        {
            ViewData["BookingID"] = new SelectList(_context.Booking, "BookingID", "BookingID");
            ViewData["GuestID"] = new SelectList(_context.Guest, "GuestID", "GuestTitle");
            ViewData["RoomID"] = new SelectList(_context.Room, "RoomID", "RoomID");
            return View();
        }

        // POST: BookingRoom/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("BookingID,RoomID,GuestID")] BookingRoom bookingRoom)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bookingRoom);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["BookingID"] = new SelectList(_context.Booking, "BookingID", "BookingID", bookingRoom.BookingID);
            ViewData["GuestID"] = new SelectList(_context.Guest, "GuestID", "GuestTitle", bookingRoom.GuestID);
            ViewData["RoomID"] = new SelectList(_context.Room, "RoomID", "RoomID", bookingRoom.RoomID);
            return View(bookingRoom);
        }

        // GET: BookingRoom/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bookingRoom = await _context.BookingRoom.FindAsync(id);
            if (bookingRoom == null)
            {
                return NotFound();
            }
            ViewData["BookingID"] = new SelectList(_context.Booking, "BookingID", "BookingID", bookingRoom.BookingID);
            ViewData["GuestID"] = new SelectList(_context.Guest, "GuestID", "GuestTitle", bookingRoom.GuestID);
            ViewData["RoomID"] = new SelectList(_context.Room, "RoomID", "RoomID", bookingRoom.RoomID);
            return View(bookingRoom);
        }

        // POST: BookingRoom/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("BookingID,RoomID,GuestID")] BookingRoom bookingRoom)
        {
            if (id != bookingRoom.BookingID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bookingRoom);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BookingRoomExists(bookingRoom.BookingID))
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
            ViewData["BookingID"] = new SelectList(_context.Booking, "BookingID", "BookingID", bookingRoom.BookingID);
            ViewData["GuestID"] = new SelectList(_context.Guest, "GuestID", "GuestTitle", bookingRoom.GuestID);
            ViewData["RoomID"] = new SelectList(_context.Room, "RoomID", "RoomID", bookingRoom.RoomID);
            return View(bookingRoom);
        }

        // GET: BookingRoom/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bookingRoom = await _context.BookingRoom
                .Include(b => b.Booking)
                .Include(b => b.Guest)
                .Include(b => b.Room)
                .FirstOrDefaultAsync(m => m.BookingID == id);
            if (bookingRoom == null)
            {
                return NotFound();
            }

            return View(bookingRoom);
        }

        // POST: BookingRoom/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var bookingRoom = await _context.BookingRoom.FindAsync(id);
            _context.BookingRoom.Remove(bookingRoom);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BookingRoomExists(int id)
        {
            return _context.BookingRoom.Any(e => e.BookingID == id);
        }
    }
}
