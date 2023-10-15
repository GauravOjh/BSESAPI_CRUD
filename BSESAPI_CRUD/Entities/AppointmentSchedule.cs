using System.ComponentModel.DataAnnotations;

namespace BSESAPI_CRUD.Entities
{
    public class AppointmentSchedule
    {
        [Required]
        public DateTime? appointmentDate { get; set; }
        public string? myDivision { get; set; }

        [Required]
        public TimeSpan? appointmentTime { get; set; }
    }
}
