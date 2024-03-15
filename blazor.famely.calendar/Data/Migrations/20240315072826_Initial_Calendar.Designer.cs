﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using blazor.famely.calendar.Data;

#nullable disable

namespace blazor.famely.calendar.Data.Migrations
{
    [DbContext(typeof(CalendarDatabaseContext))]
    [Migration("20240315072826_Initial_Calendar")]
    partial class Initial_Calendar
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.0-rc.2.23480.1");

            modelBuilder.Entity("blazor.famely.calendar.Data.CalendarData.Event", b =>
                {
                    b.Property<string>("IdKey")
                        .HasColumnType("TEXT");

                    b.Property<bool>("AllDay")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Color")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("End")
                        .HasColumnType("TEXT");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Master")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Start")
                        .HasColumnType("TEXT");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("IdKey");

                    b.ToTable("Events");
                });
#pragma warning restore 612, 618
        }
    }
}
