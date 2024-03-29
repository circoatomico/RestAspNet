﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RestAspNet.Model.Context;

#nullable disable

namespace RestAspNet.Migrations
{
    [DbContext(typeof(MySQLContext))]
    partial class MySQLContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("RestAspNet.Model.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("author");

                    b.Property<DateTime>("LaunchDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("launch_date");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(65,30)")
                        .HasColumnName("price");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("title");

                    b.HasKey("Id");

                    b.ToTable("book");
                });

            modelBuilder.Entity("RestAspNet.Model.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("address");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("first_name");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("gender");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("last_name");

                    b.HasKey("Id");

                    b.ToTable("person");
                });
#pragma warning restore 612, 618
        }
    }
}
