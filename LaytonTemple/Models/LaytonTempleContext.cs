using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaytonTemple.Models
{
    public class LaytonTempleContext : DbContext 
    {

        public LaytonTempleContext(DbContextOptions<LaytonTempleContext> options) : base(options)
        {
        }
         
        public DbSet<Tour> Tours { get; set; }
        public DbSet<AvailableTimes> AvailableTimes { get; set; }



        //Seeding the Data: 
        protected override void OnModelCreating(ModelBuilder mb) // added this for seeding 
        {

            mb.Entity<AvailableTimes>().HasData(
                new AvailableTimes { TimeId = 1, TimeSlot = DateTime.ParseExact("23/03/2022 08:00:00", "dd/MM/yyyy HH:mm:ss", null) },
                new AvailableTimes { TimeId = 2, TimeSlot = DateTime.ParseExact("23/03/2022 09:00:00", "dd/MM/yyyy HH:mm:ss", null) },
                new AvailableTimes { TimeId = 3, TimeSlot = DateTime.ParseExact("23/03/2022 10:00:00", "dd/MM/yyyy HH:mm:ss", null) },
                new AvailableTimes { TimeId = 4, TimeSlot = DateTime.ParseExact("23/03/2022 11:00:00", "dd/MM/yyyy HH:mm:ss", null) },
                new AvailableTimes { TimeId = 5, TimeSlot = DateTime.ParseExact("23/03/2022 12:00:00", "dd/MM/yyyy HH:mm:ss", null) },
                new AvailableTimes { TimeId = 6, TimeSlot = DateTime.ParseExact("23/03/2022 13:00:00", "dd/MM/yyyy HH:mm:ss", null) },
                new AvailableTimes { TimeId = 7, TimeSlot = DateTime.ParseExact("23/03/2022 14:00:00", "dd/MM/yyyy HH:mm:ss", null) },
                new AvailableTimes { TimeId = 8, TimeSlot = DateTime.ParseExact("23/03/2022 15:00:00", "dd/MM/yyyy HH:mm:ss", null) },
                new AvailableTimes { TimeId = 9, TimeSlot = DateTime.ParseExact("23/03/2022 16:00:00", "dd/MM/yyyy HH:mm:ss", null) },
                new AvailableTimes { TimeId = 10, TimeSlot = DateTime.ParseExact("23/03/2022 17:00:00", "dd/MM/yyyy HH:mm:ss", null) },
                new AvailableTimes { TimeId = 11, TimeSlot = DateTime.ParseExact("23/03/2022 18:00:00", "dd/MM/yyyy HH:mm:ss", null) },
                new AvailableTimes { TimeId = 12, TimeSlot = DateTime.ParseExact("23/03/2022 19:00:00", "dd/MM/yyyy HH:mm:ss", null) }
            );
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

            mb.Entity<Tour>().HasData(
                new Tour { GroupId = 1, GroupName = "Team 1-1", GroupSize = 3, Email = "test@test.com", Phone = "801-101-1010", TimeId = 1 });
        }
    }
    }
