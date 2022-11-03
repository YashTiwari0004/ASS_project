using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ASS_API.Models
{
    public class StaffModel
    { 
        [Required]
        public int StaffId { get; set; }
        [Required]
        public string StaffName { get; set; }
        [Required]
        public DateTime StaffDob { get; set; }
        [Required]
        public long StaffNumber { get; set; }
        [Required]
        public string StaffAddress { get; set; }
        
    }
}
