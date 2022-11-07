using System.ComponentModel.DataAnnotations;

namespace ServiceType.Service.Dtos
{
    public class CreateServiceTypeDto
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public int Price { get; set; }
        [Required]
        public int TimeFrame { get; set; }
    }
}