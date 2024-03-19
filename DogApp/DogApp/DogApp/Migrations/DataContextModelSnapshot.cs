﻿// <auto-generated />
using System;
using DogApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DogApp.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DogApp.Modellayer.Model.Items.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ItemCategory")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PlacementId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PlacementId");

                    b.ToTable("Items");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Description of Sign 1",
                            Image = "hest",
                            ItemCategory = 0,
                            Name = "Sign 1"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Description of Sign 2",
                            Image = "hest",
                            ItemCategory = 0,
                            Name = "Sign 2"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Description of Sign 3",
                            Image = "hest",
                            ItemCategory = 0,
                            Name = "Sign 3"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Description of Sign 4",
                            Image = "hest",
                            ItemCategory = 0,
                            Name = "Sign 4"
                        },
                        new
                        {
                            Id = 5,
                            Description = "Description of Sign 5",
                            Image = "hest",
                            ItemCategory = 0,
                            Name = "Sign 5"
                        },
                        new
                        {
                            Id = 6,
                            Description = "Description of Extra 1",
                            Image = "hest",
                            ItemCategory = 1,
                            Name = "Extra 1"
                        },
                        new
                        {
                            Id = 7,
                            Description = "Description of Extra 2",
                            Image = "hest",
                            ItemCategory = 1,
                            Name = "Extra 2"
                        },
                        new
                        {
                            Id = 8,
                            Description = "Description of Extra 3",
                            Image = "hest",
                            ItemCategory = 1,
                            Name = "Extra 3"
                        },
                        new
                        {
                            Id = 9,
                            Description = "Description of Extra 4",
                            Image = "hest",
                            ItemCategory = 1,
                            Name = "Extra 4"
                        },
                        new
                        {
                            Id = 10,
                            Description = "Description of Extra 5",
                            Image = "hest",
                            ItemCategory = 1,
                            Name = "Extra 5"
                        });
                });

            modelBuilder.Entity("DogApp.Modellayer.Model.Items.Placement", b =>
                {
                    b.Property<int>("PlacementId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PlacementId"));

                    b.Property<int>("X")
                        .HasColumnType("int");

                    b.Property<int>("Y")
                        .HasColumnType("int");

                    b.HasKey("PlacementId");

                    b.ToTable("Placements");
                });

            modelBuilder.Entity("DogApp.Modellayer.Model.Rally", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Height")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Width")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Rally");
                });

            modelBuilder.Entity("ItemRally", b =>
                {
                    b.Property<int>("ItemsId")
                        .HasColumnType("int");

                    b.Property<int>("RallyId")
                        .HasColumnType("int");

                    b.HasKey("ItemsId", "RallyId");

                    b.HasIndex("RallyId");

                    b.ToTable("ItemRally");
                });

            modelBuilder.Entity("DogApp.Modellayer.Model.Items.Item", b =>
                {
                    b.HasOne("DogApp.Modellayer.Model.Items.Placement", null)
                        .WithMany("Items")
                        .HasForeignKey("PlacementId");
                });

            modelBuilder.Entity("ItemRally", b =>
                {
                    b.HasOne("DogApp.Modellayer.Model.Items.Item", null)
                        .WithMany()
                        .HasForeignKey("ItemsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DogApp.Modellayer.Model.Rally", null)
                        .WithMany()
                        .HasForeignKey("RallyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DogApp.Modellayer.Model.Items.Placement", b =>
                {
                    b.Navigation("Items");
                });
#pragma warning restore 612, 618
        }
    }
}
