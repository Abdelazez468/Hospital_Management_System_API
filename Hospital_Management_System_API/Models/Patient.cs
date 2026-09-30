using System.ComponentModel.DataAnnotations;

namespace Hospital_Management_System_API.Models
{
    public class Patient
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(150)]
        public string FullName { get; set; } = string.Empty;

        [Required]
        [MaxLength(20)]
        public string Gender { get; set; } = string.Empty;

        [Required]
        public DateTime DateOfBirth { get; set; }

        [Required]
        [Phone]
        [MaxLength(20)]
        public string Phone { get; set; } = string.Empty;

        [MaxLength(250)]
        public string? Address { get; set; }

        

        public ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();
    }
}