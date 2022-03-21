﻿// <auto-generated />
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

                    b.Property<DateTime>("TimeSlot")
                        .HasColumnType("TEXT");

                    b.HasKey("TimeId");

                    b.ToTable("AvailableTimes");
                });

            modelBuilder.Entity("LaytonTemple.Models.Tour", b =>
                {
                    b.Property<int>("GroupId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("AvailableTimesTimeId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

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
