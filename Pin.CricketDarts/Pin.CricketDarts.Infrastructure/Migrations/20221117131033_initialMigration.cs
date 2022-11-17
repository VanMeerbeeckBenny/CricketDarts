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
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    { new Guid("12502152-49db-4882-9a04-8df1a7b38969"), false, 0, 0, new DateTime(2022, 11, 17, 14, 10, 33, 206, DateTimeKind.Local).AddTicks(5308) },
                    { new Guid("13f862c0-f7b2-4d45-aa6d-d488a5f968ca"), false, 0, 0, new DateTime(2022, 11, 17, 16, 10, 33, 206, DateTimeKind.Local).AddTicks(5340) }
                });

            migrationBuilder.InsertData(
                table: "Player",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("0ea0c441-d555-49c9-af61-40337e1ff5a8"), "Benny" },
                    { new Guid("ac468341-f749-4c7c-a8c6-8b5b3cf10bcb"), "Yoran" }
                });

            migrationBuilder.InsertData(
                table: "Throws",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("07c9eca6-80d7-4e89-a631-93822f0c4213"), "NineTeen" },
                    { new Guid("0a053ee7-b5d1-44db-a98c-691c744bba83"), "TripleTwenty" },
                    { new Guid("379f3865-12b2-4038-8f78-b606481641de"), "DoubleNineTeen" },
                    { new Guid("4fa7134a-2a37-4cfa-b4ba-9a2b4db0363c"), "DoubleSeventeen" },
                    { new Guid("61abbd04-0ca6-475e-a313-e906c0e8db7e"), "BullOuter" },
                    { new Guid("62daf55e-e7cf-421c-9d1b-a21012deae72"), "Seventeen" },
                    { new Guid("6a984e5c-8eae-4165-93a4-c82b68b832e2"), "DoubleFifteen" },
                    { new Guid("7677032a-4405-4cd2-a6e6-58012b96b9cb"), "DoubleSixteen" },
                    { new Guid("78b9768b-739c-4493-9fe6-30727a06be4b"), "Twenty" },
                    { new Guid("88405f54-c6ed-47df-80b5-0e42457002ab"), "Eighteen" },
                    { new Guid("9104787b-24ce-44a7-9d74-88a524cc152b"), "Fifteen" },
                    { new Guid("b634742b-2bc4-42a2-9bb9-4be04da85795"), "TripleSeventeen" },
                    { new Guid("b65d0b0e-44d6-4ccb-85d4-baaa5e101686"), "TripleNineTeen" },
                    { new Guid("b84a8ee8-6e44-47ae-9410-1e1c2ce14213"), "DoubleEighteen" },
                    { new Guid("ce5ddebe-97db-4d51-b1de-755ff4269ac6"), "TripleFifteen" },
                    { new Guid("dd9fd715-c237-4d72-83d1-c9af05ffe852"), "DoubleTwenty" },
                    { new Guid("ddcd125b-380e-4d94-a322-0a2e0f160c1c"), "Sixteen" },
                    { new Guid("e58db293-618c-43c2-8692-c24d8b5fe106"), "TripleSixteen" },
                    { new Guid("f3a6b41f-7b67-4e66-bc2b-d70222130fb0"), "BullInner" },
                    { new Guid("f3adcd5f-49b6-4040-a8c1-2feada674475"), "TripleEigteen" }
                });

            migrationBuilder.InsertData(
                table: "MatchPlayer",
                columns: new[] { "MatchesId", "PlayersId" },
                values: new object[,]
                {
                    { new Guid("12502152-49db-4882-9a04-8df1a7b38969"), new Guid("0ea0c441-d555-49c9-af61-40337e1ff5a8") },
                    { new Guid("12502152-49db-4882-9a04-8df1a7b38969"), new Guid("ac468341-f749-4c7c-a8c6-8b5b3cf10bcb") },
                    { new Guid("13f862c0-f7b2-4d45-aa6d-d488a5f968ca"), new Guid("0ea0c441-d555-49c9-af61-40337e1ff5a8") },
                    { new Guid("13f862c0-f7b2-4d45-aa6d-d488a5f968ca"), new Guid("ac468341-f749-4c7c-a8c6-8b5b3cf10bcb") }
                });

            migrationBuilder.InsertData(
                table: "PlayerThrows",
                columns: new[] { "Id", "MatchId", "PlayerId", "ThrowId", "TimeStamp" },
                values: new object[,]
                {
                    { new Guid("03605ef5-fd30-4853-bee9-34901439d9e4"), new Guid("12502152-49db-4882-9a04-8df1a7b38969"), new Guid("ac468341-f749-4c7c-a8c6-8b5b3cf10bcb"), new Guid("dd9fd715-c237-4d72-83d1-c9af05ffe852"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2966f438-4e50-4019-9bcf-74e8c1012685"), new Guid("13f862c0-f7b2-4d45-aa6d-d488a5f968ca"), new Guid("ac468341-f749-4c7c-a8c6-8b5b3cf10bcb"), new Guid("7677032a-4405-4cd2-a6e6-58012b96b9cb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6c519dfa-2ad5-4bf8-a52a-d50690b17566"), new Guid("13f862c0-f7b2-4d45-aa6d-d488a5f968ca"), new Guid("0ea0c441-d555-49c9-af61-40337e1ff5a8"), new Guid("9104787b-24ce-44a7-9d74-88a524cc152b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("890c682b-1870-4ff1-bae2-16f0f449d794"), new Guid("12502152-49db-4882-9a04-8df1a7b38969"), new Guid("ac468341-f749-4c7c-a8c6-8b5b3cf10bcb"), new Guid("b634742b-2bc4-42a2-9bb9-4be04da85795"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8c2466f8-e014-4da8-9cd7-bcafda3cf550"), new Guid("12502152-49db-4882-9a04-8df1a7b38969"), new Guid("0ea0c441-d555-49c9-af61-40337e1ff5a8"), new Guid("7677032a-4405-4cd2-a6e6-58012b96b9cb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c6ddcf77-8b64-40a0-89e6-81b17674432a"), new Guid("12502152-49db-4882-9a04-8df1a7b38969"), new Guid("0ea0c441-d555-49c9-af61-40337e1ff5a8"), new Guid("62daf55e-e7cf-421c-9d1b-a21012deae72"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("def0a654-df39-4fbc-b97b-0a776ba37508"), new Guid("12502152-49db-4882-9a04-8df1a7b38969"), new Guid("ac468341-f749-4c7c-a8c6-8b5b3cf10bcb"), new Guid("f3a6b41f-7b67-4e66-bc2b-d70222130fb0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f5789b62-bf29-44ce-a64a-5eaac0879873"), new Guid("12502152-49db-4882-9a04-8df1a7b38969"), new Guid("0ea0c441-d555-49c9-af61-40337e1ff5a8"), new Guid("6a984e5c-8eae-4165-93a4-c82b68b832e2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
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
