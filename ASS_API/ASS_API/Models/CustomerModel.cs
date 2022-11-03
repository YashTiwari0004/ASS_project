using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASS_API.Models
{
    public class CustomerModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Enter UserId")]
        public int Id { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [MinLength(8)]
        [Display(Name = "Enter Password")]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [MinLength(8)]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        public int MobileNumber { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime Dob { get; set; }
        [Required]
        public string Gender { get; set; }
    }
}
