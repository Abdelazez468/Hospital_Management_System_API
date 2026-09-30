using System.ComponentModel.DataAnnotations;

namespace Hospital_Management_System_API.Models
{
    public class Appointment
    {
        public int Id { get; set; }

        [Required]
        public DateTime AppointmentDate { get; set; }

        [Required]
        [MaxLength(30)]
        public string Status { get; set; } = "Scheduled";


        public int DoctorId { get; set; }
        public int PatientId { get; set; }

        public Doctor? Doctor { get; set; }
        public Patient? Patient { get; set; }
        public MedicalRecord? MedicalRecord { get; set; }
    }
}