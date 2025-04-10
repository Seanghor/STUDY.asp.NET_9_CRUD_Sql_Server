﻿// <auto-generated />
using ASP.NET_9_CRUD.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ASP.NET_9_CRUD.Migrations
{
    [DbContext(typeof(VideoGameDbContext))]
    [Migration("20250408182522_Seeding")]
    partial class Seeding
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ASP.NET_9_CRUD.VideoGame", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Developer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Platform")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Publisher")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("VideoGames");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Developer = "Seanghor",
                            Platform = "PS5",
                            Publisher = "Sony Interactive Entertainment",
                            Title = "Test"
                        },
                        new
                        {
                            Id = 2,
                            Developer = "Game Studio",
                            Platform = "PS4",
                            Publisher = "Big Games Inc.",
                            Title = "Adventure Quest"
                        },
                        new
                        {
                            Id = 3,
                            Developer = "Epic Developers",
                            Platform = "PC",
                            Publisher = "Super Games Co.",
                            Title = "Battle Royale"
                        },
                        new
                        {
                            Id = 4,
                            Developer = "SpeedWorks",
                            Platform = "Xbox",
                            Publisher = "Turbo Media",
                            Title = "Racing Rivals"
                        },
                        new
                        {
                            Id = 5,
                            Developer = "Galaxy Studios",
                            Platform = "PS5",
                            Publisher = "Cosmic Entertainment",
                            Title = "Space Odyssey"
                        },
                        new
                        {
                            Id = 6,
                            Developer = "Survival Games",
                            Platform = "PC",
                            Publisher = "Apocalypse Studios",
                            Title = "Zombie Defense"
                        },
                        new
                        {
                            Id = 7,
                            Developer = "Fantasy Makers",
                            Platform = "PS4",
                            Publisher = "DreamWorks Entertainment",
                            Title = "Fantasy World"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
