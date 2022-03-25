using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LaytonTemple.Models
{
    public class AvailableTimes
    {
        [Key]
        [Required]
        public int TimeId { get; set; }

        public DateTime TimeSlot { get; set; }

        public bool Filled { get; set; } = false;

    }
}
