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
    [Migration("20191219043253_SpeakerTopicChanges")]
    partial class SpeakerTopicChanges
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

                    b.Property<string>("ClosingSong")
                        .IsRequired();

                    b.Property<string>("ConductingLeader")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("OpeningPrayer")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.Property<string>("OpeningSong")
                        .IsRequired();

                    b.Property<string>("SacramentSong")
                        .IsRequired();

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

                    b.Property<int?>("SpeakerID");

                    b.Property<DateTime>("SpeechDate");

                    b.Property<string>("Topic")
                        .IsRequired();

                    b.Property<int?>("TopicID");

                    b.HasKey("ID");

                    b.HasIndex("SpeakerID");

                    b.HasIndex("TopicID");

                    b.ToTable("Meeting");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Meeting");
                });

            modelBuilder.Entity("MeetingPlanner.Models.Speaker", b =>
                {
                    b.HasBaseType("MeetingPlanner.Models.Meeting");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.ToTable("Speaker");

                    b.HasDiscriminator().HasValue("Speaker");
                });

            modelBuilder.Entity("MeetingPlanner.Models.Topic", b =>
                {
                    b.HasBaseType("MeetingPlanner.Models.Meeting");

                    b.Property<DateTime>("Date");

                    b.Property<string>("TopicName");

                    b.ToTable("Topic");

                    b.HasDiscriminator().HasValue("Topic");
                });

            modelBuilder.Entity("MeetingPlanner.Models.Meeting", b =>
                {
                    b.HasOne("MeetingPlanner.Models.Speaker")
                        .WithMany("Meetings")
                        .HasForeignKey("SpeakerID");

                    b.HasOne("MeetingPlanner.Models.Topic")
                        .WithMany("Meetings")
                        .HasForeignKey("TopicID");
                });
#pragma warning restore 612, 618
        }
    }
}
