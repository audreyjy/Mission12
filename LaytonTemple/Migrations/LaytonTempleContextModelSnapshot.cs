// <auto-generated />
using System;
using LaytonTemple.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LaytonTemple.Migrations
{
    [DbContext(typeof(LaytonTempleContext))]
    partial class LaytonTempleContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22");

            modelBuilder.Entity("LaytonTemple.Models.AvailableTimes", b =>
                {
                    b.Property<int>("TimeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Filled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("TimeSlot")
                        .HasColumnType("TEXT");

                    b.HasKey("TimeId");

                    b.ToTable("AvailableTimes");

                    b.HasData(
                        new
                        {
                            TimeId = 1,
                            Filled = false,
                            TimeSlot = new DateTime(2022, 3, 23, 8, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeId = 2,
                            Filled = false,
                            TimeSlot = new DateTime(2022, 3, 23, 9, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeId = 3,
                            Filled = false,
                            TimeSlot = new DateTime(2022, 3, 23, 10, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeId = 4,
                            Filled = false,
                            TimeSlot = new DateTime(2022, 3, 23, 11, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeId = 5,
                            Filled = false,
                            TimeSlot = new DateTime(2022, 3, 23, 12, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeId = 6,
                            Filled = false,
                            TimeSlot = new DateTime(2022, 3, 23, 13, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeId = 7,
                            Filled = false,
                            TimeSlot = new DateTime(2022, 3, 23, 14, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeId = 8,
                            Filled = false,
                            TimeSlot = new DateTime(2022, 3, 23, 15, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeId = 9,
                            Filled = false,
                            TimeSlot = new DateTime(2022, 3, 23, 16, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeId = 10,
                            Filled = false,
                            TimeSlot = new DateTime(2022, 3, 23, 17, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeId = 11,
                            Filled = false,
                            TimeSlot = new DateTime(2022, 3, 23, 18, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeId = 12,
                            Filled = false,
                            TimeSlot = new DateTime(2022, 3, 23, 19, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeId = 13,
                            Filled = false,
                            TimeSlot = new DateTime(2022, 3, 24, 8, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeId = 14,
                            Filled = false,
                            TimeSlot = new DateTime(2022, 3, 24, 9, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeId = 15,
                            Filled = false,
                            TimeSlot = new DateTime(2022, 3, 24, 10, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeId = 16,
                            Filled = false,
                            TimeSlot = new DateTime(2022, 3, 24, 11, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeId = 17,
                            Filled = false,
                            TimeSlot = new DateTime(2022, 3, 24, 12, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeId = 18,
                            Filled = false,
                            TimeSlot = new DateTime(2022, 3, 24, 13, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeId = 19,
                            Filled = false,
                            TimeSlot = new DateTime(2022, 3, 24, 14, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeId = 20,
                            Filled = false,
                            TimeSlot = new DateTime(2022, 3, 24, 15, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeId = 21,
                            Filled = false,
                            TimeSlot = new DateTime(2022, 3, 24, 16, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeId = 22,
                            Filled = false,
                            TimeSlot = new DateTime(2022, 3, 24, 17, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeId = 23,
                            Filled = false,
                            TimeSlot = new DateTime(2022, 3, 24, 18, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeId = 24,
                            Filled = false,
                            TimeSlot = new DateTime(2022, 3, 24, 19, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeId = 25,
                            Filled = false,
                            TimeSlot = new DateTime(2022, 3, 25, 8, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeId = 26,
                            Filled = false,
                            TimeSlot = new DateTime(2022, 3, 25, 9, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeId = 27,
                            Filled = false,
                            TimeSlot = new DateTime(2022, 3, 25, 10, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeId = 28,
                            Filled = false,
                            TimeSlot = new DateTime(2022, 3, 25, 11, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeId = 29,
                            Filled = false,
                            TimeSlot = new DateTime(2022, 3, 25, 12, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeId = 30,
                            Filled = false,
                            TimeSlot = new DateTime(2022, 3, 25, 13, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeId = 31,
                            Filled = false,
                            TimeSlot = new DateTime(2022, 3, 25, 14, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeId = 32,
                            Filled = false,
                            TimeSlot = new DateTime(2022, 3, 25, 15, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeId = 33,
                            Filled = false,
                            TimeSlot = new DateTime(2022, 3, 25, 16, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeId = 34,
                            Filled = false,
                            TimeSlot = new DateTime(2022, 3, 25, 17, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeId = 35,
                            Filled = false,
                            TimeSlot = new DateTime(2022, 3, 25, 18, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeId = 36,
                            Filled = false,
                            TimeSlot = new DateTime(2022, 3, 25, 19, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeId = 37,
                            Filled = false,
                            TimeSlot = new DateTime(2022, 3, 26, 8, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeId = 38,
                            Filled = false,
                            TimeSlot = new DateTime(2022, 3, 26, 9, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeId = 39,
                            Filled = false,
                            TimeSlot = new DateTime(2022, 3, 26, 10, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeId = 40,
                            Filled = false,
                            TimeSlot = new DateTime(2022, 3, 26, 11, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeId = 41,
                            Filled = false,
                            TimeSlot = new DateTime(2022, 3, 26, 12, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeId = 42,
                            Filled = false,
                            TimeSlot = new DateTime(2022, 3, 26, 13, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeId = 43,
                            Filled = false,
                            TimeSlot = new DateTime(2022, 3, 26, 14, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeId = 44,
                            Filled = false,
                            TimeSlot = new DateTime(2022, 3, 26, 15, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeId = 45,
                            Filled = false,
                            TimeSlot = new DateTime(2022, 3, 26, 16, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeId = 46,
                            Filled = false,
                            TimeSlot = new DateTime(2022, 3, 26, 17, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeId = 47,
                            Filled = false,
                            TimeSlot = new DateTime(2022, 3, 26, 18, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeId = 48,
                            Filled = false,
                            TimeSlot = new DateTime(2022, 3, 26, 19, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeId = 49,
                            Filled = false,
                            TimeSlot = new DateTime(2022, 3, 27, 8, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeId = 50,
                            Filled = false,
                            TimeSlot = new DateTime(2022, 3, 27, 9, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeId = 51,
                            Filled = false,
                            TimeSlot = new DateTime(2022, 3, 27, 10, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeId = 52,
                            Filled = false,
                            TimeSlot = new DateTime(2022, 3, 27, 11, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeId = 53,
                            Filled = false,
                            TimeSlot = new DateTime(2022, 3, 27, 12, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeId = 54,
                            Filled = false,
                            TimeSlot = new DateTime(2022, 3, 27, 13, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeId = 55,
                            Filled = false,
                            TimeSlot = new DateTime(2022, 3, 27, 14, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeId = 56,
                            Filled = false,
                            TimeSlot = new DateTime(2022, 3, 27, 15, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeId = 57,
                            Filled = false,
                            TimeSlot = new DateTime(2022, 3, 27, 16, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeId = 58,
                            Filled = false,
                            TimeSlot = new DateTime(2022, 3, 27, 17, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeId = 59,
                            Filled = false,
                            TimeSlot = new DateTime(2022, 3, 27, 18, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeId = 60,
                            Filled = false,
                            TimeSlot = new DateTime(2022, 3, 27, 19, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeId = 61,
                            Filled = false,
                            TimeSlot = new DateTime(2022, 3, 28, 8, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeId = 62,
                            Filled = false,
                            TimeSlot = new DateTime(2022, 3, 28, 9, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeId = 63,
                            Filled = false,
                            TimeSlot = new DateTime(2022, 3, 28, 10, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeId = 64,
                            Filled = false,
                            TimeSlot = new DateTime(2022, 3, 28, 11, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeId = 65,
                            Filled = false,
                            TimeSlot = new DateTime(2022, 3, 28, 12, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeId = 66,
                            Filled = false,
                            TimeSlot = new DateTime(2022, 3, 28, 13, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeId = 67,
                            Filled = false,
                            TimeSlot = new DateTime(2022, 3, 28, 14, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeId = 68,
                            Filled = false,
                            TimeSlot = new DateTime(2022, 3, 28, 15, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeId = 69,
                            Filled = false,
                            TimeSlot = new DateTime(2022, 3, 28, 16, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeId = 70,
                            Filled = false,
                            TimeSlot = new DateTime(2022, 3, 28, 17, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeId = 71,
                            Filled = false,
                            TimeSlot = new DateTime(2022, 3, 28, 18, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeId = 72,
                            Filled = false,
                            TimeSlot = new DateTime(2022, 3, 28, 19, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeId = 73,
                            Filled = false,
                            TimeSlot = new DateTime(2022, 3, 29, 8, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeId = 74,
                            Filled = false,
                            TimeSlot = new DateTime(2022, 3, 29, 9, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeId = 75,
                            Filled = false,
                            TimeSlot = new DateTime(2022, 3, 29, 10, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeId = 76,
                            Filled = false,
                            TimeSlot = new DateTime(2022, 3, 29, 11, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeId = 77,
                            Filled = false,
                            TimeSlot = new DateTime(2022, 3, 29, 12, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeId = 78,
                            Filled = false,
                            TimeSlot = new DateTime(2022, 3, 29, 13, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeId = 79,
                            Filled = false,
                            TimeSlot = new DateTime(2022, 3, 29, 14, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeId = 80,
                            Filled = false,
                            TimeSlot = new DateTime(2022, 3, 29, 15, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeId = 81,
                            Filled = false,
                            TimeSlot = new DateTime(2022, 3, 29, 16, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeId = 82,
                            Filled = false,
                            TimeSlot = new DateTime(2022, 3, 29, 17, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeId = 83,
                            Filled = false,
                            TimeSlot = new DateTime(2022, 3, 29, 18, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeId = 84,
                            Filled = false,
                            TimeSlot = new DateTime(2022, 3, 29, 19, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("LaytonTemple.Models.Tour", b =>
                {
                    b.Property<int>("GroupId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("AvailableTimesTimeId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("GroupName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("GroupSize")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Phone")
                        .HasColumnType("TEXT");

                    b.Property<int>("TimeId")
                        .HasColumnType("INTEGER");

                    b.HasKey("GroupId");

                    b.HasIndex("AvailableTimesTimeId");

                    b.ToTable("Tours");

                    b.HasData(
                        new
                        {
                            GroupId = 1,
                            Email = "test@test.com",
                            GroupName = "Team 1-1",
                            GroupSize = 3,
                            Phone = "801-101-1010",
                            TimeId = 1
                        });
                });

            modelBuilder.Entity("LaytonTemple.Models.Tour", b =>
                {
                    b.HasOne("LaytonTemple.Models.AvailableTimes", "AvailableTimes")
                        .WithMany()
                        .HasForeignKey("AvailableTimesTimeId");
                });
#pragma warning restore 612, 618
        }
    }
}
