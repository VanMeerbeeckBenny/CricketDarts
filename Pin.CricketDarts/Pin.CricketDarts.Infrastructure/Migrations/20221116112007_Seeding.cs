using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Pin.CricketDarts.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Seeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Player",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Player",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
