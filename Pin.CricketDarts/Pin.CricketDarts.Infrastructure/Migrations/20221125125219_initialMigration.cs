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
                    OriginalScore = table.Column<int>(type: "int", nullable: false),
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
                    ScoreId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                        name: "FK_PlayerThrows_Throws_ScoreId",
                        column: x => x.ScoreId,
                        principalTable: "Throws",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "IsActiveGame", "PlayerOneScore", "PlayerTwoScore", "TimeStamp" },
                values: new object[,]
                {
                    { new Guid("6c5f4c20-79c8-4bd1-8d41-02c1d6f3bc5b"), false, 0, 0, new DateTime(2022, 11, 25, 13, 52, 19, 317, DateTimeKind.Local).AddTicks(3028) },
                    { new Guid("6df8e9d8-f81e-4ac9-be1b-e2632766a9e6"), false, 0, 0, new DateTime(2022, 11, 25, 15, 52, 19, 317, DateTimeKind.Local).AddTicks(3065) }
                });

            migrationBuilder.InsertData(
                table: "Player",
                columns: new[] { "Id", "Firstname", "Lastname" },
                values: new object[,]
                {
                    { new Guid("1795865f-087b-4f50-afb0-6dca38280b4a"), "Benny", "Van Meerbeeck" },
                    { new Guid("df8ae62d-75f0-47e4-b099-0a8d0fc2fac0"), "Arlette", "Verheugen" }
                });

            migrationBuilder.InsertData(
                table: "Throws",
                columns: new[] { "Id", "OriginalScore", "Score" },
                values: new object[,]
                {
                    { new Guid("07270342-f74c-493f-8fa5-12847246a68d"), 17, 17 },
                    { new Guid("272d5916-d333-42bc-8b11-8efba96180ee"), 15, 30 },
                    { new Guid("3406eb3a-451d-45b4-b307-66112a9dcddc"), 20, 20 },
                    { new Guid("3842191c-37e8-44b6-b68f-bf4d36f3a495"), 19, 19 },
                    { new Guid("3913367c-9305-4bc7-b3df-f88606a45ed7"), 17, 51 },
                    { new Guid("4193d23b-6bee-415f-b44e-c67d42dd546d"), 18, 18 },
                    { new Guid("4cb5cd0c-1a80-475c-8af0-8236ca30382a"), 19, 57 },
                    { new Guid("57789352-df96-4c5d-9954-1ba279f8672c"), 19, 38 },
                    { new Guid("76407199-05cb-4caf-a2d2-4b8c0c8a2938"), 17, 34 },
                    { new Guid("7dbb9e71-f682-41ce-bbe0-816918667b40"), 18, 36 },
                    { new Guid("819e0c39-d956-4d1b-a584-5af18a92dcf7"), 16, 16 },
                    { new Guid("8862cbd5-f93f-4efd-b58a-36e871c7b9bf"), 20, 40 },
                    { new Guid("961b6d53-83c1-4f51-9264-448e92190192"), 25, 25 },
                    { new Guid("96380c15-7f0e-4a3e-850e-a60abde44c26"), 15, 15 },
                    { new Guid("b2e00493-4f3b-4b05-931e-d15514fbe6f0"), 25, 50 },
                    { new Guid("ee09d5e1-945a-4e08-87c7-142f5db84258"), 15, 45 },
                    { new Guid("ef529ab2-314f-42b6-8fdd-1a64280b972d"), 16, 48 },
                    { new Guid("f812a8a8-6f57-4357-a049-5b88e42b38f3"), 20, 60 },
                    { new Guid("fad69be9-f029-4adc-bf6c-072eb6e77a1a"), 18, 54 },
                    { new Guid("ff5d7ab5-76cc-4212-9f45-8d0de4dfdbb1"), 16, 32 }
                });

            migrationBuilder.InsertData(
                table: "MatchPlayer",
                columns: new[] { "MatchesId", "PlayersId" },
                values: new object[,]
                {
                    { new Guid("6c5f4c20-79c8-4bd1-8d41-02c1d6f3bc5b"), new Guid("1795865f-087b-4f50-afb0-6dca38280b4a") },
                    { new Guid("6c5f4c20-79c8-4bd1-8d41-02c1d6f3bc5b"), new Guid("df8ae62d-75f0-47e4-b099-0a8d0fc2fac0") },
                    { new Guid("6df8e9d8-f81e-4ac9-be1b-e2632766a9e6"), new Guid("1795865f-087b-4f50-afb0-6dca38280b4a") },
                    { new Guid("6df8e9d8-f81e-4ac9-be1b-e2632766a9e6"), new Guid("df8ae62d-75f0-47e4-b099-0a8d0fc2fac0") }
                });

            migrationBuilder.InsertData(
                table: "PlayerThrows",
                columns: new[] { "Id", "MatchId", "PlayerId", "ScoreId", "TimeStamp" },
                values: new object[,]
                {
                    { new Guid("2373743d-6597-4859-8054-78590047e61f"), new Guid("6c5f4c20-79c8-4bd1-8d41-02c1d6f3bc5b"), new Guid("df8ae62d-75f0-47e4-b099-0a8d0fc2fac0"), new Guid("b2e00493-4f3b-4b05-931e-d15514fbe6f0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2a18e5b6-e98b-4cf9-956f-9bbb54a55a81"), new Guid("6c5f4c20-79c8-4bd1-8d41-02c1d6f3bc5b"), new Guid("df8ae62d-75f0-47e4-b099-0a8d0fc2fac0"), new Guid("3913367c-9305-4bc7-b3df-f88606a45ed7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6ba23dd6-339c-47fe-87f2-be44f7293058"), new Guid("6c5f4c20-79c8-4bd1-8d41-02c1d6f3bc5b"), new Guid("df8ae62d-75f0-47e4-b099-0a8d0fc2fac0"), new Guid("8862cbd5-f93f-4efd-b58a-36e871c7b9bf"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9fc52830-5b1f-4bf5-a732-7339cdb51a30"), new Guid("6c5f4c20-79c8-4bd1-8d41-02c1d6f3bc5b"), new Guid("1795865f-087b-4f50-afb0-6dca38280b4a"), new Guid("272d5916-d333-42bc-8b11-8efba96180ee"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a69efc55-3e83-464a-8451-6cd4d32b1170"), new Guid("6c5f4c20-79c8-4bd1-8d41-02c1d6f3bc5b"), new Guid("1795865f-087b-4f50-afb0-6dca38280b4a"), new Guid("ff5d7ab5-76cc-4212-9f45-8d0de4dfdbb1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("bd113963-edaf-458a-9c60-c0a0e3441778"), new Guid("6df8e9d8-f81e-4ac9-be1b-e2632766a9e6"), new Guid("1795865f-087b-4f50-afb0-6dca38280b4a"), new Guid("96380c15-7f0e-4a3e-850e-a60abde44c26"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ce639335-402d-4b37-8e72-f06ab500d6f7"), new Guid("6df8e9d8-f81e-4ac9-be1b-e2632766a9e6"), new Guid("df8ae62d-75f0-47e4-b099-0a8d0fc2fac0"), new Guid("ff5d7ab5-76cc-4212-9f45-8d0de4dfdbb1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("fffc6ac8-9014-4d6a-8762-b1d3557406e1"), new Guid("6c5f4c20-79c8-4bd1-8d41-02c1d6f3bc5b"), new Guid("1795865f-087b-4f50-afb0-6dca38280b4a"), new Guid("07270342-f74c-493f-8fa5-12847246a68d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
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
                name: "IX_PlayerThrows_ScoreId",
                table: "PlayerThrows",
                column: "ScoreId");

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
