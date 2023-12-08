﻿// <auto-generated />
using EvangelionDatabase.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EvangelionDatabase.Migrations
{
    [DbContext(typeof(EVAContext))]
    partial class EVAContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.14");

            modelBuilder.Entity("EvangelionDatabase.Models.Evangelion", b =>
                {
                    b.Property<int>("EvangelionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("EVAName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Picture")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("EvangelionID");

                    b.ToTable("Evangelion");
                });

            modelBuilder.Entity("EvangelionDatabase.Models.Pilot", b =>
                {
                    b.Property<int>("PilotID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Picture")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("PilotID");

                    b.ToTable("Pilot");
                });

            modelBuilder.Entity("EvangelionDatabase.Models.PilotEvangelions", b =>
                {
                    b.Property<int>("EvangelionID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PilotID")
                        .HasColumnType("INTEGER");

                    b.HasKey("EvangelionID", "PilotID");

                    b.HasIndex("PilotID");

                    b.ToTable("PilotEvangelion");
                });

            modelBuilder.Entity("EvangelionDatabase.Models.PilotEvangelions", b =>
                {
                    b.HasOne("EvangelionDatabase.Models.Evangelion", "Evangelion")
                        .WithMany("PilotEvangelions")
                        .HasForeignKey("EvangelionID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EvangelionDatabase.Models.Pilot", "Pilot")
                        .WithMany("PilotEvangelions")
                        .HasForeignKey("PilotID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Evangelion");

                    b.Navigation("Pilot");
                });

            modelBuilder.Entity("EvangelionDatabase.Models.Evangelion", b =>
                {
                    b.Navigation("PilotEvangelions");
                });

            modelBuilder.Entity("EvangelionDatabase.Models.Pilot", b =>
                {
                    b.Navigation("PilotEvangelions");
                });
#pragma warning restore 612, 618
        }
    }
}
