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
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    { new Guid("859f0944-08fb-4ca5-940d-b4ca3e4a3719"), false, 0, 0, new DateTime(2022, 11, 17, 17, 55, 24, 759, DateTimeKind.Local).AddTicks(4158) },
                    { new Guid("bd0645da-c1c2-458d-991a-f0a068f8fb21"), false, 0, 0, new DateTime(2022, 11, 17, 15, 55, 24, 759, DateTimeKind.Local).AddTicks(4125) }
                });

            migrationBuilder.InsertData(
                table: "Player",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("5f2b918a-0410-4a66-a981-f39b7e86fd56"), "Yoran" },
                    { new Guid("82a0fd78-6800-4151-82ea-dd68fa9738eb"), "Benny" }
                });

            migrationBuilder.InsertData(
                table: "Throws",
                columns: new[] { "Id", "Score" },
                values: new object[,]
                {
                    { new Guid("0da10c9d-32a0-4846-9cc4-72e6e88e2824"), 57 },
                    { new Guid("148f292a-eca7-4a93-ac4d-d67768bfd021"), 16 },
                    { new Guid("189ced80-cab7-43d0-b520-99956c8bd510"), 50 },
                    { new Guid("3129179b-a483-432f-8a88-d5283d8b89a6"), 48 },
                    { new Guid("3c28101c-8997-4992-b651-12103ac9ac7d"), 60 },
                    { new Guid("427295ca-5e38-4f4a-b4ae-18405edfd0ae"), 18 },
                    { new Guid("453433fe-7cf5-458f-95bd-a2ff8d5e2d91"), 54 },
                    { new Guid("4560abe3-f04c-442b-90db-80dbcc17037f"), 40 },
                    { new Guid("4ed70dba-de50-44b2-95c0-0b29ec361d76"), 19 },
                    { new Guid("524ed78a-1302-4915-812b-4fc521ead30d"), 32 },
                    { new Guid("6225c953-e993-4a19-a494-0e1b31ae4535"), 45 },
                    { new Guid("65c9a142-37b8-4f0d-9af8-3a72f1ebc092"), 30 },
                    { new Guid("83f2040d-42a9-4833-993b-dc7a0b2c857b"), 15 },
                    { new Guid("8ee07d4c-fb36-4eaa-9cff-5560b34c97ac"), 34 },
                    { new Guid("97890e6b-934e-4051-90c6-a0607cfc3258"), 20 },
                    { new Guid("ced39781-dedd-49f7-a25c-ea7077420f97"), 51 },
                    { new Guid("db3f6211-3cf8-4889-82eb-94b1d42647e4"), 17 },
                    { new Guid("e6a37c7e-abb6-475a-9df1-4089ba277a59"), 38 },
                    { new Guid("e7c969b6-96f6-4e68-a660-79ec7c50f175"), 36 },
                    { new Guid("e97d958c-c767-4281-a375-9c153cd2d0b0"), 25 }
                });

            migrationBuilder.InsertData(
                table: "MatchPlayer",
                columns: new[] { "MatchesId", "PlayersId" },
                values: new object[,]
                {
                    { new Guid("859f0944-08fb-4ca5-940d-b4ca3e4a3719"), new Guid("5f2b918a-0410-4a66-a981-f39b7e86fd56") },
                    { new Guid("859f0944-08fb-4ca5-940d-b4ca3e4a3719"), new Guid("82a0fd78-6800-4151-82ea-dd68fa9738eb") },
                    { new Guid("bd0645da-c1c2-458d-991a-f0a068f8fb21"), new Guid("5f2b918a-0410-4a66-a981-f39b7e86fd56") },
                    { new Guid("bd0645da-c1c2-458d-991a-f0a068f8fb21"), new Guid("82a0fd78-6800-4151-82ea-dd68fa9738eb") }
                });

            migrationBuilder.InsertData(
                table: "PlayerThrows",
                columns: new[] { "Id", "MatchId", "PlayerId", "ThrowId", "TimeStamp" },
                values: new object[,]
                {
                    { new Guid("01291794-aa3d-4939-8cc3-0b19589cc9f2"), new Guid("859f0944-08fb-4ca5-940d-b4ca3e4a3719"), new Guid("5f2b918a-0410-4a66-a981-f39b7e86fd56"), new Guid("524ed78a-1302-4915-812b-4fc521ead30d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1590cadf-1442-4eb1-aecf-160436150a86"), new Guid("bd0645da-c1c2-458d-991a-f0a068f8fb21"), new Guid("82a0fd78-6800-4151-82ea-dd68fa9738eb"), new Guid("db3f6211-3cf8-4889-82eb-94b1d42647e4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1f1c0265-fcda-4ee8-a9eb-7e8e90586bdc"), new Guid("bd0645da-c1c2-458d-991a-f0a068f8fb21"), new Guid("5f2b918a-0410-4a66-a981-f39b7e86fd56"), new Guid("4560abe3-f04c-442b-90db-80dbcc17037f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2e59fdd6-cf1a-44e5-b2ab-0a6d0779de98"), new Guid("859f0944-08fb-4ca5-940d-b4ca3e4a3719"), new Guid("82a0fd78-6800-4151-82ea-dd68fa9738eb"), new Guid("83f2040d-42a9-4833-993b-dc7a0b2c857b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("44a71286-dfab-4691-9b7f-56de915c297c"), new Guid("bd0645da-c1c2-458d-991a-f0a068f8fb21"), new Guid("5f2b918a-0410-4a66-a981-f39b7e86fd56"), new Guid("ced39781-dedd-49f7-a25c-ea7077420f97"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a707a4ea-3c70-47a1-9acb-474dd5be38ae"), new Guid("bd0645da-c1c2-458d-991a-f0a068f8fb21"), new Guid("82a0fd78-6800-4151-82ea-dd68fa9738eb"), new Guid("65c9a142-37b8-4f0d-9af8-3a72f1ebc092"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d3974a7d-9be2-409b-a942-ca6ee8c36976"), new Guid("bd0645da-c1c2-458d-991a-f0a068f8fb21"), new Guid("82a0fd78-6800-4151-82ea-dd68fa9738eb"), new Guid("524ed78a-1302-4915-812b-4fc521ead30d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f00b9992-a3e9-4a4c-b62c-79a16f7def22"), new Guid("bd0645da-c1c2-458d-991a-f0a068f8fb21"), new Guid("5f2b918a-0410-4a66-a981-f39b7e86fd56"), new Guid("189ced80-cab7-43d0-b520-99956c8bd510"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
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
