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

            modelBuilder.Entity("MatchPlayer", b =>
                {
                    b.Property<Guid>("MatchesId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PlayersId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("MatchesId", "PlayersId");

                    b.HasIndex("PlayersId");

                    b.ToTable("MatchPlayer");

                    b.HasData(
                        new
                        {
                            MatchesId = new Guid("12502152-49db-4882-9a04-8df1a7b38969"),
                            PlayersId = new Guid("0ea0c441-d555-49c9-af61-40337e1ff5a8")
                        },
                        new
                        {
                            MatchesId = new Guid("13f862c0-f7b2-4d45-aa6d-d488a5f968ca"),
                            PlayersId = new Guid("0ea0c441-d555-49c9-af61-40337e1ff5a8")
                        },
                        new
                        {
                            MatchesId = new Guid("12502152-49db-4882-9a04-8df1a7b38969"),
                            PlayersId = new Guid("ac468341-f749-4c7c-a8c6-8b5b3cf10bcb")
                        },
                        new
                        {
                            MatchesId = new Guid("13f862c0-f7b2-4d45-aa6d-d488a5f968ca"),
                            PlayersId = new Guid("ac468341-f749-4c7c-a8c6-8b5b3cf10bcb")
                        });
                });

            modelBuilder.Entity("Pin.CricketDarts.Core.Entities.Match", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsActiveGame")
                        .HasColumnType("bit");

                    b.Property<int>("PlayerOneScore")
                        .HasColumnType("int");

                    b.Property<int>("PlayerTwoScore")
                        .HasColumnType("int");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Matches");

                    b.HasData(
                        new
                        {
                            Id = new Guid("12502152-49db-4882-9a04-8df1a7b38969"),
                            IsActiveGame = false,
                            PlayerOneScore = 0,
                            PlayerTwoScore = 0,
                            TimeStamp = new DateTime(2022, 11, 17, 14, 10, 33, 206, DateTimeKind.Local).AddTicks(5308)
                        },
                        new
                        {
                            Id = new Guid("13f862c0-f7b2-4d45-aa6d-d488a5f968ca"),
                            IsActiveGame = false,
                            PlayerOneScore = 0,
                            PlayerTwoScore = 0,
                            TimeStamp = new DateTime(2022, 11, 17, 16, 10, 33, 206, DateTimeKind.Local).AddTicks(5340)
                        });
                });

            modelBuilder.Entity("Pin.CricketDarts.Core.Entities.Player", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Player");

                    b.HasData(
                        new
                        {
                            Id = new Guid("0ea0c441-d555-49c9-af61-40337e1ff5a8"),
                            Name = "Benny"
                        },
                        new
                        {
                            Id = new Guid("ac468341-f749-4c7c-a8c6-8b5b3cf10bcb"),
                            Name = "Yoran"
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

                    b.Property<Guid>("ThrowId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("MatchId");

                    b.HasIndex("PlayerId");

                    b.HasIndex("ThrowId");

                    b.ToTable("PlayerThrows");

                    b.HasData(
                        new
                        {
                            Id = new Guid("6c519dfa-2ad5-4bf8-a52a-d50690b17566"),
                            MatchId = new Guid("13f862c0-f7b2-4d45-aa6d-d488a5f968ca"),
                            PlayerId = new Guid("0ea0c441-d555-49c9-af61-40337e1ff5a8"),
                            ThrowId = new Guid("9104787b-24ce-44a7-9d74-88a524cc152b"),
                            TimeStamp = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("f5789b62-bf29-44ce-a64a-5eaac0879873"),
                            MatchId = new Guid("12502152-49db-4882-9a04-8df1a7b38969"),
                            PlayerId = new Guid("0ea0c441-d555-49c9-af61-40337e1ff5a8"),
                            ThrowId = new Guid("6a984e5c-8eae-4165-93a4-c82b68b832e2"),
                            TimeStamp = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("8c2466f8-e014-4da8-9cd7-bcafda3cf550"),
                            MatchId = new Guid("12502152-49db-4882-9a04-8df1a7b38969"),
                            PlayerId = new Guid("0ea0c441-d555-49c9-af61-40337e1ff5a8"),
                            ThrowId = new Guid("7677032a-4405-4cd2-a6e6-58012b96b9cb"),
                            TimeStamp = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("c6ddcf77-8b64-40a0-89e6-81b17674432a"),
                            MatchId = new Guid("12502152-49db-4882-9a04-8df1a7b38969"),
                            PlayerId = new Guid("0ea0c441-d555-49c9-af61-40337e1ff5a8"),
                            ThrowId = new Guid("62daf55e-e7cf-421c-9d1b-a21012deae72"),
                            TimeStamp = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("2966f438-4e50-4019-9bcf-74e8c1012685"),
                            MatchId = new Guid("13f862c0-f7b2-4d45-aa6d-d488a5f968ca"),
                            PlayerId = new Guid("ac468341-f749-4c7c-a8c6-8b5b3cf10bcb"),
                            ThrowId = new Guid("7677032a-4405-4cd2-a6e6-58012b96b9cb"),
                            TimeStamp = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("890c682b-1870-4ff1-bae2-16f0f449d794"),
                            MatchId = new Guid("12502152-49db-4882-9a04-8df1a7b38969"),
                            PlayerId = new Guid("ac468341-f749-4c7c-a8c6-8b5b3cf10bcb"),
                            ThrowId = new Guid("b634742b-2bc4-42a2-9bb9-4be04da85795"),
                            TimeStamp = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("03605ef5-fd30-4853-bee9-34901439d9e4"),
                            MatchId = new Guid("12502152-49db-4882-9a04-8df1a7b38969"),
                            PlayerId = new Guid("ac468341-f749-4c7c-a8c6-8b5b3cf10bcb"),
                            ThrowId = new Guid("dd9fd715-c237-4d72-83d1-c9af05ffe852"),
                            TimeStamp = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("def0a654-df39-4fbc-b97b-0a776ba37508"),
                            MatchId = new Guid("12502152-49db-4882-9a04-8df1a7b38969"),
                            PlayerId = new Guid("ac468341-f749-4c7c-a8c6-8b5b3cf10bcb"),
                            ThrowId = new Guid("f3a6b41f-7b67-4e66-bc2b-d70222130fb0"),
                            TimeStamp = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("Pin.CricketDarts.Core.Entities.Throw", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Throws");

                    b.HasData(
                        new
                        {
                            Id = new Guid("9104787b-24ce-44a7-9d74-88a524cc152b"),
                            Name = "Fifteen"
                        },
                        new
                        {
                            Id = new Guid("6a984e5c-8eae-4165-93a4-c82b68b832e2"),
                            Name = "DoubleFifteen"
                        },
                        new
                        {
                            Id = new Guid("ce5ddebe-97db-4d51-b1de-755ff4269ac6"),
                            Name = "TripleFifteen"
                        },
                        new
                        {
                            Id = new Guid("ddcd125b-380e-4d94-a322-0a2e0f160c1c"),
                            Name = "Sixteen"
                        },
                        new
                        {
                            Id = new Guid("7677032a-4405-4cd2-a6e6-58012b96b9cb"),
                            Name = "DoubleSixteen"
                        },
                        new
                        {
                            Id = new Guid("e58db293-618c-43c2-8692-c24d8b5fe106"),
                            Name = "TripleSixteen"
                        },
                        new
                        {
                            Id = new Guid("62daf55e-e7cf-421c-9d1b-a21012deae72"),
                            Name = "Seventeen"
                        },
                        new
                        {
                            Id = new Guid("4fa7134a-2a37-4cfa-b4ba-9a2b4db0363c"),
                            Name = "DoubleSeventeen"
                        },
                        new
                        {
                            Id = new Guid("b634742b-2bc4-42a2-9bb9-4be04da85795"),
                            Name = "TripleSeventeen"
                        },
                        new
                        {
                            Id = new Guid("88405f54-c6ed-47df-80b5-0e42457002ab"),
                            Name = "Eighteen"
                        },
                        new
                        {
                            Id = new Guid("b84a8ee8-6e44-47ae-9410-1e1c2ce14213"),
                            Name = "DoubleEighteen"
                        },
                        new
                        {
                            Id = new Guid("f3adcd5f-49b6-4040-a8c1-2feada674475"),
                            Name = "TripleEigteen"
                        },
                        new
                        {
                            Id = new Guid("07c9eca6-80d7-4e89-a631-93822f0c4213"),
                            Name = "NineTeen"
                        },
                        new
                        {
                            Id = new Guid("379f3865-12b2-4038-8f78-b606481641de"),
                            Name = "DoubleNineTeen"
                        },
                        new
                        {
                            Id = new Guid("b65d0b0e-44d6-4ccb-85d4-baaa5e101686"),
                            Name = "TripleNineTeen"
                        },
                        new
                        {
                            Id = new Guid("78b9768b-739c-4493-9fe6-30727a06be4b"),
                            Name = "Twenty"
                        },
                        new
                        {
                            Id = new Guid("dd9fd715-c237-4d72-83d1-c9af05ffe852"),
                            Name = "DoubleTwenty"
                        },
                        new
                        {
                            Id = new Guid("0a053ee7-b5d1-44db-a98c-691c744bba83"),
                            Name = "TripleTwenty"
                        },
                        new
                        {
                            Id = new Guid("61abbd04-0ca6-475e-a313-e906c0e8db7e"),
                            Name = "BullOuter"
                        },
                        new
                        {
                            Id = new Guid("f3a6b41f-7b67-4e66-bc2b-d70222130fb0"),
                            Name = "BullInner"
                        });
                });

            modelBuilder.Entity("MatchPlayer", b =>
                {
                    b.HasOne("Pin.CricketDarts.Core.Entities.Match", null)
                        .WithMany()
                        .HasForeignKey("MatchesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Pin.CricketDarts.Core.Entities.Player", null)
                        .WithMany()
                        .HasForeignKey("PlayersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
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

                    b.HasOne("Pin.CricketDarts.Core.Entities.Throw", "Throws")
                        .WithMany("PlayerThrows")
                        .HasForeignKey("ThrowId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Match");

                    b.Navigation("Player");

                    b.Navigation("Throws");
                });

            modelBuilder.Entity("Pin.CricketDarts.Core.Entities.Player", b =>
                {
                    b.Navigation("AllThrows");
                });

            modelBuilder.Entity("Pin.CricketDarts.Core.Entities.Throw", b =>
                {
                    b.Navigation("PlayerThrows");
                });
#pragma warning restore 612, 618
        }
    }
}
