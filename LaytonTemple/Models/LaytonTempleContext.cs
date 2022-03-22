using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaytonTemple.Models
{
    public class LaytonTempleContext : DbContext 
    {

        {
        }

        {
        }

        {
        }

        public LaytonTempleContext(DbContextOptions<LaytonTempleContext> options) : base(options)
        {
        }
         
        public DbSet<Tour> Tours { get; set; }
        public DbSet<AvailableTimes> AvailableTimes { get; set; }

        // Seeding the Data: 
        //protected override void OnModelCreating(ModelBuilder mb) // added this for seeding 
        //{
        //    mb.Entity<AvailableTimes>().HasData(
        //        new AvailableTimes { TimeId = 1, TimeSlot = "8:00 AM"},
        //        new AvailableTimes { TimeId = 2, TimeSlot = "9:00 AM" },
        //        new AvailableTimes { TimeId = 3, TimeSlot = "10:00 AM" },
        //        new AvailableTimes { TimeId = 4, TimeSlot = "11:00 AM" },
        //        new AvailableTimes { TimeId = 5, TimeSlot = "12:00 PM" },
        //        new AvailableTimes { TimeId = 6, TimeSlot = "1:00 PM" },
        //        new AvailableTimes { TimeId = 7, TimeSlot = "2:00 PM" },
        //        new AvailableTimes { TimeId = 8, TimeSlot = "3:00 PM" },
        //        new AvailableTimes { TimeId = 9, TimeSlot = "4:00 PM" },
        //        new AvailableTimes { TimeId = 10, TimeSlot = "5:00 PM" },
        //        new AvailableTimes { TimeId = 11, TimeSlot = "6:00 PM" },
        //        new AvailableTimes { TimeId = 12, TimeSlot = "7:00 PM" },
        //        new AvailableTimes { TimeId = 13, TimeSlot = "9:00 PM" }
        //    );
        //}
    }
}
