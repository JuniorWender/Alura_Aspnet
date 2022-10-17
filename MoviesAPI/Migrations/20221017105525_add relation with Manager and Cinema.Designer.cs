﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MoviesAPI.Data;

#nullable disable

namespace MoviesAPI.Migrations
{
    [DbContext(typeof(MovieContext))]
    [Migration("20221017105525_add relation with Manager and Cinema")]
    partial class addrelationwithManagerandCinema
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("MoviesAPI.Models.Cinema", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("LocationFk")
                        .HasColumnType("int");

                    b.Property<int>("LocationId")
                        .HasColumnType("int");

                    b.Property<int>("ManagerId")
                        .HasColumnType("int");

                    b.Property<int>("ManegerFK")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("LocationId")
                        .IsUnique();

                    b.HasIndex("ManagerId");

                    b.ToTable("Cinemas");
                });

            modelBuilder.Entity("MoviesAPI.Models.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("district")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("MoviesAPI.Models.Manager", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Managers");
                });

            modelBuilder.Entity("MoviesAPI.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("MoviesAPI.Models.Cinema", b =>
                {
                    b.HasOne("MoviesAPI.Models.Location", "Location")
                        .WithOne("Cinema")
                        .HasForeignKey("MoviesAPI.Models.Cinema", "LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MoviesAPI.Models.Manager", "Manager")
                        .WithMany("Cinemas")
                        .HasForeignKey("ManagerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Location");

                    b.Navigation("Manager");
                });

            modelBuilder.Entity("MoviesAPI.Models.Location", b =>
                {
                    b.Navigation("Cinema")
                        .IsRequired();
                });

            modelBuilder.Entity("MoviesAPI.Models.Manager", b =>
                {
                    b.Navigation("Cinemas");
                });
#pragma warning restore 612, 618
        }
    }
}
