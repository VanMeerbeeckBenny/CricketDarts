using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Pin.CricketDarts.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddScoreToMatchPlayer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Matches",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MatchId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PlayerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Score = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MatchPlayer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MatchPlayer_Matches_MatchId",
                        column: x => x.MatchId,
                        principalTable: "Matches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MatchPlayer_Player_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Player",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlayerThrow",
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
                    table.PrimaryKey("PK_PlayerThrow", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlayerThrow_Matches_MatchId",
                        column: x => x.MatchId,
                        principalTable: "Matches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlayerThrow_Player_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Player",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlayerThrow_Throws_ScoreId",
                        column: x => x.ScoreId,
                        principalTable: "Throws",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "IsActiveGame", "TimeStamp" },
                values: new object[,]
                {
                    { new Guid("0a94fbbc-feb3-4eb2-97b2-893842b7b315"), false, new DateTime(2022, 12, 4, 1, 41, 23, 762, DateTimeKind.Local).AddTicks(2363) },
                    { new Guid("39dd33b6-cbed-48f0-81e9-656e3946a83f"), false, new DateTime(2022, 12, 4, 3, 41, 23, 762, DateTimeKind.Local).AddTicks(2402) }
                });

            migrationBuilder.InsertData(
                table: "Player",
                columns: new[] { "Id", "Firstname", "Lastname" },
                values: new object[,]
                {
                    { new Guid("03d99865-d39b-4026-9427-7e0106ee69ab"), "Benny", "Van Meerbeeck" },
                    { new Guid("6ab39473-4431-4f4d-983a-18440f682eea"), "Arlette", "Verheugen" }
                });

            migrationBuilder.InsertData(
                table: "Throws",
                columns: new[] { "Id", "OriginalScore", "Score" },
                values: new object[,]
                {
                    { new Guid("032c2567-f153-4397-bc3f-db70940fcec1"), 18, 36 },
                    { new Guid("0b40d326-e377-4e36-ae4a-75f33cf3fc1c"), 19, 38 },
                    { new Guid("136143e8-d590-45ab-8381-45a80e0b9271"), 17, 17 },
                    { new Guid("150e9194-aae0-47aa-9135-e2e5885945ce"), 25, 25 },
                    { new Guid("1726bfe8-2a28-4009-a0dc-86967d19f6af"), 15, 45 },
                    { new Guid("351bfd2b-86e2-42a0-b186-8b7d4e9e9e5e"), 25, 50 },
                    { new Guid("375c556c-f84c-4226-a6bc-9d65185874a8"), 15, 30 },
                    { new Guid("3eb1232d-fda4-4316-8dc1-3e7fee38671e"), 16, 16 },
                    { new Guid("4e730f72-b5d9-4491-a5bc-63c13772685e"), 16, 48 },
                    { new Guid("60fd4fd8-7985-4f13-98de-b25b32e345aa"), 17, 34 },
                    { new Guid("77aac1de-133e-4b2b-b892-40fe79d0a7d6"), 19, 19 },
                    { new Guid("a3ac94a5-bec7-4283-8216-f801ead93444"), 16, 32 },
                    { new Guid("a41d4809-1e62-40f3-ada6-34c112960837"), 15, 15 },
                    { new Guid("a4f417f0-163d-4726-9f8e-ab781f4e67c4"), 17, 51 },
                    { new Guid("b667f16c-e5cb-46b3-8557-283f97d9e696"), 20, 40 },
                    { new Guid("b850ea0a-46b5-4a87-8325-75a7351aff26"), 20, 20 },
                    { new Guid("bdb5a8a6-3c59-4dcf-82a0-7a54dff9da55"), 18, 18 },
                    { new Guid("d5dc453c-5121-4f88-bf33-fcbe5f0a1844"), 18, 54 },
                    { new Guid("dd562643-1671-4c6d-8a4e-e2e8b8c1bc0c"), 19, 57 },
                    { new Guid("ecaa5561-fc68-41a5-947c-348347faac7c"), 20, 60 }
                });

            migrationBuilder.InsertData(
                table: "PlayerThrow",
                columns: new[] { "Id", "MatchId", "PlayerId", "ScoreId", "TimeStamp" },
                values: new object[,]
                {
                    { new Guid("2b194257-4ffd-494b-aff4-3f909d54db26"), new Guid("39dd33b6-cbed-48f0-81e9-656e3946a83f"), new Guid("03d99865-d39b-4026-9427-7e0106ee69ab"), new Guid("a41d4809-1e62-40f3-ada6-34c112960837"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4fdfde8b-6e28-4730-a5d6-e7e62a6198d6"), new Guid("0a94fbbc-feb3-4eb2-97b2-893842b7b315"), new Guid("6ab39473-4431-4f4d-983a-18440f682eea"), new Guid("b667f16c-e5cb-46b3-8557-283f97d9e696"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("977686b2-344d-4f8b-9f43-1f42ba9701bd"), new Guid("39dd33b6-cbed-48f0-81e9-656e3946a83f"), new Guid("6ab39473-4431-4f4d-983a-18440f682eea"), new Guid("a3ac94a5-bec7-4283-8216-f801ead93444"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ac996e5c-91e8-4495-b780-3088bdf274fd"), new Guid("0a94fbbc-feb3-4eb2-97b2-893842b7b315"), new Guid("6ab39473-4431-4f4d-983a-18440f682eea"), new Guid("a4f417f0-163d-4726-9f8e-ab781f4e67c4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("bb324c7b-7d6c-45ac-9a67-478156c69835"), new Guid("0a94fbbc-feb3-4eb2-97b2-893842b7b315"), new Guid("03d99865-d39b-4026-9427-7e0106ee69ab"), new Guid("136143e8-d590-45ab-8381-45a80e0b9271"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d48228b5-f2e8-4892-8a91-c86362b2ddfd"), new Guid("0a94fbbc-feb3-4eb2-97b2-893842b7b315"), new Guid("03d99865-d39b-4026-9427-7e0106ee69ab"), new Guid("375c556c-f84c-4226-a6bc-9d65185874a8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f987877c-9597-47e6-8363-e23ee17137c3"), new Guid("0a94fbbc-feb3-4eb2-97b2-893842b7b315"), new Guid("03d99865-d39b-4026-9427-7e0106ee69ab"), new Guid("a3ac94a5-bec7-4283-8216-f801ead93444"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("fc3a7a44-2dcd-4b2c-b16f-29899b4ad02a"), new Guid("0a94fbbc-feb3-4eb2-97b2-893842b7b315"), new Guid("6ab39473-4431-4f4d-983a-18440f682eea"), new Guid("351bfd2b-86e2-42a0-b186-8b7d4e9e9e5e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_MatchPlayer_MatchId",
                table: "MatchPlayer",
                column: "MatchId");

            migrationBuilder.CreateIndex(
                name: "IX_MatchPlayer_PlayerId",
                table: "MatchPlayer",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerThrow_MatchId",
                table: "PlayerThrow",
                column: "MatchId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerThrow_PlayerId",
                table: "PlayerThrow",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerThrow_ScoreId",
                table: "PlayerThrow",
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
                name: "PlayerThrow");

            migrationBuilder.DropTable(
                name: "Matches");

            migrationBuilder.DropTable(
                name: "Player");

            migrationBuilder.DropTable(
                name: "Throws");
        }
    }
}
