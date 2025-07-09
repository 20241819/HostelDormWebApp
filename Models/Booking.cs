using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HostelDormWebApp.Models
{
    public class Booking
    {
        public int Id { get; set; }

        [Required]
        public int RoomId { get; set; }

        [ForeignKey("RoomId")]
        public Room? Room { get; set; }

        [Required]
        public string? UserId { get; set; } // ASP.NET Identity User ID

        public DateTime BookingDate { get; set; } = DateTime.Now;
    }
}
