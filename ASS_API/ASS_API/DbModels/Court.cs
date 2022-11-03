using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ASS_API.DbModels
{
    [Table(name: "Court")]
    public class Court
    {
        [Key]
        [Required]
        public char Id { get; set; }
        [Required]
        public string CourtName { get; set; }
    }
}
