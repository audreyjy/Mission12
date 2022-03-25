using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LaytonTemple.Models
{
    public class Tour
    {
        [Required]
        [Key]
        public int GroupId { get; set; }

        [Required]
        public string GroupName { get; set; }

        [Required]
        [Range(1,15)]
        public int GroupSize { get; set; }

        [Required]
        public string Email { get; set; }

        public string Phone { get; set; }

        // Foreign Key Relationship

        [Required]
        public int TimeId { get; set; }

        public AvailableTimes AvailableTimes { get; set; }
    }
}
