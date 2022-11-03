using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASS_API.DbModels
{
    [Table(name:"Book")]
    public class AppointmentScheduling
    {
        [Key,Required]
        public int Id { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime BookDate { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime StartTime { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime EndTime { get; set; }
        [Required]
        public string Bookstatus { get; set; }
        [Required]
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        [Required]
        [ForeignKey("Staff")]
        public int StaffId { get; set; }
        public Staff Staff { get; set; }
        [Required]
        [ForeignKey("Court")]
        public char CourtId { get; set; }
        public Court Court { get; set; }
    }
}
