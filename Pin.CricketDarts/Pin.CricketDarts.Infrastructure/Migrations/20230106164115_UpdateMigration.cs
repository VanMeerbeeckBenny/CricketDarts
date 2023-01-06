using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Pin.CricketDarts.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PlayerThrow",
                keyColumn: "Id",
                keyValue: new Guid("2b194257-4ffd-494b-aff4-3f909d54db26"));

            migrationBuilder.DeleteData(
                table: "PlayerThrow",
                keyColumn: "Id",
                keyValue: new Guid("4fdfde8b-6e28-4730-a5d6-e7e62a6198d6"));

            migrationBuilder.DeleteData(
                table: "PlayerThrow",
                keyColumn: "Id",
                keyValue: new Guid("977686b2-344d-4f8b-9f43-1f42ba9701bd"));

            migrationBuilder.DeleteData(
                table: "PlayerThrow",
                keyColumn: "Id",
                keyValue: new Guid("ac996e5c-91e8-4495-b780-3088bdf274fd"));

            migrationBuilder.DeleteData(
                table: "PlayerThrow",
                keyColumn: "Id",
                keyValue: new Guid("bb324c7b-7d6c-45ac-9a67-478156c69835"));

            migrationBuilder.DeleteData(
                table: "PlayerThrow",
                keyColumn: "Id",
                keyValue: new Guid("d48228b5-f2e8-4892-8a91-c86362b2ddfd"));

            migrationBuilder.DeleteData(
                table: "PlayerThrow",
                keyColumn: "Id",
                keyValue: new Guid("f987877c-9597-47e6-8363-e23ee17137c3"));

            migrationBuilder.DeleteData(
                table: "PlayerThrow",
                keyColumn: "Id",
                keyValue: new Guid("fc3a7a44-2dcd-4b2c-b16f-29899b4ad02a"));

            migrationBuilder.DeleteData(
                table: "Throws",
                keyColumn: "Id",
                keyValue: new Guid("032c2567-f153-4397-bc3f-db70940fcec1"));

            migrationBuilder.DeleteData(
                table: "Throws",
                keyColumn: "Id",
                keyValue: new Guid("0b40d326-e377-4e36-ae4a-75f33cf3fc1c"));

            migrationBuilder.DeleteData(
                table: "Throws",
                keyColumn: "Id",
                keyValue: new Guid("150e9194-aae0-47aa-9135-e2e5885945ce"));

            migrationBuilder.DeleteData(
                table: "Throws",
                keyColumn: "Id",
                keyValue: new Guid("1726bfe8-2a28-4009-a0dc-86967d19f6af"));

            migrationBuilder.DeleteData(
                table: "Throws",
                keyColumn: "Id",
                keyValue: new Guid("3eb1232d-fda4-4316-8dc1-3e7fee38671e"));

            migrationBuilder.DeleteData(
                table: "Throws",
                keyColumn: "Id",
                keyValue: new Guid("4e730f72-b5d9-4491-a5bc-63c13772685e"));

            migrationBuilder.DeleteData(
                table: "Throws",
                keyColumn: "Id",
                keyValue: new Guid("60fd4fd8-7985-4f13-98de-b25b32e345aa"));

            migrationBuilder.DeleteData(
                table: "Throws",
                keyColumn: "Id",
                keyValue: new Guid("77aac1de-133e-4b2b-b892-40fe79d0a7d6"));

            migrationBuilder.DeleteData(
                table: "Throws",
                keyColumn: "Id",
                keyValue: new Guid("b850ea0a-46b5-4a87-8325-75a7351aff26"));

            migrationBuilder.DeleteData(
                table: "Throws",
                keyColumn: "Id",
                keyValue: new Guid("bdb5a8a6-3c59-4dcf-82a0-7a54dff9da55"));

            migrationBuilder.DeleteData(
                table: "Throws",
                keyColumn: "Id",
                keyValue: new Guid("d5dc453c-5121-4f88-bf33-fcbe5f0a1844"));

            migrationBuilder.DeleteData(
                table: "Throws",
                keyColumn: "Id",
                keyValue: new Guid("dd562643-1671-4c6d-8a4e-e2e8b8c1bc0c"));

            migrationBuilder.DeleteData(
                table: "Throws",
                keyColumn: "Id",
                keyValue: new Guid("ecaa5561-fc68-41a5-947c-348347faac7c"));

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: new Guid("0a94fbbc-feb3-4eb2-97b2-893842b7b315"));

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: new Guid("39dd33b6-cbed-48f0-81e9-656e3946a83f"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: new Guid("03d99865-d39b-4026-9427-7e0106ee69ab"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: new Guid("6ab39473-4431-4f4d-983a-18440f682eea"));

            migrationBuilder.DeleteData(
                table: "Throws",
                keyColumn: "Id",
                keyValue: new Guid("136143e8-d590-45ab-8381-45a80e0b9271"));

            migrationBuilder.DeleteData(
                table: "Throws",
                keyColumn: "Id",
                keyValue: new Guid("351bfd2b-86e2-42a0-b186-8b7d4e9e9e5e"));

            migrationBuilder.DeleteData(
                table: "Throws",
                keyColumn: "Id",
                keyValue: new Guid("375c556c-f84c-4226-a6bc-9d65185874a8"));

            migrationBuilder.DeleteData(
                table: "Throws",
                keyColumn: "Id",
                keyValue: new Guid("a3ac94a5-bec7-4283-8216-f801ead93444"));

            migrationBuilder.DeleteData(
                table: "Throws",
                keyColumn: "Id",
                keyValue: new Guid("a41d4809-1e62-40f3-ada6-34c112960837"));

            migrationBuilder.DeleteData(
                table: "Throws",
                keyColumn: "Id",
                keyValue: new Guid("a4f417f0-163d-4726-9f8e-ab781f4e67c4"));

            migrationBuilder.DeleteData(
                table: "Throws",
                keyColumn: "Id",
                keyValue: new Guid("b667f16c-e5cb-46b3-8557-283f97d9e696"));

            migrationBuilder.AddColumn<bool>(
                name: "IsWin",
                table: "MatchPlayer",
                type: "bit",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Player",
                columns: new[] { "Id", "Firstname", "Lastname" },
                values: new object[,]
                {
                    { new Guid("70d4dd9c-ca1e-4cee-b97e-64e6217cee38"), "Benny", "Van Meerbeeck" },
                    { new Guid("c7e4fd61-c835-4c2e-a7c2-85c8018dda4a"), "Arlette", "Verheugen" }
                });

            migrationBuilder.InsertData(
                table: "Throws",
                columns: new[] { "Id", "OriginalScore", "Score" },
                values: new object[,]
                {
                    { new Guid("0f7fe713-1b4f-42f2-8a47-53b971c33992"), 20, 60 },
                    { new Guid("2062304c-094f-4324-ab88-43dc2dc52be0"), 17, 17 },
                    { new Guid("28b1e44e-4bff-469d-8d4e-1be32dfb8f79"), 19, 57 },
                    { new Guid("2a51b458-a345-4685-a3dc-ac5b1b6396f3"), 17, 34 },
                    { new Guid("72ea3e52-d2e7-4d25-995c-569bb88b42bc"), 20, 20 },
                    { new Guid("7c593215-7ef7-468d-94b8-60961c41a55c"), 17, 51 },
                    { new Guid("88c2ed10-27bf-498d-80cc-cca69e7e3ebb"), 16, 48 },
                    { new Guid("9ae38da2-30f3-4eb4-997f-65be8bdbe46a"), 15, 15 },
                    { new Guid("a44178a4-3cc1-4104-b574-c9f76aa1bdcc"), 15, 45 },
                    { new Guid("a512e36d-de88-4fa7-9d5e-1b3cb5cc1f7d"), 18, 18 },
                    { new Guid("aa1eb109-1137-42a0-8ce0-a815641dca5b"), 18, 36 },
                    { new Guid("b0be15a8-aa36-4772-915e-b44d8a36798c"), 15, 30 },
                    { new Guid("d363198a-7276-416e-905c-6f7b538fc751"), 25, 25 },
                    { new Guid("d8e50934-53ed-4993-a5a4-09897c82fb08"), 16, 32 },
                    { new Guid("de312ef5-68d6-4c51-9760-4429e12ff544"), 19, 19 },
                    { new Guid("df242db9-cebf-4129-bc4b-35f2bc2d59d1"), 25, 50 },
                    { new Guid("e722e6e3-b8c6-4845-ac39-789cce297226"), 19, 38 },
                    { new Guid("e7ee8998-a556-4273-bb85-4bfd53d09c6f"), 18, 54 },
                    { new Guid("ee2d37c9-20b5-46c0-8239-355ba15dd8d4"), 20, 40 },
                    { new Guid("fcdf2e3f-f862-44b7-aaba-c445567a832d"), 16, 16 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: new Guid("70d4dd9c-ca1e-4cee-b97e-64e6217cee38"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: new Guid("c7e4fd61-c835-4c2e-a7c2-85c8018dda4a"));

            migrationBuilder.DeleteData(
                table: "Throws",
                keyColumn: "Id",
                keyValue: new Guid("0f7fe713-1b4f-42f2-8a47-53b971c33992"));

            migrationBuilder.DeleteData(
                table: "Throws",
                keyColumn: "Id",
                keyValue: new Guid("2062304c-094f-4324-ab88-43dc2dc52be0"));

            migrationBuilder.DeleteData(
                table: "Throws",
                keyColumn: "Id",
                keyValue: new Guid("28b1e44e-4bff-469d-8d4e-1be32dfb8f79"));

            migrationBuilder.DeleteData(
                table: "Throws",
                keyColumn: "Id",
                keyValue: new Guid("2a51b458-a345-4685-a3dc-ac5b1b6396f3"));

            migrationBuilder.DeleteData(
                table: "Throws",
                keyColumn: "Id",
                keyValue: new Guid("72ea3e52-d2e7-4d25-995c-569bb88b42bc"));

            migrationBuilder.DeleteData(
                table: "Throws",
                keyColumn: "Id",
                keyValue: new Guid("7c593215-7ef7-468d-94b8-60961c41a55c"));

            migrationBuilder.DeleteData(
                table: "Throws",
                keyColumn: "Id",
                keyValue: new Guid("88c2ed10-27bf-498d-80cc-cca69e7e3ebb"));

            migrationBuilder.DeleteData(
                table: "Throws",
                keyColumn: "Id",
                keyValue: new Guid("9ae38da2-30f3-4eb4-997f-65be8bdbe46a"));

            migrationBuilder.DeleteData(
                table: "Throws",
                keyColumn: "Id",
                keyValue: new Guid("a44178a4-3cc1-4104-b574-c9f76aa1bdcc"));

            migrationBuilder.DeleteData(
                table: "Throws",
                keyColumn: "Id",
                keyValue: new Guid("a512e36d-de88-4fa7-9d5e-1b3cb5cc1f7d"));

            migrationBuilder.DeleteData(
                table: "Throws",
                keyColumn: "Id",
                keyValue: new Guid("aa1eb109-1137-42a0-8ce0-a815641dca5b"));

            migrationBuilder.DeleteData(
                table: "Throws",
                keyColumn: "Id",
                keyValue: new Guid("b0be15a8-aa36-4772-915e-b44d8a36798c"));

            migrationBuilder.DeleteData(
                table: "Throws",
                keyColumn: "Id",
                keyValue: new Guid("d363198a-7276-416e-905c-6f7b538fc751"));

            migrationBuilder.DeleteData(
                table: "Throws",
                keyColumn: "Id",
                keyValue: new Guid("d8e50934-53ed-4993-a5a4-09897c82fb08"));

            migrationBuilder.DeleteData(
                table: "Throws",
                keyColumn: "Id",
                keyValue: new Guid("de312ef5-68d6-4c51-9760-4429e12ff544"));

            migrationBuilder.DeleteData(
                table: "Throws",
                keyColumn: "Id",
                keyValue: new Guid("df242db9-cebf-4129-bc4b-35f2bc2d59d1"));

            migrationBuilder.DeleteData(
                table: "Throws",
                keyColumn: "Id",
                keyValue: new Guid("e722e6e3-b8c6-4845-ac39-789cce297226"));

            migrationBuilder.DeleteData(
                table: "Throws",
                keyColumn: "Id",
                keyValue: new Guid("e7ee8998-a556-4273-bb85-4bfd53d09c6f"));

            migrationBuilder.DeleteData(
                table: "Throws",
                keyColumn: "Id",
                keyValue: new Guid("ee2d37c9-20b5-46c0-8239-355ba15dd8d4"));

            migrationBuilder.DeleteData(
                table: "Throws",
                keyColumn: "Id",
                keyValue: new Guid("fcdf2e3f-f862-44b7-aaba-c445567a832d"));

            migrationBuilder.DropColumn(
                name: "IsWin",
                table: "MatchPlayer");

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
        }
    }
}
