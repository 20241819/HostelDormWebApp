using HostelDormWebApp.Data;
using HostelDormWebApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HostelDormWebApp.Controllers
{
    [Authorize]
    public class BookingController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;

        public BookingController(ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // Show available rooms
        public async Task<IActionResult> Index(string roomType)
        {
            var types = await _context.Rooms
                .Select(r => r.Type)
                .Distinct()
                .ToListAsync();

            ViewBag.RoomTypes = types;

            var availableRooms = _context.Rooms.Where(r => r.IsAvailable);

            if (!string.IsNullOrEmpty(roomType))
            {
                availableRooms = availableRooms.Where(r => r.Type == roomType);
            }

            return View(await availableRooms.ToListAsync());
        }


        // Book a room
        [HttpPost]
        public async Task<IActionResult> Book(int roomId)
        {
            var userId = _userManager.GetUserId(User);
            var room = await _context.Rooms.FindAsync(roomId);

            if (room == null || !room.IsAvailable)
                return NotFound();

            var booking = new Booking
            {
                RoomId = roomId,
                UserId = userId
            };

            _context.Bookings.Add(booking);
            room.IsAvailable = false;
            await _context.SaveChangesAsync();

            return RedirectToAction("MyBookings");
        }

        // View user's bookings
        public async Task<IActionResult> MyBookings()
        {
            var userId = _userManager.GetUserId(User);
            var bookings = await _context.Bookings
                .Include(b => b.Room)
                .Where(b => b.UserId == userId)
                .ToListAsync();

            return View(bookings);
        }

        // Cancel a booking
        [HttpPost]
        public async Task<IActionResult> Cancel(int bookingId)
        {
            var booking = await _context.Bookings
                .Include(b => b.Room)
                .FirstOrDefaultAsync(b => b.Id == bookingId);

            if (booking == null)
                return NotFound();

            if (booking.Room != null)
            {
                booking.Room.IsAvailable = true;
            }

            _context.Bookings.Remove(booking);
            await _context.SaveChangesAsync();

            return RedirectToAction("MyBookings");
        }
    }
}
