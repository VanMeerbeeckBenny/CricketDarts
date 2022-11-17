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
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: true)
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
                    { new Guid("d004a7bc-fdbe-4863-b3a7-f43bc7768d06"), false, 0, 0, new DateTime(2022, 11, 17, 15, 16, 31, 652, DateTimeKind.Local).AddTicks(5206) },
                    { new Guid("f0b44a72-f0ba-4bda-95f7-c1a00f7e9c2a"), false, 0, 0, new DateTime(2022, 11, 17, 17, 16, 31, 652, DateTimeKind.Local).AddTicks(5243) }
                });

            migrationBuilder.InsertData(
                table: "Player",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("e6104999-3a67-4c2b-8a75-be59e8f3b45c"), "Benny" },
                    { new Guid("f61b7ff6-37ca-478d-ba07-fee73a7d3ce2"), "Yoran" }
                });

            migrationBuilder.InsertData(
                table: "Throws",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("15e8ceca-72f2-4ced-bea7-b72c573711d0"), "Eighteen" },
                    { new Guid("169f2077-0d49-4199-b8c0-aeed4f9e658c"), "DoubleNineTeen" },
                    { new Guid("3864c764-83d7-43ce-a229-cf9b2d224c8d"), "TripleNineTeen" },
                    { new Guid("62c29ebc-f067-4cc5-a704-9e08d2390d04"), "Sixteen" },
                    { new Guid("81fd397a-8180-493e-9706-7304e5c908c5"), "DoubleFifteen" },
                    { new Guid("85d79339-ee20-4e92-8251-ca456e73d2fa"), "NineTeen" },
                    { new Guid("8907580d-45ae-499a-929a-a4085ec1f60d"), "TripleEigteen" },
                    { new Guid("9bad692e-4c9d-4f99-bb3b-6abf56f072e7"), "Seventeen" },
                    { new Guid("a6a56027-ff15-4c10-8356-2cdf7cc0ef02"), "TripleSeventeen" },
                    { new Guid("b1b27c0e-d814-41ef-94cd-f0d23f81b266"), "TripleFifteen" },
                    { new Guid("b5d24613-7810-42fb-a2bd-4cb61115411a"), "TripleSixteen" },
                    { new Guid("b8c563f3-8dfb-4736-81f7-53e28c688473"), "DoubleSeventeen" },
                    { new Guid("b9ff2b1d-e79e-4eda-ba2e-15acb3469c4e"), "DoubleTwenty" },
                    { new Guid("c4cec053-2d99-4d06-a041-eab36a1e0c2a"), "Fifteen" },
                    { new Guid("c4d484ef-7cb7-4d5b-bc27-2a16b1d4f619"), "TripleTwenty" },
                    { new Guid("c4e1b884-c59d-49bd-a112-272536f5b79c"), "Twenty" },
                    { new Guid("d0db700d-a3e3-4222-a05d-4082db75ece1"), "BullInner" },
                    { new Guid("e4804415-f1e5-4439-ae3b-f971077a724a"), "DoubleSixteen" },
                    { new Guid("ed43897b-cb27-46c7-9c7d-ff9b91020cc3"), "DoubleEighteen" },
                    { new Guid("f8ee652e-b90d-4aac-ac17-be7770796224"), "BullOuter" }
                });

            migrationBuilder.InsertData(
                table: "MatchPlayer",
                columns: new[] { "MatchesId", "PlayersId" },
                values: new object[,]
                {
                    { new Guid("d004a7bc-fdbe-4863-b3a7-f43bc7768d06"), new Guid("e6104999-3a67-4c2b-8a75-be59e8f3b45c") },
                    { new Guid("d004a7bc-fdbe-4863-b3a7-f43bc7768d06"), new Guid("f61b7ff6-37ca-478d-ba07-fee73a7d3ce2") },
                    { new Guid("f0b44a72-f0ba-4bda-95f7-c1a00f7e9c2a"), new Guid("e6104999-3a67-4c2b-8a75-be59e8f3b45c") },
                    { new Guid("f0b44a72-f0ba-4bda-95f7-c1a00f7e9c2a"), new Guid("f61b7ff6-37ca-478d-ba07-fee73a7d3ce2") }
                });

            migrationBuilder.InsertData(
                table: "PlayerThrows",
                columns: new[] { "Id", "MatchId", "PlayerId", "ThrowId", "TimeStamp" },
                values: new object[,]
                {
                    { new Guid("140b944d-4600-406b-8b4e-1990a1a5c7ee"), new Guid("d004a7bc-fdbe-4863-b3a7-f43bc7768d06"), new Guid("e6104999-3a67-4c2b-8a75-be59e8f3b45c"), new Guid("81fd397a-8180-493e-9706-7304e5c908c5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3321b64d-427d-4ac5-b86c-d43cf57c2697"), new Guid("d004a7bc-fdbe-4863-b3a7-f43bc7768d06"), new Guid("f61b7ff6-37ca-478d-ba07-fee73a7d3ce2"), new Guid("a6a56027-ff15-4c10-8356-2cdf7cc0ef02"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4c412b6a-7f76-490b-88e2-575bdb51e8e9"), new Guid("f0b44a72-f0ba-4bda-95f7-c1a00f7e9c2a"), new Guid("e6104999-3a67-4c2b-8a75-be59e8f3b45c"), new Guid("c4cec053-2d99-4d06-a041-eab36a1e0c2a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6894acdb-1a87-40b8-a6b3-97e40f5c58dc"), new Guid("d004a7bc-fdbe-4863-b3a7-f43bc7768d06"), new Guid("e6104999-3a67-4c2b-8a75-be59e8f3b45c"), new Guid("9bad692e-4c9d-4f99-bb3b-6abf56f072e7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7822bfa8-a22c-4279-943c-62667452d76a"), new Guid("d004a7bc-fdbe-4863-b3a7-f43bc7768d06"), new Guid("f61b7ff6-37ca-478d-ba07-fee73a7d3ce2"), new Guid("d0db700d-a3e3-4222-a05d-4082db75ece1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7fe414a5-bbc4-4203-87c2-9d0e832e8604"), new Guid("d004a7bc-fdbe-4863-b3a7-f43bc7768d06"), new Guid("f61b7ff6-37ca-478d-ba07-fee73a7d3ce2"), new Guid("b9ff2b1d-e79e-4eda-ba2e-15acb3469c4e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("960f2d23-a55f-451c-8b15-861170e0a756"), new Guid("d004a7bc-fdbe-4863-b3a7-f43bc7768d06"), new Guid("e6104999-3a67-4c2b-8a75-be59e8f3b45c"), new Guid("e4804415-f1e5-4439-ae3b-f971077a724a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d87c468f-f565-46d0-a0c3-55b98ac8f3fa"), new Guid("f0b44a72-f0ba-4bda-95f7-c1a00f7e9c2a"), new Guid("f61b7ff6-37ca-478d-ba07-fee73a7d3ce2"), new Guid("e4804415-f1e5-4439-ae3b-f971077a724a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
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
                name: "IX_Throws_Name",
                table: "Throws",
                column: "Name",
                unique: true,
                filter: "[Name] IS NOT NULL");
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
