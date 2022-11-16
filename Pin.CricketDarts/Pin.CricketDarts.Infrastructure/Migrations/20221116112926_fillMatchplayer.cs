using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Pin.CricketDarts.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class fillMatchplayer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PlayerThrows",
                keyColumn: "Id",
                keyValue: new Guid("1ab92f21-348a-4537-9c8f-34aa7bcc3584"));

            migrationBuilder.DeleteData(
                table: "PlayerThrows",
                keyColumn: "Id",
                keyValue: new Guid("71c4107d-bb73-4e69-b7f6-7ee3ead4208c"));

            migrationBuilder.DeleteData(
                table: "PlayerThrows",
                keyColumn: "Id",
                keyValue: new Guid("9e8c0c4d-5cd6-4a05-aa8b-f396e46d0abf"));

            migrationBuilder.DeleteData(
                table: "PlayerThrows",
                keyColumn: "Id",
                keyValue: new Guid("b6a0a05d-ad89-4417-905d-d8dc3ace8197"));

            migrationBuilder.DeleteData(
                table: "PlayerThrows",
                keyColumn: "Id",
                keyValue: new Guid("c22422cc-98f3-4463-bd7c-163209636181"));

            migrationBuilder.DeleteData(
                table: "PlayerThrows",
                keyColumn: "Id",
                keyValue: new Guid("c74f8b59-5abe-466a-a41b-544b74db7087"));

            migrationBuilder.DeleteData(
                table: "PlayerThrows",
                keyColumn: "Id",
                keyValue: new Guid("cdb63195-e4ea-44b9-833b-87759d01ecdc"));

            migrationBuilder.DeleteData(
                table: "PlayerThrows",
                keyColumn: "Id",
                keyValue: new Guid("ec4749bf-d8dc-4ab1-9405-5980c2d2e5e9"));

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: new Guid("ad6626b8-4720-443a-8800-62087fe9a7a2"));

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: new Guid("d9e3adf9-3432-4362-a1b2-761d4f85cbb6"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: new Guid("6fef54ec-e3b1-4c48-95e3-db667b4c4a42"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: new Guid("b56310f0-76eb-4adb-8513-d9effa9d9cfa"));

            migrationBuilder.DeleteData(
                table: "Throws",
                keyColumn: "Id",
                keyValue: new Guid("02baa8dd-1b97-4991-a861-0620bd15b09b"));

            migrationBuilder.DeleteData(
                table: "Throws",
                keyColumn: "Id",
                keyValue: new Guid("1c5aff2a-990a-4727-9e17-fc01c537f16f"));

            migrationBuilder.DeleteData(
                table: "Throws",
                keyColumn: "Id",
                keyValue: new Guid("3c11ce76-b3ca-44f4-bdea-cacf04bc9e7d"));

            migrationBuilder.DeleteData(
                table: "Throws",
                keyColumn: "Id",
                keyValue: new Guid("63d9e6da-d4c6-43c2-ade9-30d5f52bfeba"));

            migrationBuilder.DeleteData(
                table: "Throws",
                keyColumn: "Id",
                keyValue: new Guid("97cececf-3ed2-496c-8706-2df4a3b1c97e"));

            migrationBuilder.DeleteData(
                table: "Throws",
                keyColumn: "Id",
                keyValue: new Guid("9e32ca82-ee5b-41d7-8329-60f858c93138"));

            migrationBuilder.DeleteData(
                table: "Throws",
                keyColumn: "Id",
                keyValue: new Guid("c08780c1-5e2e-4a76-9457-7a1f40955474"));

            migrationBuilder.DeleteData(
                table: "Throws",
                keyColumn: "Id",
                keyValue: new Guid("c254f168-90c6-44a5-9271-52bdfa1332af"));

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "IsActiveGame", "PlayerOneScore", "PlayerTwoScore", "TimeStamp" },
                values: new object[,]
                {
                    { new Guid("6b0b13c6-eca1-41b3-8eaa-a234625ac027"), false, 0, 0, new DateTime(2022, 11, 16, 14, 29, 26, 542, DateTimeKind.Local).AddTicks(1811) },
                    { new Guid("80efdf1a-5163-4220-bd14-30005e56cf3c"), false, 0, 0, new DateTime(2022, 11, 16, 12, 29, 26, 542, DateTimeKind.Local).AddTicks(1774) }
                });

            migrationBuilder.InsertData(
                table: "Player",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("7cec66aa-ab38-48ce-835a-120eb2ff1440"), "Benny" },
                    { new Guid("825ea639-8bac-43d9-bb65-b1c5f35d95ad"), "Yoran" }
                });

            migrationBuilder.InsertData(
                table: "Throws",
                columns: new[] { "Id", "Bull", "Eighteen", "Fifteen", "Nineteen", "Seventeen", "Sixteen", "Twenty" },
                values: new object[,]
                {
                    { new Guid("14561aa4-39e5-4fce-b98b-0b80463fd269"), (byte)2, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)2 },
                    { new Guid("42383aff-09db-4d1a-b239-09eda0a13b92"), (byte)0, (byte)0, (byte)2, (byte)0, (byte)0, (byte)0, (byte)3 },
                    { new Guid("49ecaac4-bb60-4cee-9825-4c395d4cb32d"), (byte)0, (byte)1, (byte)0, (byte)2, (byte)0, (byte)0, (byte)0 },
                    { new Guid("4fb886c3-d444-4592-9a0a-fb3f83b667ac"), (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)3, (byte)2 },
                    { new Guid("62f79254-7b84-4cc8-b51f-e01feb260701"), (byte)0, (byte)2, (byte)3, (byte)0, (byte)0, (byte)0, (byte)0 },
                    { new Guid("952f3290-e579-48f1-a579-6a6fd2677fdc"), (byte)0, (byte)1, (byte)0, (byte)2, (byte)0, (byte)0, (byte)0 },
                    { new Guid("a71589d6-40b5-44f9-bc61-803ac403bab4"), (byte)0, (byte)0, (byte)3, (byte)0, (byte)0, (byte)0, (byte)2 },
                    { new Guid("c22f55ba-0bd3-4c02-8999-e420652a377f"), (byte)0, (byte)0, (byte)0, (byte)0, (byte)3, (byte)0, (byte)2 }
                });

            migrationBuilder.InsertData(
                table: "MatchPlayer",
                columns: new[] { "MatchesId", "PlayersId" },
                values: new object[,]
                {
                    { new Guid("6b0b13c6-eca1-41b3-8eaa-a234625ac027"), new Guid("7cec66aa-ab38-48ce-835a-120eb2ff1440") },
                    { new Guid("6b0b13c6-eca1-41b3-8eaa-a234625ac027"), new Guid("825ea639-8bac-43d9-bb65-b1c5f35d95ad") },
                    { new Guid("80efdf1a-5163-4220-bd14-30005e56cf3c"), new Guid("7cec66aa-ab38-48ce-835a-120eb2ff1440") },
                    { new Guid("80efdf1a-5163-4220-bd14-30005e56cf3c"), new Guid("825ea639-8bac-43d9-bb65-b1c5f35d95ad") }
                });

            migrationBuilder.InsertData(
                table: "PlayerThrows",
                columns: new[] { "Id", "MatchId", "PlayerId", "ThrowId", "TimeStamp" },
                values: new object[,]
                {
                    { new Guid("37d8ce85-6442-498b-bcc4-1df85e41ac80"), new Guid("6b0b13c6-eca1-41b3-8eaa-a234625ac027"), new Guid("825ea639-8bac-43d9-bb65-b1c5f35d95ad"), new Guid("14561aa4-39e5-4fce-b98b-0b80463fd269"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4fdb0f0a-338c-46a6-bb7c-82ff3390c0da"), new Guid("80efdf1a-5163-4220-bd14-30005e56cf3c"), new Guid("7cec66aa-ab38-48ce-835a-120eb2ff1440"), new Guid("42383aff-09db-4d1a-b239-09eda0a13b92"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("59eea219-e244-4397-b612-82568fb3d34d"), new Guid("80efdf1a-5163-4220-bd14-30005e56cf3c"), new Guid("825ea639-8bac-43d9-bb65-b1c5f35d95ad"), new Guid("62f79254-7b84-4cc8-b51f-e01feb260701"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7d8c748d-0082-4a21-948d-142676475489"), new Guid("80efdf1a-5163-4220-bd14-30005e56cf3c"), new Guid("825ea639-8bac-43d9-bb65-b1c5f35d95ad"), new Guid("49ecaac4-bb60-4cee-9825-4c395d4cb32d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8ff42dbd-8ff9-41a1-8b92-25074414d042"), new Guid("6b0b13c6-eca1-41b3-8eaa-a234625ac027"), new Guid("7cec66aa-ab38-48ce-835a-120eb2ff1440"), new Guid("c22f55ba-0bd3-4c02-8999-e420652a377f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("972438f6-1d38-40e2-a137-cf5f59ddfc2d"), new Guid("80efdf1a-5163-4220-bd14-30005e56cf3c"), new Guid("825ea639-8bac-43d9-bb65-b1c5f35d95ad"), new Guid("a71589d6-40b5-44f9-bc61-803ac403bab4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("aedc8c4c-fefa-48ee-a983-4e28fdf5bf5d"), new Guid("80efdf1a-5163-4220-bd14-30005e56cf3c"), new Guid("7cec66aa-ab38-48ce-835a-120eb2ff1440"), new Guid("952f3290-e579-48f1-a579-6a6fd2677fdc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("dd3b1e81-ecfd-4b59-a988-c17d65bb05f6"), new Guid("80efdf1a-5163-4220-bd14-30005e56cf3c"), new Guid("7cec66aa-ab38-48ce-835a-120eb2ff1440"), new Guid("4fb886c3-d444-4592-9a0a-fb3f83b667ac"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MatchPlayer",
                keyColumns: new[] { "MatchesId", "PlayersId" },
                keyValues: new object[] { new Guid("6b0b13c6-eca1-41b3-8eaa-a234625ac027"), new Guid("7cec66aa-ab38-48ce-835a-120eb2ff1440") });

            migrationBuilder.DeleteData(
                table: "MatchPlayer",
                keyColumns: new[] { "MatchesId", "PlayersId" },
                keyValues: new object[] { new Guid("6b0b13c6-eca1-41b3-8eaa-a234625ac027"), new Guid("825ea639-8bac-43d9-bb65-b1c5f35d95ad") });

            migrationBuilder.DeleteData(
                table: "MatchPlayer",
                keyColumns: new[] { "MatchesId", "PlayersId" },
                keyValues: new object[] { new Guid("80efdf1a-5163-4220-bd14-30005e56cf3c"), new Guid("7cec66aa-ab38-48ce-835a-120eb2ff1440") });

            migrationBuilder.DeleteData(
                table: "MatchPlayer",
                keyColumns: new[] { "MatchesId", "PlayersId" },
                keyValues: new object[] { new Guid("80efdf1a-5163-4220-bd14-30005e56cf3c"), new Guid("825ea639-8bac-43d9-bb65-b1c5f35d95ad") });

            migrationBuilder.DeleteData(
                table: "PlayerThrows",
                keyColumn: "Id",
                keyValue: new Guid("37d8ce85-6442-498b-bcc4-1df85e41ac80"));

            migrationBuilder.DeleteData(
                table: "PlayerThrows",
                keyColumn: "Id",
                keyValue: new Guid("4fdb0f0a-338c-46a6-bb7c-82ff3390c0da"));

            migrationBuilder.DeleteData(
                table: "PlayerThrows",
                keyColumn: "Id",
                keyValue: new Guid("59eea219-e244-4397-b612-82568fb3d34d"));

            migrationBuilder.DeleteData(
                table: "PlayerThrows",
                keyColumn: "Id",
                keyValue: new Guid("7d8c748d-0082-4a21-948d-142676475489"));

            migrationBuilder.DeleteData(
                table: "PlayerThrows",
                keyColumn: "Id",
                keyValue: new Guid("8ff42dbd-8ff9-41a1-8b92-25074414d042"));

            migrationBuilder.DeleteData(
                table: "PlayerThrows",
                keyColumn: "Id",
                keyValue: new Guid("972438f6-1d38-40e2-a137-cf5f59ddfc2d"));

            migrationBuilder.DeleteData(
                table: "PlayerThrows",
                keyColumn: "Id",
                keyValue: new Guid("aedc8c4c-fefa-48ee-a983-4e28fdf5bf5d"));

            migrationBuilder.DeleteData(
                table: "PlayerThrows",
                keyColumn: "Id",
                keyValue: new Guid("dd3b1e81-ecfd-4b59-a988-c17d65bb05f6"));

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: new Guid("6b0b13c6-eca1-41b3-8eaa-a234625ac027"));

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: new Guid("80efdf1a-5163-4220-bd14-30005e56cf3c"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: new Guid("7cec66aa-ab38-48ce-835a-120eb2ff1440"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: new Guid("825ea639-8bac-43d9-bb65-b1c5f35d95ad"));

            migrationBuilder.DeleteData(
                table: "Throws",
                keyColumn: "Id",
                keyValue: new Guid("14561aa4-39e5-4fce-b98b-0b80463fd269"));

            migrationBuilder.DeleteData(
                table: "Throws",
                keyColumn: "Id",
                keyValue: new Guid("42383aff-09db-4d1a-b239-09eda0a13b92"));

            migrationBuilder.DeleteData(
                table: "Throws",
                keyColumn: "Id",
                keyValue: new Guid("49ecaac4-bb60-4cee-9825-4c395d4cb32d"));

            migrationBuilder.DeleteData(
                table: "Throws",
                keyColumn: "Id",
                keyValue: new Guid("4fb886c3-d444-4592-9a0a-fb3f83b667ac"));

            migrationBuilder.DeleteData(
                table: "Throws",
                keyColumn: "Id",
                keyValue: new Guid("62f79254-7b84-4cc8-b51f-e01feb260701"));

            migrationBuilder.DeleteData(
                table: "Throws",
                keyColumn: "Id",
                keyValue: new Guid("952f3290-e579-48f1-a579-6a6fd2677fdc"));

            migrationBuilder.DeleteData(
                table: "Throws",
                keyColumn: "Id",
                keyValue: new Guid("a71589d6-40b5-44f9-bc61-803ac403bab4"));

            migrationBuilder.DeleteData(
                table: "Throws",
                keyColumn: "Id",
                keyValue: new Guid("c22f55ba-0bd3-4c02-8999-e420652a377f"));

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "IsActiveGame", "PlayerOneScore", "PlayerTwoScore", "TimeStamp" },
                values: new object[,]
                {
                    { new Guid("ad6626b8-4720-443a-8800-62087fe9a7a2"), false, 0, 0, new DateTime(2022, 11, 16, 14, 20, 7, 376, DateTimeKind.Local).AddTicks(164) },
                    { new Guid("d9e3adf9-3432-4362-a1b2-761d4f85cbb6"), false, 0, 0, new DateTime(2022, 11, 16, 12, 20, 7, 376, DateTimeKind.Local).AddTicks(128) }
                });

            migrationBuilder.InsertData(
                table: "Player",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("6fef54ec-e3b1-4c48-95e3-db667b4c4a42"), "Benny" },
                    { new Guid("b56310f0-76eb-4adb-8513-d9effa9d9cfa"), "Yoran" }
                });

            migrationBuilder.InsertData(
                table: "Throws",
                columns: new[] { "Id", "Bull", "Eighteen", "Fifteen", "Nineteen", "Seventeen", "Sixteen", "Twenty" },
                values: new object[,]
                {
                    { new Guid("02baa8dd-1b97-4991-a861-0620bd15b09b"), (byte)0, (byte)1, (byte)0, (byte)2, (byte)0, (byte)0, (byte)0 },
                    { new Guid("1c5aff2a-990a-4727-9e17-fc01c537f16f"), (byte)0, (byte)0, (byte)2, (byte)0, (byte)0, (byte)0, (byte)3 },
                    { new Guid("3c11ce76-b3ca-44f4-bdea-cacf04bc9e7d"), (byte)0, (byte)2, (byte)3, (byte)0, (byte)0, (byte)0, (byte)0 },
                    { new Guid("63d9e6da-d4c6-43c2-ade9-30d5f52bfeba"), (byte)0, (byte)0, (byte)3, (byte)0, (byte)0, (byte)0, (byte)2 },
                    { new Guid("97cececf-3ed2-496c-8706-2df4a3b1c97e"), (byte)0, (byte)1, (byte)0, (byte)2, (byte)0, (byte)0, (byte)0 },
                    { new Guid("9e32ca82-ee5b-41d7-8329-60f858c93138"), (byte)0, (byte)0, (byte)0, (byte)0, (byte)3, (byte)0, (byte)2 },
                    { new Guid("c08780c1-5e2e-4a76-9457-7a1f40955474"), (byte)2, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)2 },
                    { new Guid("c254f168-90c6-44a5-9271-52bdfa1332af"), (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)3, (byte)2 }
                });

            migrationBuilder.InsertData(
                table: "PlayerThrows",
                columns: new[] { "Id", "MatchId", "PlayerId", "ThrowId", "TimeStamp" },
                values: new object[,]
                {
                    { new Guid("1ab92f21-348a-4537-9c8f-34aa7bcc3584"), new Guid("d9e3adf9-3432-4362-a1b2-761d4f85cbb6"), new Guid("6fef54ec-e3b1-4c48-95e3-db667b4c4a42"), new Guid("1c5aff2a-990a-4727-9e17-fc01c537f16f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("71c4107d-bb73-4e69-b7f6-7ee3ead4208c"), new Guid("d9e3adf9-3432-4362-a1b2-761d4f85cbb6"), new Guid("b56310f0-76eb-4adb-8513-d9effa9d9cfa"), new Guid("3c11ce76-b3ca-44f4-bdea-cacf04bc9e7d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9e8c0c4d-5cd6-4a05-aa8b-f396e46d0abf"), new Guid("d9e3adf9-3432-4362-a1b2-761d4f85cbb6"), new Guid("6fef54ec-e3b1-4c48-95e3-db667b4c4a42"), new Guid("c254f168-90c6-44a5-9271-52bdfa1332af"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b6a0a05d-ad89-4417-905d-d8dc3ace8197"), new Guid("d9e3adf9-3432-4362-a1b2-761d4f85cbb6"), new Guid("6fef54ec-e3b1-4c48-95e3-db667b4c4a42"), new Guid("97cececf-3ed2-496c-8706-2df4a3b1c97e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c22422cc-98f3-4463-bd7c-163209636181"), new Guid("ad6626b8-4720-443a-8800-62087fe9a7a2"), new Guid("b56310f0-76eb-4adb-8513-d9effa9d9cfa"), new Guid("c08780c1-5e2e-4a76-9457-7a1f40955474"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c74f8b59-5abe-466a-a41b-544b74db7087"), new Guid("d9e3adf9-3432-4362-a1b2-761d4f85cbb6"), new Guid("b56310f0-76eb-4adb-8513-d9effa9d9cfa"), new Guid("02baa8dd-1b97-4991-a861-0620bd15b09b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("cdb63195-e4ea-44b9-833b-87759d01ecdc"), new Guid("d9e3adf9-3432-4362-a1b2-761d4f85cbb6"), new Guid("b56310f0-76eb-4adb-8513-d9effa9d9cfa"), new Guid("63d9e6da-d4c6-43c2-ade9-30d5f52bfeba"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ec4749bf-d8dc-4ab1-9405-5980c2d2e5e9"), new Guid("ad6626b8-4720-443a-8800-62087fe9a7a2"), new Guid("6fef54ec-e3b1-4c48-95e3-db667b4c4a42"), new Guid("9e32ca82-ee5b-41d7-8329-60f858c93138"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }
    }
}
