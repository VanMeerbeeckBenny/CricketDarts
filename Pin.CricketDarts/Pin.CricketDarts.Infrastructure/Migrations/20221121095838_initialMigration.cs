using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Pin.CricketDarts.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class initialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Matches",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PlayerOneScore = table.Column<int>(type: "int", nullable: false),
                    PlayerTwoScore = table.Column<int>(type: "int", nullable: false),
                    TimeStamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActiveGame = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Matches", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Player",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Firstname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Lastname = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Player", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Throws",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Score = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Throws", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MatchPlayer",
                columns: table => new
                {
                    MatchesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PlayersId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MatchPlayer", x => new { x.MatchesId, x.PlayersId });
                    table.ForeignKey(
                        name: "FK_MatchPlayer_Matches_MatchesId",
                        column: x => x.MatchesId,
                        principalTable: "Matches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MatchPlayer_Player_PlayersId",
                        column: x => x.PlayersId,
                        principalTable: "Player",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlayerThrows",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MatchId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PlayerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ThrowId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TimeStamp = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerThrows", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlayerThrows_Matches_MatchId",
                        column: x => x.MatchId,
                        principalTable: "Matches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlayerThrows_Player_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Player",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlayerThrows_Throws_ThrowId",
                        column: x => x.ThrowId,
                        principalTable: "Throws",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "IsActiveGame", "PlayerOneScore", "PlayerTwoScore", "TimeStamp" },
                values: new object[,]
                {
                    { new Guid("16d9d127-f6ec-453e-86e6-188b1f9d91ef"), false, 0, 0, new DateTime(2022, 11, 21, 12, 58, 38, 606, DateTimeKind.Local).AddTicks(5976) },
                    { new Guid("fe34ff9b-c91f-4589-bd99-60849ddef2cc"), false, 0, 0, new DateTime(2022, 11, 21, 10, 58, 38, 606, DateTimeKind.Local).AddTicks(5937) }
                });

            migrationBuilder.InsertData(
                table: "Player",
                columns: new[] { "Id", "Firstname", "Lastname" },
                values: new object[,]
                {
                    { new Guid("2b095fe1-8b94-4cd9-bfa9-d12cecff3637"), "Benny", "Van Meerbeeck" },
                    { new Guid("ab4f02c5-cd21-439d-9b3f-68d3c5699ef2"), "Arlette", "Verheugen" }
                });

            migrationBuilder.InsertData(
                table: "Throws",
                columns: new[] { "Id", "Score" },
                values: new object[,]
                {
                    { new Guid("383206d0-2a01-474f-b8f7-ec22ac33950f"), 50 },
                    { new Guid("3f975c51-6eb6-4852-8bc5-47a0e5ac2ff1"), 51 },
                    { new Guid("59e8b242-2a8e-4e52-85ad-a9b6e47882a9"), 48 },
                    { new Guid("5ab532fe-396b-446c-8470-097eb17c927e"), 16 },
                    { new Guid("735c406a-18ca-4608-850e-f389ac4c4bd0"), 34 },
                    { new Guid("7c3bf391-72fc-4b9b-8da3-22bdc8157a31"), 36 },
                    { new Guid("7fff1dd5-14f5-4830-83b4-b7e15043a55d"), 38 },
                    { new Guid("8a4812eb-df35-4af9-a039-4f60c3c8bd4b"), 17 },
                    { new Guid("8f622ae8-cf51-4690-b892-fcd17a6ae7d5"), 32 },
                    { new Guid("a8a71ea6-95e2-4ee5-a7b2-56268de3f945"), 60 },
                    { new Guid("b02bafbd-5863-42d4-a6a8-f14c36b4a952"), 40 },
                    { new Guid("b75c9bf8-e5ab-440c-8e26-1772e13b9f1d"), 15 },
                    { new Guid("b95ea2ac-e098-47fb-a0e7-f96926976868"), 18 },
                    { new Guid("c2ebc31c-182c-4d58-b891-6fc075d664b2"), 54 },
                    { new Guid("c2fdc080-6af5-4568-b3e9-ed5dec946c2b"), 25 },
                    { new Guid("cbdf7449-7624-42cc-99ae-112d1fdde073"), 57 },
                    { new Guid("d624c2a9-bc3e-4823-9dad-7da90fcd554f"), 20 },
                    { new Guid("e3d6ed56-0dcd-4818-a087-40ad3fbbcb65"), 19 },
                    { new Guid("f5ea09e2-419d-45a0-b3ad-2a77e781a4bf"), 45 },
                    { new Guid("fb6495e0-01ff-4bf5-a919-b6f8e7dc4fd6"), 30 }
                });

            migrationBuilder.InsertData(
                table: "MatchPlayer",
                columns: new[] { "MatchesId", "PlayersId" },
                values: new object[,]
                {
                    { new Guid("16d9d127-f6ec-453e-86e6-188b1f9d91ef"), new Guid("2b095fe1-8b94-4cd9-bfa9-d12cecff3637") },
                    { new Guid("16d9d127-f6ec-453e-86e6-188b1f9d91ef"), new Guid("ab4f02c5-cd21-439d-9b3f-68d3c5699ef2") },
                    { new Guid("fe34ff9b-c91f-4589-bd99-60849ddef2cc"), new Guid("2b095fe1-8b94-4cd9-bfa9-d12cecff3637") },
                    { new Guid("fe34ff9b-c91f-4589-bd99-60849ddef2cc"), new Guid("ab4f02c5-cd21-439d-9b3f-68d3c5699ef2") }
                });

            migrationBuilder.InsertData(
                table: "PlayerThrows",
                columns: new[] { "Id", "MatchId", "PlayerId", "ThrowId", "TimeStamp" },
                values: new object[,]
                {
                    { new Guid("1101573f-3868-46bd-9fc4-0358fd841080"), new Guid("16d9d127-f6ec-453e-86e6-188b1f9d91ef"), new Guid("ab4f02c5-cd21-439d-9b3f-68d3c5699ef2"), new Guid("8f622ae8-cf51-4690-b892-fcd17a6ae7d5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4d6ac8b2-6cef-411f-89c4-079c9553eb8f"), new Guid("fe34ff9b-c91f-4589-bd99-60849ddef2cc"), new Guid("2b095fe1-8b94-4cd9-bfa9-d12cecff3637"), new Guid("fb6495e0-01ff-4bf5-a919-b6f8e7dc4fd6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7cb2557f-4264-42ad-8411-a864de385c33"), new Guid("16d9d127-f6ec-453e-86e6-188b1f9d91ef"), new Guid("2b095fe1-8b94-4cd9-bfa9-d12cecff3637"), new Guid("b75c9bf8-e5ab-440c-8e26-1772e13b9f1d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("987eadfc-fd57-4ef0-a3b5-98ba0360afcc"), new Guid("fe34ff9b-c91f-4589-bd99-60849ddef2cc"), new Guid("ab4f02c5-cd21-439d-9b3f-68d3c5699ef2"), new Guid("3f975c51-6eb6-4852-8bc5-47a0e5ac2ff1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b24f9f0d-7e4e-436c-8147-75922ae670f2"), new Guid("fe34ff9b-c91f-4589-bd99-60849ddef2cc"), new Guid("2b095fe1-8b94-4cd9-bfa9-d12cecff3637"), new Guid("8f622ae8-cf51-4690-b892-fcd17a6ae7d5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("cb19d43c-e0b5-4dd0-a5cc-5c4a07987f0d"), new Guid("fe34ff9b-c91f-4589-bd99-60849ddef2cc"), new Guid("ab4f02c5-cd21-439d-9b3f-68d3c5699ef2"), new Guid("b02bafbd-5863-42d4-a6a8-f14c36b4a952"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f33b7cf3-aaec-478c-a0d4-a858d74d5a32"), new Guid("fe34ff9b-c91f-4589-bd99-60849ddef2cc"), new Guid("2b095fe1-8b94-4cd9-bfa9-d12cecff3637"), new Guid("8a4812eb-df35-4af9-a039-4f60c3c8bd4b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f7f3a8ca-291f-47a3-89bc-b7d80ffbfd8b"), new Guid("fe34ff9b-c91f-4589-bd99-60849ddef2cc"), new Guid("ab4f02c5-cd21-439d-9b3f-68d3c5699ef2"), new Guid("383206d0-2a01-474f-b8f7-ec22ac33950f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_MatchPlayer_PlayersId",
                table: "MatchPlayer",
                column: "PlayersId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerThrows_MatchId",
                table: "PlayerThrows",
                column: "MatchId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerThrows_PlayerId",
                table: "PlayerThrows",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerThrows_ThrowId",
                table: "PlayerThrows",
                column: "ThrowId");

            migrationBuilder.CreateIndex(
                name: "IX_Throws_Score",
                table: "Throws",
                column: "Score",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MatchPlayer");

            migrationBuilder.DropTable(
                name: "PlayerThrows");

            migrationBuilder.DropTable(
                name: "Matches");

            migrationBuilder.DropTable(
                name: "Player");

            migrationBuilder.DropTable(
                name: "Throws");
        }
    }
}
