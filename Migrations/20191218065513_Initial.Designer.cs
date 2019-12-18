﻿// <auto-generated />
using System;
using MeetingPlanner.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MeetingPlanner.Migrations
{
    [DbContext(typeof(MeetingPlannerContext))]
    [Migration("20191218065513_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MeetingPlanner.Models.Meeting", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClosingPrayer")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.Property<string>("ClosingSong");

                    b.Property<string>("ConductingLeader")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.Property<string>("OpeningPrayer")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.Property<string>("OpeningSong");

                    b.Property<string>("SacramentSong");

                    b.Property<string>("Speaker1")
                        .HasMaxLength(120);

                    b.Property<string>("Speaker2")
                        .HasMaxLength(120);

                    b.Property<string>("Speaker3")
                        .HasMaxLength(120);

                    b.Property<string>("Speaker4")
                        .HasMaxLength(120);

                    b.Property<string>("Speaker5")
                        .HasMaxLength(120);

                    b.Property<DateTime>("SpeechDate");

                    b.Property<string>("Topic");

                    b.HasKey("ID");

                    b.ToTable("Meeting");
                });
#pragma warning restore 612, 618
        }
    }
}
