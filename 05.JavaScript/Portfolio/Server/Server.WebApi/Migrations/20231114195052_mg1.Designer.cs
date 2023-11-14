﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Server.WebApi.Context;

#nullable disable

namespace Server.WebApi.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231114195052_mg1")]
    partial class mg1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Server.WebApi.Models.Experience", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Date")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Year")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Experiences");

                    b.HasData(
                        new
                        {
                            Id = new Guid("57247f2d-0f2f-4345-9036-7b7b3ad159d5"),
                            Date = "09.2011 - 08.2013",
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed efficitur ex sit amet massa scelerisque scelerisque. Aliquam erat volutpat. Aenean interdum finibus efficitur. Praesent dapibus dolor felis, eu ultrices elit molestie.",
                            Title = "Visual Art &amp; Design",
                            Year = "2 Years"
                        },
                        new
                        {
                            Id = new Guid("35abdada-bfa6-43ea-b0cd-e633f0a9034c"),
                            Date = "09.2011 - 08.2013",
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed efficitur ex sit amet massa scelerisque scelerisque. Aliquam erat volutpat. Aenean interdum finibus efficitur. Praesent dapibus dolor felis, eu ultrices elit molestie.",
                            Title = "Visual Art &amp; Design",
                            Year = "2 Years"
                        });
                });

            modelBuilder.Entity("Server.WebApi.Models.Project", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CoverImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Projects");

                    b.HasData(
                        new
                        {
                            Id = new Guid("7ee9fa3a-a766-4946-8733-feb744c631c2"),
                            CoverImageUrl = "project1.png",
                            Name = "e-Muhasebe Projesi"
                        },
                        new
                        {
                            Id = new Guid("efcf0a87-6c65-4c5c-8653-ac4449f5fb4c"),
                            CoverImageUrl = "project2.png",
                            Name = "e-Finans Projesi"
                        },
                        new
                        {
                            Id = new Guid("9a5a4b2f-6ab1-4bc4-8c43-7f91ee53e470"),
                            CoverImageUrl = "project3.png",
                            Name = "My Portfolio Projesi"
                        });
                });

            modelBuilder.Entity("Server.WebApi.Models.Skill", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<byte[]>("Image")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Order")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Skills");

                    b.HasData(
                        new
                        {
                            Id = new Guid("56ca28fa-9edc-464e-bd49-2e5015183bf2"),
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/e/ee/.NET_Core_Logo.svg/2048px-.NET_Core_Logo.svg.png",
                            Order = 1
                        },
                        new
                        {
                            Id = new Guid("5c22a5bf-e94e-4ba7-aa82-b31df29fa3bd"),
                            ImageUrl = "https://blog.ninja-squad.com/assets/images/angular_gradient.png",
                            Order = 2
                        },
                        new
                        {
                            Id = new Guid("db859682-65c5-4ca9-ac19-ae926fa1c12d"),
                            ImageUrl = "https://pluralsight2.imgix.net/paths/images/domain-driven-design-6d10f953a0.png",
                            Order = 3
                        },
                        new
                        {
                            Id = new Guid("abd7b816-52df-4949-833a-786710a1d234"),
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/e/ea/Docker_%28container_engine%29_logo_%28cropped%29.png",
                            Order = 4
                        });
                });
#pragma warning restore 612, 618
        }
    }
}