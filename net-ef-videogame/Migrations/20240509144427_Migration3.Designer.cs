﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using net_ef_videogame;

#nullable disable

namespace net_ef_videogame.Migrations
{
    [DbContext(typeof(VideogamesContext))]
    [Migration("20240509144427_Migration3")]
    partial class Migration3
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SoftwareHouseVideogames", b =>
                {
                    b.Property<int>("SoftwareHouseListSoftwareHouseId")
                        .HasColumnType("int");

                    b.Property<int>("VideogamesId")
                        .HasColumnType("int");

                    b.HasKey("SoftwareHouseListSoftwareHouseId", "VideogamesId");

                    b.HasIndex("VideogamesId");

                    b.ToTable("SoftwareHouseVideogames");
                });

            modelBuilder.Entity("net_ef_videogame.SoftwareHouse", b =>
                {
                    b.Property<int>("SoftwareHouseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SoftwareHouseId"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VideogamesId")
                        .HasColumnType("int");

                    b.HasKey("SoftwareHouseId");

                    b.HasIndex("SoftwareHouseId")
                        .IsUnique();

                    b.ToTable("software_house");
                });

            modelBuilder.Entity("net_ef_videogame.Videogames", b =>
                {
                    b.Property<int>("VideogamesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VideogamesId"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("created_at");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Overview")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReleaseDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("release_date");

                    b.Property<int>("SoftwareHouseId")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("update_at");

                    b.HasKey("VideogamesId");

                    b.HasIndex("VideogamesId")
                        .IsUnique();

                    b.ToTable("videogames");
                });

            modelBuilder.Entity("SoftwareHouseVideogames", b =>
                {
                    b.HasOne("net_ef_videogame.SoftwareHouse", null)
                        .WithMany()
                        .HasForeignKey("SoftwareHouseListSoftwareHouseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("net_ef_videogame.Videogames", null)
                        .WithMany()
                        .HasForeignKey("VideogamesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}