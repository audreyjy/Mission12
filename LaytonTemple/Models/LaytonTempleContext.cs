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
                // first day - 23 - 1/7

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
                new AvailableTimes { TimeId = 12, TimeSlot = DateTime.ParseExact("23/03/2022 19:00:00", "dd/MM/yyyy HH:mm:ss", null) },

                // 24
                new AvailableTimes { TimeId = 13, TimeSlot = DateTime.ParseExact("24/03/2022 08:00:00", "dd/MM/yyyy HH:mm:ss", null) },
                new AvailableTimes { TimeId = 14, TimeSlot = DateTime.ParseExact("24/03/2022 09:00:00", "dd/MM/yyyy HH:mm:ss", null) },
                new AvailableTimes { TimeId = 15, TimeSlot = DateTime.ParseExact("24/03/2022 10:00:00", "dd/MM/yyyy HH:mm:ss", null) },
                new AvailableTimes { TimeId = 16, TimeSlot = DateTime.ParseExact("24/03/2022 11:00:00", "dd/MM/yyyy HH:mm:ss", null) },
                new AvailableTimes { TimeId = 17, TimeSlot = DateTime.ParseExact("24/03/2022 12:00:00", "dd/MM/yyyy HH:mm:ss", null) },
                new AvailableTimes { TimeId = 18, TimeSlot = DateTime.ParseExact("24/03/2022 13:00:00", "dd/MM/yyyy HH:mm:ss", null) },
                new AvailableTimes { TimeId = 19, TimeSlot = DateTime.ParseExact("24/03/2022 14:00:00", "dd/MM/yyyy HH:mm:ss", null) },
                new AvailableTimes { TimeId = 20, TimeSlot = DateTime.ParseExact("24/03/2022 15:00:00", "dd/MM/yyyy HH:mm:ss", null) },
                new AvailableTimes { TimeId = 21, TimeSlot = DateTime.ParseExact("24/03/2022 16:00:00", "dd/MM/yyyy HH:mm:ss", null) },
                new AvailableTimes { TimeId = 22, TimeSlot = DateTime.ParseExact("24/03/2022 17:00:00", "dd/MM/yyyy HH:mm:ss", null) },
                new AvailableTimes { TimeId = 23, TimeSlot = DateTime.ParseExact("24/03/2022 18:00:00", "dd/MM/yyyy HH:mm:ss", null) },
                new AvailableTimes { TimeId = 24, TimeSlot = DateTime.ParseExact("24/03/2022 19:00:00", "dd/MM/yyyy HH:mm:ss", null) },

            // 25
                new AvailableTimes { TimeId = 25, TimeSlot = DateTime.ParseExact("25/03/2022 08:00:00", "dd/MM/yyyy HH:mm:ss", null) },
                new AvailableTimes { TimeId = 26, TimeSlot = DateTime.ParseExact("25/03/2022 09:00:00", "dd/MM/yyyy HH:mm:ss", null) },
                new AvailableTimes { TimeId = 27, TimeSlot = DateTime.ParseExact("25/03/2022 10:00:00", "dd/MM/yyyy HH:mm:ss", null) },
                new AvailableTimes { TimeId = 28, TimeSlot = DateTime.ParseExact("25/03/2022 11:00:00", "dd/MM/yyyy HH:mm:ss", null) },
                new AvailableTimes { TimeId = 29, TimeSlot = DateTime.ParseExact("25/03/2022 12:00:00", "dd/MM/yyyy HH:mm:ss", null) },
                new AvailableTimes { TimeId = 30, TimeSlot = DateTime.ParseExact("25/03/2022 13:00:00", "dd/MM/yyyy HH:mm:ss", null) },
                new AvailableTimes { TimeId = 31, TimeSlot = DateTime.ParseExact("25/03/2022 14:00:00", "dd/MM/yyyy HH:mm:ss", null) },
                new AvailableTimes { TimeId = 32, TimeSlot = DateTime.ParseExact("25/03/2022 15:00:00", "dd/MM/yyyy HH:mm:ss", null) },
                new AvailableTimes { TimeId = 33, TimeSlot = DateTime.ParseExact("25/03/2022 16:00:00", "dd/MM/yyyy HH:mm:ss", null) },
                new AvailableTimes { TimeId = 34, TimeSlot = DateTime.ParseExact("25/03/2022 17:00:00", "dd/MM/yyyy HH:mm:ss", null) },
                new AvailableTimes { TimeId = 35, TimeSlot = DateTime.ParseExact("25/03/2022 18:00:00", "dd/MM/yyyy HH:mm:ss", null) },
                new AvailableTimes { TimeId = 36, TimeSlot = DateTime.ParseExact("25/03/2022 19:00:00", "dd/MM/yyyy HH:mm:ss", null) },

            // 26
                new AvailableTimes { TimeId = 37, TimeSlot = DateTime.ParseExact("26/03/2022 08:00:00", "dd/MM/yyyy HH:mm:ss", null) },
                new AvailableTimes { TimeId = 38, TimeSlot = DateTime.ParseExact("26/03/2022 09:00:00", "dd/MM/yyyy HH:mm:ss", null) },
                new AvailableTimes { TimeId = 39, TimeSlot = DateTime.ParseExact("26/03/2022 10:00:00", "dd/MM/yyyy HH:mm:ss", null) },
                new AvailableTimes { TimeId = 40, TimeSlot = DateTime.ParseExact("26/03/2022 11:00:00", "dd/MM/yyyy HH:mm:ss", null) },
                new AvailableTimes { TimeId = 41, TimeSlot = DateTime.ParseExact("26/03/2022 12:00:00", "dd/MM/yyyy HH:mm:ss", null) },
                new AvailableTimes { TimeId = 42, TimeSlot = DateTime.ParseExact("26/03/2022 13:00:00", "dd/MM/yyyy HH:mm:ss", null) },
                new AvailableTimes { TimeId = 43, TimeSlot = DateTime.ParseExact("26/03/2022 Fix seed14:00:00", "dd/MM/yyyy HH:mm:ss", null) },
                new AvailableTimes { TimeId = 44, TimeSlot = DateTime.ParseExact("26/03/2022 15:00:00", "dd/MM/yyyy HH:mm:ss", null) },
                new AvailableTimes { TimeId = 45, TimeSlot = DateTime.ParseExact("26/03/2022 16:00:00", "dd/MM/yyyy HH:mm:ss", null) },
                new AvailableTimes { TimeId = 46, TimeSlot = DateTime.ParseExact("26/03/2022 17:00:00", "dd/MM/yyyy HH:mm:ss", null) },
                new AvailableTimes { TimeId = 47, TimeSlot = DateTime.ParseExact("26/03/2022 18:00:00", "dd/MM/yyyy HH:mm:ss", null) },
                new AvailableTimes { TimeId = 48, TimeSlot = DateTime.ParseExact("26/03/2022 19:00:00", "dd/MM/yyyy HH:mm:ss", null) },


            // 27
                new AvailableTimes { TimeId = 49, TimeSlot = DateTime.ParseExact("27/03/2022 08:00:00", "dd/MM/yyyy HH:mm:ss", null) },
                new AvailableTimes { TimeId = 50, TimeSlot = DateTime.ParseExact("27/03/2022 09:00:00", "dd/MM/yyyy HH:mm:ss", null) },
                new AvailableTimes { TimeId = 51, TimeSlot = DateTime.ParseExact("27/03/2022 10:00:00", "dd/MM/yyyy HH:mm:ss", null) },
                new AvailableTimes { TimeId = 52, TimeSlot = DateTime.ParseExact("27/03/2022 11:00:00", "dd/MM/yyyy HH:mm:ss", null) },
                new AvailableTimes { TimeId = 53, TimeSlot = DateTime.ParseExact("27/03/2022 12:00:00", "dd/MM/yyyy HH:mm:ss", null) },
                new AvailableTimes { TimeId = 54, TimeSlot = DateTime.ParseExact("27/03/2022 13:00:00", "dd/MM/yyyy HH:mm:ss", null) },
                new AvailableTimes { TimeId = 55, TimeSlot = DateTime.ParseExact("27/03/2022 14:00:00", "dd/MM/yyyy HH:mm:ss", null) },
                new AvailableTimes { TimeId = 56, TimeSlot = DateTime.ParseExact("27/03/2022 15:00:00", "dd/MM/yyyy HH:mm:ss", null) },
                new AvailableTimes { TimeId = 57, TimeSlot = DateTime.ParseExact("27/03/2022 16:00:00", "dd/MM/yyyy HH:mm:ss", null) },
                new AvailableTimes { TimeId = 58, TimeSlot = DateTime.ParseExact("27/03/2022 17:00:00", "dd/MM/yyyy HH:mm:ss", null) },
                new AvailableTimes { TimeId = 59, TimeSlot = DateTime.ParseExact("27/03/2022 18:00:00", "dd/MM/yyyy HH:mm:ss", null) },
                new AvailableTimes { TimeId = 60, TimeSlot = DateTime.ParseExact("27/03/2022 19:00:00", "dd/MM/yyyy HH:mm:ss", null) },


            // 28
                new AvailableTimes { TimeId = 61, TimeSlot = DateTime.ParseExact("28/03/2022 08:00:00", "dd/MM/yyyy HH:mm:ss", null) },
                new AvailableTimes { TimeId = 62, TimeSlot = DateTime.ParseExact("28/03/2022 09:00:00", "dd/MM/yyyy HH:mm:ss", null) },
                new AvailableTimes { TimeId = 63, TimeSlot = DateTime.ParseExact("28/03/2022 10:00:00", "dd/MM/yyyy HH:mm:ss", null) },
                new AvailableTimes { TimeId = 64, TimeSlot = DateTime.ParseExact("28/03/2022 11:00:00", "dd/MM/yyyy HH:mm:ss", null) },
                new AvailableTimes { TimeId = 65, TimeSlot = DateTime.ParseExact("28/03/2022 12:00:00", "dd/MM/yyyy HH:mm:ss", null) },
                new AvailableTimes { TimeId = 66, TimeSlot = DateTime.ParseExact("28/03/2022 13:00:00", "dd/MM/yyyy HH:mm:ss", null) },
                new AvailableTimes { TimeId = 67, TimeSlot = DateTime.ParseExact("28/03/2022 14:00:00", "dd/MM/yyyy HH:mm:ss", null) },
                new AvailableTimes { TimeId = 68, TimeSlot = DateTime.ParseExact("28/03/2022 15:00:00", "dd/MM/yyyy HH:mm:ss", null) },
                new AvailableTimes { TimeId = 69, TimeSlot = DateTime.ParseExact("28/03/2022 16:00:00", "dd/MM/yyyy HH:mm:ss", null) },
                new AvailableTimes { TimeId = 70, TimeSlot = DateTime.ParseExact("28/03/2022 17:00:00", "dd/MM/yyyy HH:mm:ss", null) },
                new AvailableTimes { TimeId = 71, TimeSlot = DateTime.ParseExact("28/03/2022 18:00:00", "dd/MM/yyyy HH:mm:ss", null) },
                new AvailableTimes { TimeId = 72, TimeSlot = DateTime.ParseExact("28/03/2022 19:00:00", "dd/MM/yyyy HH:mm:ss", null) },


            // 29 
                new AvailableTimes { TimeId = 73, TimeSlot = DateTime.ParseExact("29/03/2022 08:00:00", "dd/MM/yyyy HH:mm:ss", null) },
                new AvailableTimes { TimeId = 74, TimeSlot = DateTime.ParseExact("29/03/2022 09:00:00", "dd/MM/yyyy HH:mm:ss", null) },
                new AvailableTimes { TimeId = 75, TimeSlot = DateTime.ParseExact("29/03/2022 10:00:00", "dd/MM/yyyy HH:mm:ss", null) },
                new AvailableTimes { TimeId = 76, TimeSlot = DateTime.ParseExact("29/03/2022 11:00:00", "dd/MM/yyyy HH:mm:ss", null) },
                new AvailableTimes { TimeId = 77, TimeSlot = DateTime.ParseExact("29/03/2022 12:00:00", "dd/MM/yyyy HH:mm:ss", null) },
                new AvailableTimes { TimeId = 78, TimeSlot = DateTime.ParseExact("29/03/2022 13:00:00", "dd/MM/yyyy HH:mm:ss", null) },
                new AvailableTimes { TimeId = 79, TimeSlot = DateTime.ParseExact("29/03/2022 14:00:00", "dd/MM/yyyy HH:mm:ss", null) },
                new AvailableTimes { TimeId = 80, TimeSlot = DateTime.ParseExact("29/03/2022 15:00:00", "dd/MM/yyyy HH:mm:ss", null) },
                new AvailableTimes { TimeId = 81, TimeSlot = DateTime.ParseExact("29/03/2022 16:00:00", "dd/MM/yyyy HH:mm:ss", null) },
                new AvailableTimes { TimeId = 82, TimeSlot = DateTime.ParseExact("29/03/2022 17:00:00", "dd/MM/yyyy HH:mm:ss", null) },
                new AvailableTimes { TimeId = 83, TimeSlot = DateTime.ParseExact("29/03/2022 18:00:00", "dd/MM/yyyy HH:mm:ss", null) },
                new AvailableTimes { TimeId = 84, TimeSlot = DateTime.ParseExact("29/03/2022 19:00:00", "dd/MM/yyyy HH:mm:ss", null) }





            );
         
            //    );

            mb.Entity<Tour>().HasData(
                new Tour { GroupId = 1, GroupName = "Team 1-1", GroupSize = 3, Email = "test@test.com", Phone = "801-101-1010", TimeId = 1 });
        }
    }
    }
