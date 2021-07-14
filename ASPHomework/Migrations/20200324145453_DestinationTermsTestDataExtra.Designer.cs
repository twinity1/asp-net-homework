﻿// <auto-generated />
using System;
using ASPHomework.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ASPHomework.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20200324145453_DestinationTermsTestDataExtra")]
    partial class DestinationTermsTestDataExtra
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ASPHomework.Persistence.Entities.Destination", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Destinations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Capacity = 14,
                            Description = "V období před řeckým osídlením zde žili Pelasgové (kontinentální Řecko) a Minóané (Kréta a některé ostrovy). Někdy ve 4.–3. tisíciletí před Kristem do Řecka",
                            Title = "Řecko"
                        },
                        new
                        {
                            Id = 2,
                            Capacity = 20,
                            Description = "Itálie, celým názvem Italská republika (italsky Italia a Repubblica Italiana) je stát ležící v ... K Itálii patří dva velké ostrovy ve Středozemním moři: Sardinie a Sicílie",
                            Title = "Itálie"
                        },
                        new
                        {
                            Id = 3,
                            Capacity = 5,
                            Description = "S 1,4 miliardy obyvatel je Čína nejlidnatější zemí světa, rozloha 9,6 milionu km² ji činí čtvrtým největším státem. Díky své rychle rostoucí ekonomice a vojenské síle",
                            Title = "Čína"
                        });
                });

            modelBuilder.Entity("ASPHomework.Persistence.Entities.DestinationTerm", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DestinationId")
                        .HasColumnType("int");

                    b.Property<DateTime>("From")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("To")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("DestinationId");

                    b.ToTable("DestinationTerm");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DestinationId = 1,
                            From = new DateTime(2020, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            To = new DateTime(2020, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            DestinationId = 1,
                            From = new DateTime(2020, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            To = new DateTime(2020, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            DestinationId = 1,
                            From = new DateTime(2020, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            To = new DateTime(2020, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            DestinationId = 1,
                            From = new DateTime(2020, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            To = new DateTime(2020, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 5,
                            DestinationId = 1,
                            From = new DateTime(2020, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            To = new DateTime(2020, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 6,
                            DestinationId = 1,
                            From = new DateTime(2020, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            To = new DateTime(2020, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 7,
                            DestinationId = 1,
                            From = new DateTime(2020, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            To = new DateTime(2020, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 8,
                            DestinationId = 1,
                            From = new DateTime(2020, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            To = new DateTime(2020, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 9,
                            DestinationId = 1,
                            From = new DateTime(2020, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            To = new DateTime(2020, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 10,
                            DestinationId = 1,
                            From = new DateTime(2020, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            To = new DateTime(2020, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 11,
                            DestinationId = 1,
                            From = new DateTime(2020, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            To = new DateTime(2020, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 12,
                            DestinationId = 2,
                            From = new DateTime(2020, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            To = new DateTime(2020, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 13,
                            DestinationId = 2,
                            From = new DateTime(2020, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            To = new DateTime(2020, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 14,
                            DestinationId = 2,
                            From = new DateTime(2020, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            To = new DateTime(2020, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 15,
                            DestinationId = 2,
                            From = new DateTime(2020, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            To = new DateTime(2020, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 16,
                            DestinationId = 2,
                            From = new DateTime(2020, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            To = new DateTime(2020, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 17,
                            DestinationId = 2,
                            From = new DateTime(2020, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            To = new DateTime(2020, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 18,
                            DestinationId = 2,
                            From = new DateTime(2020, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            To = new DateTime(2020, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 19,
                            DestinationId = 2,
                            From = new DateTime(2020, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            To = new DateTime(2020, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 20,
                            DestinationId = 2,
                            From = new DateTime(2020, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            To = new DateTime(2020, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 21,
                            DestinationId = 2,
                            From = new DateTime(2020, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            To = new DateTime(2020, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 22,
                            DestinationId = 2,
                            From = new DateTime(2020, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            To = new DateTime(2020, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 23,
                            DestinationId = 3,
                            From = new DateTime(2020, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            To = new DateTime(2020, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 24,
                            DestinationId = 3,
                            From = new DateTime(2020, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            To = new DateTime(2020, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 25,
                            DestinationId = 3,
                            From = new DateTime(2020, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            To = new DateTime(2020, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 26,
                            DestinationId = 3,
                            From = new DateTime(2020, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            To = new DateTime(2020, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 27,
                            DestinationId = 3,
                            From = new DateTime(2020, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            To = new DateTime(2020, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 28,
                            DestinationId = 3,
                            From = new DateTime(2020, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            To = new DateTime(2020, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 29,
                            DestinationId = 3,
                            From = new DateTime(2020, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            To = new DateTime(2020, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 30,
                            DestinationId = 3,
                            From = new DateTime(2020, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            To = new DateTime(2020, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 31,
                            DestinationId = 3,
                            From = new DateTime(2020, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            To = new DateTime(2020, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 32,
                            DestinationId = 3,
                            From = new DateTime(2020, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            To = new DateTime(2020, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 33,
                            DestinationId = 3,
                            From = new DateTime(2020, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            To = new DateTime(2020, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("ASPHomework.Persistence.Entities.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DestinationId")
                        .HasColumnType("int");

                    b.Property<int?>("DestinationTermId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("From")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumberOfPersons")
                        .HasColumnType("int");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("To")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("DestinationId");

                    b.HasIndex("DestinationTermId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("ASPHomework.Persistence.Entities.DestinationTerm", b =>
                {
                    b.HasOne("ASPHomework.Persistence.Entities.Destination", "Destination")
                        .WithMany("DestinationTerms")
                        .HasForeignKey("DestinationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ASPHomework.Persistence.Entities.Order", b =>
                {
                    b.HasOne("ASPHomework.Persistence.Entities.Destination", "Destination")
                        .WithMany()
                        .HasForeignKey("DestinationId");

                    b.HasOne("ASPHomework.Persistence.Entities.DestinationTerm", "DestinationTerm")
                        .WithMany("Orders")
                        .HasForeignKey("DestinationTermId");
                });
#pragma warning restore 612, 618
        }
    }
}
