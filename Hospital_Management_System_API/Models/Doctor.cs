using System.ComponentModel.DataAnnotations;

namespace Hospital_Management_System_API.Models
{
    public class Doctor
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(150)]
        public string FullName { get; set; } = string.Empty;

        [Required]
        [MaxLength(100)]
        public string Specialization { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required]
        [Phone]
        [MaxLength(20)]
        public string Phone { get; set; } = string.Empty;

        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "Salary must be greater than 0.")]
        public decimal Salary { get; set; }

        public int DepartmentId { get; set; }

        public Department? Department { get; set; }
        public ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();
    }
}