﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Vertical.Persistance;

namespace Vertical.Persistance.Migrations
{
    [DbContext(typeof(VerticalDbContext))]
    partial class VerticalDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Vertical.Domain.Entities.Department", b =>
                {
                    b.Property<int>("DeptId");

                    b.Property<DateTime?>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<string>("DeptName")
                        .HasMaxLength(600)
                        .IsUnicode(false);

                    b.Property<bool>("IsActive");

                    b.HasKey("DeptId");

                    b.ToTable("tblDepartment");
                });

            modelBuilder.Entity("Vertical.Domain.Entities.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsUnicode(false);

                    b.Property<int>("Age");

                    b.Property<string>("Contact")
                        .HasMaxLength(300)
                        .IsUnicode(false);

                    b.Property<DateTime?>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<int>("DeptId");

                    b.Property<string>("Email")
                        .IsUnicode(false);

                    b.Property<string>("Gender")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<bool>("IsActive");

                    b.Property<string>("Name")
                        .HasMaxLength(800)
                        .IsUnicode(false);

                    b.Property<double>("Salary");

                    b.HasKey("Id");

                    b.HasIndex("DeptId");

                    b.ToTable("tblEmployee");
                });

            modelBuilder.Entity("Vertical.Domain.Entities.Employee", b =>
                {
                    b.HasOne("Vertical.Domain.Entities.Department", "Department")
                        .WithMany("Employees")
                        .HasForeignKey("DeptId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
