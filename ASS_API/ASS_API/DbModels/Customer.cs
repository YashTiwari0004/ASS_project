using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ASS_API.DbModels
{
    [Table(name: "Customer")]
    [Index(nameof(Email), IsUnique = true)]

    public class Customer
    {
        [Required]
        public string Name { get; set; }
        [Required]
        [Key]
        public int Id { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [MinLength(8)]
        [Display(Name = "Enter Password")]
        public string Password { get; set; }
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

