
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace Common.Entities
{
    public class UserEntity : IdentityUser
    {
        [Required]
        public string Phone { get; set; }
        public bool IsBlocked { get; set; }
    }
}