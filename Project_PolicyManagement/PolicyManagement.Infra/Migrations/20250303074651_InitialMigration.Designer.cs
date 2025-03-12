﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PolicyManagement.Infra;

#nullable disable

namespace PolicyManagement.Infra.Migrations
{
    [DbContext(typeof(PolicyManagementDBContext))]
    [Migration("20250303074651_InitialMigration")]
    partial class InitialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.2");

            modelBuilder.Entity("PolicyManagement.Core.Policy", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("PolicyHolderName")
                        .HasColumnType("TEXT");

                    b.Property<string>("PolicyNumber")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Premium")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Policies");
                });
#pragma warning restore 612, 618
        }
    }
}
