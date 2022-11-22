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
                    { new Guid("5cd5798f-c2db-4481-b98a-e604eaec6730"), false, 0, 0, new DateTime(2022, 11, 22, 14, 3, 43, 61, DateTimeKind.Local).AddTicks(7119) },
                    { new Guid("f58a9951-6c7e-4ae8-9a61-deabbfff2ff1"), false, 0, 0, new DateTime(2022, 11, 22, 12, 3, 43, 61, DateTimeKind.Local).AddTicks(7084) }
                });

            migrationBuilder.InsertData(
                table: "Player",
                columns: new[] { "Id", "Firstname", "Lastname" },
                values: new object[,]
                {
                    { new Guid("6cb78aa5-a80e-4c05-8f87-c443cc03e1d5"), "Benny", "Van Meerbeeck" },
                    { new Guid("e8607328-584e-4f53-91c8-27bc9bccf1c7"), "Arlette", "Verheugen" }
                });

            migrationBuilder.InsertData(
                table: "Throws",
                columns: new[] { "Id", "OriginalScore", "Score" },
                values: new object[,]
                {
                    { new Guid("045ab608-a24a-4269-b2f6-d04bfae64514"), 16, 32 },
                    { new Guid("12f5f777-661b-43a3-aa4a-d3bdd71debac"), 18, 18 },
                    { new Guid("24bc28f6-c105-44a6-8809-fcf2096b0e27"), 17, 17 },
                    { new Guid("3268cd2c-49a8-4d90-8f1e-029fc9e83585"), 19, 57 },
                    { new Guid("3a002642-4de8-4645-b9aa-0098f7f45622"), 25, 25 },
                    { new Guid("4f891845-faa8-4355-8488-aa85ec1394ca"), 15, 15 },
                    { new Guid("74929ccf-34e1-4e36-8b70-76a63a724da5"), 17, 34 },
                    { new Guid("77263662-d6d7-44bd-a4b3-622238c42b32"), 18, 54 },
                    { new Guid("7ee2d6f0-42d1-4e61-8132-0d0fa05aa5cb"), 25, 50 },
                    { new Guid("9c1f3bec-3ec3-4196-87a0-83674573928a"), 18, 36 },
                    { new Guid("9e4f032b-b2ba-4c2a-87f9-a0bc919211af"), 17, 51 },
                    { new Guid("a2064ea3-4e50-4b04-a07b-920efee29f53"), 20, 20 },
                    { new Guid("a73ccae1-1aa1-480b-98c1-2d56d6982119"), 15, 45 },
                    { new Guid("a764654b-de5e-41a0-b8c1-b5f0b376607d"), 20, 60 },
                    { new Guid("d12c7a1a-0587-4023-b509-8f8f14d60e1d"), 16, 48 },
                    { new Guid("d4eca901-88d6-4869-9e94-22fd87647d57"), 19, 19 },
                    { new Guid("dacbb0ea-4eb4-407f-9ab9-301649935540"), 19, 38 },
                    { new Guid("db2c392b-6280-4ec6-a915-54f3402178a6"), 15, 30 },
                    { new Guid("e48db23d-4342-44c9-b5da-5335a8e057bf"), 20, 40 },
                    { new Guid("fc89f956-b077-465b-a012-e354e6e74382"), 16, 16 }
                });

            migrationBuilder.InsertData(
                table: "MatchPlayer",
                columns: new[] { "MatchesId", "PlayersId" },
                values: new object[,]
                {
                    { new Guid("5cd5798f-c2db-4481-b98a-e604eaec6730"), new Guid("6cb78aa5-a80e-4c05-8f87-c443cc03e1d5") },
                    { new Guid("5cd5798f-c2db-4481-b98a-e604eaec6730"), new Guid("e8607328-584e-4f53-91c8-27bc9bccf1c7") },
                    { new Guid("f58a9951-6c7e-4ae8-9a61-deabbfff2ff1"), new Guid("6cb78aa5-a80e-4c05-8f87-c443cc03e1d5") },
                    { new Guid("f58a9951-6c7e-4ae8-9a61-deabbfff2ff1"), new Guid("e8607328-584e-4f53-91c8-27bc9bccf1c7") }
                });

            migrationBuilder.InsertData(
                table: "PlayerThrows",
                columns: new[] { "Id", "MatchId", "PlayerId", "ThrowId", "TimeStamp" },
                values: new object[,]
                {
                    { new Guid("311b6256-76e8-4860-afd6-ccc5a7f95b31"), new Guid("f58a9951-6c7e-4ae8-9a61-deabbfff2ff1"), new Guid("6cb78aa5-a80e-4c05-8f87-c443cc03e1d5"), new Guid("24bc28f6-c105-44a6-8809-fcf2096b0e27"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3203502b-1966-406f-946f-46642a675095"), new Guid("f58a9951-6c7e-4ae8-9a61-deabbfff2ff1"), new Guid("e8607328-584e-4f53-91c8-27bc9bccf1c7"), new Guid("e48db23d-4342-44c9-b5da-5335a8e057bf"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("382bac32-5ad4-4bee-8948-28ad4275a7b6"), new Guid("f58a9951-6c7e-4ae8-9a61-deabbfff2ff1"), new Guid("e8607328-584e-4f53-91c8-27bc9bccf1c7"), new Guid("7ee2d6f0-42d1-4e61-8132-0d0fa05aa5cb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3e14936e-7ab3-4aa7-97cd-27f8231435a8"), new Guid("f58a9951-6c7e-4ae8-9a61-deabbfff2ff1"), new Guid("6cb78aa5-a80e-4c05-8f87-c443cc03e1d5"), new Guid("db2c392b-6280-4ec6-a915-54f3402178a6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("86a00c7f-a3ed-475c-9682-cec441e2d279"), new Guid("f58a9951-6c7e-4ae8-9a61-deabbfff2ff1"), new Guid("6cb78aa5-a80e-4c05-8f87-c443cc03e1d5"), new Guid("045ab608-a24a-4269-b2f6-d04bfae64514"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8e7e5a4b-ae8e-40a9-8f8d-eec5dd7f752f"), new Guid("5cd5798f-c2db-4481-b98a-e604eaec6730"), new Guid("6cb78aa5-a80e-4c05-8f87-c443cc03e1d5"), new Guid("4f891845-faa8-4355-8488-aa85ec1394ca"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8f83843e-432d-451c-94d0-f83cac83e871"), new Guid("5cd5798f-c2db-4481-b98a-e604eaec6730"), new Guid("e8607328-584e-4f53-91c8-27bc9bccf1c7"), new Guid("045ab608-a24a-4269-b2f6-d04bfae64514"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ada10a6d-e065-429d-a8ad-68e21204ae9e"), new Guid("f58a9951-6c7e-4ae8-9a61-deabbfff2ff1"), new Guid("e8607328-584e-4f53-91c8-27bc9bccf1c7"), new Guid("9e4f032b-b2ba-4c2a-87f9-a0bc919211af"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
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
