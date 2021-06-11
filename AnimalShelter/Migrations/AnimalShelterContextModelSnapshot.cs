﻿// <auto-generated />
using AnimalShelter.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AnimalShelter.Migrations
{
    [DbContext(typeof(AnimalShelterContext))]
    partial class AnimalShelterContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("AnimalShelter.Pet", b =>
                {
                    b.Property<int>("PetId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Breed")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("varchar(3) CHARACTER SET utf8mb4");

                    b.HasKey("PetId");

                    b.ToTable("Pets");

                    b.HasData(
                        new
                        {
                            PetId = 1,
                            Age = 3,
                            Breed = "RagaMuffin",
                            Description = "Long Haired; White/Orangish in color",
                            Gender = "Female",
                            Name = "Tiffany",
                            Type = "Cat"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
