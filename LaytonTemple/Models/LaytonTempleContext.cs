using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaytonTemple.Models
{
    public class LaytonTempleContext : DbContext 
    {
        public LaytonTempleContext()
        {
        }

        public LaytonTempleContext(DbContextOptions<LaytonTempleContext> options) : base(options)
        {
        }
         
        public DbSet<Tour> Tours { get; set; }
        public DbSet<AvailableTimes> AvailableTimes { get; set; }

        // Seeding the Data: 
        protected override void OnModelCreating(ModelBuilder mb) // added this for seeding 
        {
            mb.Entity<AvailableTimes>().HasData(
                new AvailableTimes { TimeId = 1, Time = "8:00 AM"},
                new AvailableTimes { TimeId = 2, Time = "9:00 AM" },
                new AvailableTimes { TimeId = 3, Time = "10:00 AM" },
                new AvailableTimes { TimeId = 4, Time = "11:00 AM" },
                new AvailableTimes { TimeId = 5, Time = "12:00 PM" },
                new AvailableTimes { TimeId = 6, Time = "1:00 PM" },
                new AvailableTimes { TimeId = 7, Time = "2:00 PM" },
                new AvailableTimes { TimeId = 8, Time = "3:00 PM" },
                new AvailableTimes { TimeId = 9, Time = "4:00 PM" },
                new AvailableTimes { TimeId = 10, Time = "5:00 PM" },
                new AvailableTimes { TimeId = 11, Time = "6:00 PM" },
                new AvailableTimes { TimeId = 12, Time = "7:00 PM" },
                new AvailableTimes { TimeId = 13, Time = "9:00 PM" }
            );
        }
    }
}
