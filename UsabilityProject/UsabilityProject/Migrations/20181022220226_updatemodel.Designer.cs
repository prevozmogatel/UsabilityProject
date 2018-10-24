﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UsabilityProject.Model;

namespace UsabilityProject.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20181022220226_updatemodel")]
    partial class updatemodel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("UsabilityProject.Model.AppRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("RoleName");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("UsabilityProject.Model.AppUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Date");

                    b.Property<int?>("DepartmentId");

                    b.Property<string>("Login");

                    b.Property<string>("Name");

                    b.Property<string>("Password");

                    b.Property<int?>("RoleId");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("UsabilityProject.Model.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DepartmentName");

                    b.HasKey("Id");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("UsabilityProject.Model.Sample", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AppUserId");

                    b.Property<DateTime>("Date");

                    b.Property<string>("Pressure");

                    b.Property<int?>("Pulse");

                    b.Property<int>("StressFactor");

                    b.Property<float?>("Temperature");

                    b.HasKey("Id");

                    b.HasIndex("AppUserId");

                    b.ToTable("Samples");
                });

            modelBuilder.Entity("UsabilityProject.Model.AppUser", b =>
                {
                    b.HasOne("UsabilityProject.Model.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DepartmentId");

                    b.HasOne("UsabilityProject.Model.AppRole", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId");
                });

            modelBuilder.Entity("UsabilityProject.Model.Sample", b =>
                {
                    b.HasOne("UsabilityProject.Model.AppUser", "User")
                        .WithMany()
                        .HasForeignKey("AppUserId");
                });
#pragma warning restore 612, 618
        }
    }
}
