using System.ComponentModel.DataAnnotations;

namespace Hospital_Management_System_API.Models
{
    public class MedicalRecord
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(500)]
        public string Diagnosis { get; set; } = string.Empty;

        [Required]
        [MaxLength(1000)]
        public string Prescription { get; set; } = string.Empty;

        [MaxLength(1000)]
        public string? Notes { get; set; }

        public int AppointmentId { get; set; }
        public Appointment? Appointment { get; set; }
    }
}