﻿// <auto-generated />
using System;
using LeadsManagement.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LeadsManagement.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ContactDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.31");

            modelBuilder.Entity("LeadsManagement.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Photographer"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Attorney"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Medic"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Mechanic"
                        });
                });

            modelBuilder.Entity("LeadsManagement.Entities.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedDate")
                        .HasMaxLength(400)
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasMaxLength(80)
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(80)
                        .HasColumnType("TEXT");

                    b.Property<string>("Phone")
                        .HasMaxLength(9)
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(10,2)");

                    b.Property<int>("Status")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Suburb")
                        .HasMaxLength(80)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Contacts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            CreatedDate = new DateTime(2024, 2, 22, 5, 14, 24, 0, DateTimeKind.Local),
                            Description = "Neighborhood Friend",
                            Email = "fozemwet@nauri.ml",
                            Name = "Peter Parker",
                            Phone = "890258422",
                            Price = 600m,
                            Status = 0,
                            Suburb = "Forest Hills"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 2,
                            CreatedDate = new DateTime(2021, 1, 22, 14, 14, 24, 0, DateTimeKind.Local),
                            Description = "Avocado at Law",
                            Email = "kuz@iwocir.tc",
                            Name = "Matt Murdock",
                            Phone = "880649211",
                            Price = 200m,
                            Status = 0,
                            Suburb = "Hell's Kitchen"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 3,
                            CreatedDate = new DateTime(2024, 6, 22, 9, 14, 24, 0, DateTimeKind.Local),
                            Description = "The mightiest magician in the cosmos",
                            Email = "fozemwet@nauri.ml",
                            Name = "Stephen Strange",
                            Phone = "133486432",
                            Price = 600m,
                            Status = 0,
                            Suburb = "Greenwich Village"
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 4,
                            CreatedDate = new DateTime(2024, 2, 22, 15, 14, 24, 0, DateTimeKind.Local),
                            Description = "Genius, billionaire, playboy, philanthropist",
                            Email = "zohusnu@rog.so",
                            Name = "Tony Stark",
                            Phone = "433786225",
                            Price = 700.32m,
                            Status = 0,
                            Suburb = "Midtown Manhattan"
                        });
                });

            modelBuilder.Entity("LeadsManagement.Entities.Contact", b =>
                {
                    b.HasOne("LeadsManagement.Entities.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}
