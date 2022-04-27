using System;
using System.ComponentModel.DataAnnotations;

namespace UserService.Models
{
    public class User
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public int Age { get; set; }

        [Required]
        public string DrivingLicenseNumber { get; set; }

        [Required]
        public DateTime LastActive { get; set; }
    }
}