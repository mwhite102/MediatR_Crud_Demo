﻿// <auto-generated />
using MediatRDemo.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MediatRDemo.Migrations
{
    [DbContext(typeof(ContactsDbContext))]
    [Migration("20240307172859_IntitalCreate")]
    partial class IntitalCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.2");

            modelBuilder.Entity("MediatRDemo.Models.Contact", b =>
                {
                    b.Property<int>("ContactId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ContactId");

                    b.ToTable("Contacts", (string)null);

                    b.HasData(
                        new
                        {
                            ContactId = 1,
                            Address = "",
                            Email = "rLpT1@example.com",
                            Name = "John Doe",
                            Notes = "",
                            Phone = "555-555-5555"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
