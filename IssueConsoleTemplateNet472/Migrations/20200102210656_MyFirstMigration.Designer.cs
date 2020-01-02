﻿// <auto-generated />
using IssueConsoleTemplateNet472;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace IssueConsoleTemplateNet472.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20200102210656_MyFirstMigration")]
    partial class MyFirstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("IssueConsoleTemplateNet472.IceCream", b =>
                {
                    b.Property<int>("IceCreamId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(512) CHARACTER SET utf8mb4")
                        .HasMaxLength(512);

                    b.HasKey("IceCreamId");

                    b.ToTable("IceCreams");

                    b.HasData(
                        new
                        {
                            IceCreamId = 1,
                            Name = "Vanilla"
                        },
                        new
                        {
                            IceCreamId = 2,
                            Name = "Chocolate"
                        },
                        new
                        {
                            IceCreamId = 3,
                            Name = "Strawberry"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
