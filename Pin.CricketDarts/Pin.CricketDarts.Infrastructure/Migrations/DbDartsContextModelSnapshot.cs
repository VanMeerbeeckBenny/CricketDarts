﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Pin.CricketDarts.Infrastructure.Data;

#nullable disable

namespace Pin.CricketDarts.Infrastructure.Migrations
{
    [DbContext(typeof(DbDartsContext))]
    partial class DbDartsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Pin.CricketDarts.Core.Entities.Match", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsActiveGame")
                        .HasColumnType("bit");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Matches");
                });

            modelBuilder.Entity("Pin.CricketDarts.Core.Entities.MatchPlayer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool?>("IsWin")
                        .HasColumnType("bit");

                    b.Property<Guid>("MatchId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PlayerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Score")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MatchId");

                    b.HasIndex("PlayerId");

                    b.ToTable("MatchPlayer");
                });

            modelBuilder.Entity("Pin.CricketDarts.Core.Entities.Player", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Firstname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lastname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Player");

                    b.HasData(
                        new
                        {
                            Id = new Guid("70d4dd9c-ca1e-4cee-b97e-64e6217cee38"),
                            Firstname = "Benny",
                            Lastname = "Van Meerbeeck"
                        },
                        new
                        {
                            Id = new Guid("c7e4fd61-c835-4c2e-a7c2-85c8018dda4a"),
                            Firstname = "Arlette",
                            Lastname = "Verheugen"
                        });
                });

            modelBuilder.Entity("Pin.CricketDarts.Core.Entities.PlayerThrow", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("MatchId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PlayerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ScoreId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("MatchId");

                    b.HasIndex("PlayerId");

                    b.HasIndex("ScoreId");

                    b.ToTable("PlayerThrow");
                });

            modelBuilder.Entity("Pin.CricketDarts.Core.Entities.Point", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("OriginalScore")
                        .HasColumnType("int");

                    b.Property<int>("Score")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Score")
                        .IsUnique();

                    b.ToTable("Throws");

                    b.HasData(
                        new
                        {
                            Id = new Guid("9ae38da2-30f3-4eb4-997f-65be8bdbe46a"),
                            OriginalScore = 15,
                            Score = 15
                        },
                        new
                        {
                            Id = new Guid("b0be15a8-aa36-4772-915e-b44d8a36798c"),
                            OriginalScore = 15,
                            Score = 30
                        },
                        new
                        {
                            Id = new Guid("a44178a4-3cc1-4104-b574-c9f76aa1bdcc"),
                            OriginalScore = 15,
                            Score = 45
                        },
                        new
                        {
                            Id = new Guid("fcdf2e3f-f862-44b7-aaba-c445567a832d"),
                            OriginalScore = 16,
                            Score = 16
                        },
                        new
                        {
                            Id = new Guid("d8e50934-53ed-4993-a5a4-09897c82fb08"),
                            OriginalScore = 16,
                            Score = 32
                        },
                        new
                        {
                            Id = new Guid("88c2ed10-27bf-498d-80cc-cca69e7e3ebb"),
                            OriginalScore = 16,
                            Score = 48
                        },
                        new
                        {
                            Id = new Guid("2062304c-094f-4324-ab88-43dc2dc52be0"),
                            OriginalScore = 17,
                            Score = 17
                        },
                        new
                        {
                            Id = new Guid("2a51b458-a345-4685-a3dc-ac5b1b6396f3"),
                            OriginalScore = 17,
                            Score = 34
                        },
                        new
                        {
                            Id = new Guid("7c593215-7ef7-468d-94b8-60961c41a55c"),
                            OriginalScore = 17,
                            Score = 51
                        },
                        new
                        {
                            Id = new Guid("a512e36d-de88-4fa7-9d5e-1b3cb5cc1f7d"),
                            OriginalScore = 18,
                            Score = 18
                        },
                        new
                        {
                            Id = new Guid("aa1eb109-1137-42a0-8ce0-a815641dca5b"),
                            OriginalScore = 18,
                            Score = 36
                        },
                        new
                        {
                            Id = new Guid("e7ee8998-a556-4273-bb85-4bfd53d09c6f"),
                            OriginalScore = 18,
                            Score = 54
                        },
                        new
                        {
                            Id = new Guid("de312ef5-68d6-4c51-9760-4429e12ff544"),
                            OriginalScore = 19,
                            Score = 19
                        },
                        new
                        {
                            Id = new Guid("e722e6e3-b8c6-4845-ac39-789cce297226"),
                            OriginalScore = 19,
                            Score = 38
                        },
                        new
                        {
                            Id = new Guid("28b1e44e-4bff-469d-8d4e-1be32dfb8f79"),
                            OriginalScore = 19,
                            Score = 57
                        },
                        new
                        {
                            Id = new Guid("72ea3e52-d2e7-4d25-995c-569bb88b42bc"),
                            OriginalScore = 20,
                            Score = 20
                        },
                        new
                        {
                            Id = new Guid("ee2d37c9-20b5-46c0-8239-355ba15dd8d4"),
                            OriginalScore = 20,
                            Score = 40
                        },
                        new
                        {
                            Id = new Guid("0f7fe713-1b4f-42f2-8a47-53b971c33992"),
                            OriginalScore = 20,
                            Score = 60
                        },
                        new
                        {
                            Id = new Guid("d363198a-7276-416e-905c-6f7b538fc751"),
                            OriginalScore = 25,
                            Score = 25
                        },
                        new
                        {
                            Id = new Guid("df242db9-cebf-4129-bc4b-35f2bc2d59d1"),
                            OriginalScore = 25,
                            Score = 50
                        });
                });

            modelBuilder.Entity("Pin.CricketDarts.Core.Entities.MatchPlayer", b =>
                {
                    b.HasOne("Pin.CricketDarts.Core.Entities.Match", "Match")
                        .WithMany("PlayerMatch")
                        .HasForeignKey("MatchId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Pin.CricketDarts.Core.Entities.Player", "Player")
                        .WithMany("Matches")
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Match");

                    b.Navigation("Player");
                });

            modelBuilder.Entity("Pin.CricketDarts.Core.Entities.PlayerThrow", b =>
                {
                    b.HasOne("Pin.CricketDarts.Core.Entities.Match", "Match")
                        .WithMany()
                        .HasForeignKey("MatchId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Pin.CricketDarts.Core.Entities.Player", "Player")
                        .WithMany("AllThrows")
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Pin.CricketDarts.Core.Entities.Point", "Score")
                        .WithMany("PlayerThrows")
                        .HasForeignKey("ScoreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Match");

                    b.Navigation("Player");

                    b.Navigation("Score");
                });

            modelBuilder.Entity("Pin.CricketDarts.Core.Entities.Match", b =>
                {
                    b.Navigation("PlayerMatch");
                });

            modelBuilder.Entity("Pin.CricketDarts.Core.Entities.Player", b =>
                {
                    b.Navigation("AllThrows");

                    b.Navigation("Matches");
                });

            modelBuilder.Entity("Pin.CricketDarts.Core.Entities.Point", b =>
                {
                    b.Navigation("PlayerThrows");
                });
#pragma warning restore 612, 618
        }
    }
}
