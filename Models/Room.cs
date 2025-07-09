using System.ComponentModel.DataAnnotations;

namespace HostelDormWebApp.Models
{
    public class Room
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Room Number")]
        public string? RoomNumber { get; set; }

        [Required]
        public string? Type { get; set; }

        [Display(Name = "Available?")]
        public bool IsAvailable { get; set; } = true;
    }
}
