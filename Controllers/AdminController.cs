using HostelDormWebApp.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HostelDormWebApp.Controllers
{
    [Authorize] // Optional: Add role-based check like [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AdminController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Dashboard()
        {
            var totalRooms = await _context.Rooms.CountAsync();
            var totalBookings = await _context.Bookings.CountAsync();
            var availableRooms = await _context.Rooms.CountAsync(r => r.IsAvailable);
            var bookedRooms = totalRooms - availableRooms;

            ViewBag.TotalRooms = totalRooms;
            ViewBag.TotalBookings = totalBookings;
            ViewBag.AvailableRooms = availableRooms;
            ViewBag.BookedRooms = bookedRooms;

            return View();
        }
    }
}
