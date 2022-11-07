using System.ComponentModel.DataAnnotations;

namespace Common.Entities
{
    public class AppointmentEntity
    {
        [Key]
        public DateTime Date { get; set; }
        [Required]
        public ServiceTypeEntity ServiceType { get; set; }
        [Required]
        public UserEntity User { get; set; }
    }
}