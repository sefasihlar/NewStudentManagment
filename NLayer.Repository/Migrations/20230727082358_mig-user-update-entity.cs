using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NLayer.Repository.Migrations
{
    public partial class miguserupdateentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 27, 11, 23, 58, 108, DateTimeKind.Local).AddTicks(2073), new DateTime(2023, 7, 27, 11, 23, 58, 108, DateTimeKind.Local).AddTicks(2083) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 27, 11, 23, 58, 108, DateTimeKind.Local).AddTicks(2084), new DateTime(2023, 7, 27, 11, 23, 58, 108, DateTimeKind.Local).AddTicks(2085) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 27, 11, 23, 58, 108, DateTimeKind.Local).AddTicks(2086), new DateTime(2023, 7, 27, 11, 23, 58, 108, DateTimeKind.Local).AddTicks(2086) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 27, 11, 23, 58, 108, DateTimeKind.Local).AddTicks(2087), new DateTime(2023, 7, 27, 11, 23, 58, 108, DateTimeKind.Local).AddTicks(2087) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 27, 11, 23, 58, 108, DateTimeKind.Local).AddTicks(2088), new DateTime(2023, 7, 27, 11, 23, 58, 108, DateTimeKind.Local).AddTicks(2088) });

            migrationBuilder.UpdateData(
                table: "Days",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 27, 11, 23, 58, 108, DateTimeKind.Local).AddTicks(2154), new DateTime(2023, 7, 27, 11, 23, 58, 108, DateTimeKind.Local).AddTicks(2155) });

            migrationBuilder.UpdateData(
                table: "Days",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 27, 11, 23, 58, 108, DateTimeKind.Local).AddTicks(2156), new DateTime(2023, 7, 27, 11, 23, 58, 108, DateTimeKind.Local).AddTicks(2156) });

            migrationBuilder.UpdateData(
                table: "Days",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 27, 11, 23, 58, 108, DateTimeKind.Local).AddTicks(2157), new DateTime(2023, 7, 27, 11, 23, 58, 108, DateTimeKind.Local).AddTicks(2157) });

            migrationBuilder.UpdateData(
                table: "Days",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 27, 11, 23, 58, 108, DateTimeKind.Local).AddTicks(2158), new DateTime(2023, 7, 27, 11, 23, 58, 108, DateTimeKind.Local).AddTicks(2158) });

            migrationBuilder.UpdateData(
                table: "Days",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 27, 11, 23, 58, 108, DateTimeKind.Local).AddTicks(2159), new DateTime(2023, 7, 27, 11, 23, 58, 108, DateTimeKind.Local).AddTicks(2159) });

            migrationBuilder.UpdateData(
                table: "Days",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 27, 11, 23, 58, 108, DateTimeKind.Local).AddTicks(2160), new DateTime(2023, 7, 27, 11, 23, 58, 108, DateTimeKind.Local).AddTicks(2160) });

            migrationBuilder.UpdateData(
                table: "Days",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 27, 11, 23, 58, 108, DateTimeKind.Local).AddTicks(2161), new DateTime(2023, 7, 27, 11, 23, 58, 108, DateTimeKind.Local).AddTicks(2161) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 27, 11, 23, 58, 108, DateTimeKind.Local).AddTicks(2229), new DateTime(2023, 7, 27, 11, 23, 58, 108, DateTimeKind.Local).AddTicks(2230) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 27, 11, 23, 58, 108, DateTimeKind.Local).AddTicks(2256), new DateTime(2023, 7, 27, 11, 23, 58, 108, DateTimeKind.Local).AddTicks(2256) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 27, 11, 23, 58, 108, DateTimeKind.Local).AddTicks(2258), new DateTime(2023, 7, 27, 11, 23, 58, 108, DateTimeKind.Local).AddTicks(2258) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 27, 11, 23, 58, 108, DateTimeKind.Local).AddTicks(2259), new DateTime(2023, 7, 27, 11, 23, 58, 108, DateTimeKind.Local).AddTicks(2260) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 27, 11, 23, 58, 108, DateTimeKind.Local).AddTicks(2261), new DateTime(2023, 7, 27, 11, 23, 58, 108, DateTimeKind.Local).AddTicks(2261) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 27, 11, 23, 58, 108, DateTimeKind.Local).AddTicks(2262), new DateTime(2023, 7, 27, 11, 23, 58, 108, DateTimeKind.Local).AddTicks(2262) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 25, 14, 49, 38, 225, DateTimeKind.Local).AddTicks(2512), new DateTime(2023, 7, 25, 14, 49, 38, 225, DateTimeKind.Local).AddTicks(2522) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 25, 14, 49, 38, 225, DateTimeKind.Local).AddTicks(2523), new DateTime(2023, 7, 25, 14, 49, 38, 225, DateTimeKind.Local).AddTicks(2524) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 25, 14, 49, 38, 225, DateTimeKind.Local).AddTicks(2525), new DateTime(2023, 7, 25, 14, 49, 38, 225, DateTimeKind.Local).AddTicks(2525) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 25, 14, 49, 38, 225, DateTimeKind.Local).AddTicks(2526), new DateTime(2023, 7, 25, 14, 49, 38, 225, DateTimeKind.Local).AddTicks(2526) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 25, 14, 49, 38, 225, DateTimeKind.Local).AddTicks(2527), new DateTime(2023, 7, 25, 14, 49, 38, 225, DateTimeKind.Local).AddTicks(2527) });

            migrationBuilder.UpdateData(
                table: "Days",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 25, 14, 49, 38, 225, DateTimeKind.Local).AddTicks(2594), new DateTime(2023, 7, 25, 14, 49, 38, 225, DateTimeKind.Local).AddTicks(2595) });

            migrationBuilder.UpdateData(
                table: "Days",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 25, 14, 49, 38, 225, DateTimeKind.Local).AddTicks(2596), new DateTime(2023, 7, 25, 14, 49, 38, 225, DateTimeKind.Local).AddTicks(2596) });

            migrationBuilder.UpdateData(
                table: "Days",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 25, 14, 49, 38, 225, DateTimeKind.Local).AddTicks(2597), new DateTime(2023, 7, 25, 14, 49, 38, 225, DateTimeKind.Local).AddTicks(2598) });

            migrationBuilder.UpdateData(
                table: "Days",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 25, 14, 49, 38, 225, DateTimeKind.Local).AddTicks(2598), new DateTime(2023, 7, 25, 14, 49, 38, 225, DateTimeKind.Local).AddTicks(2599) });

            migrationBuilder.UpdateData(
                table: "Days",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 25, 14, 49, 38, 225, DateTimeKind.Local).AddTicks(2599), new DateTime(2023, 7, 25, 14, 49, 38, 225, DateTimeKind.Local).AddTicks(2600) });

            migrationBuilder.UpdateData(
                table: "Days",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 25, 14, 49, 38, 225, DateTimeKind.Local).AddTicks(2601), new DateTime(2023, 7, 25, 14, 49, 38, 225, DateTimeKind.Local).AddTicks(2601) });

            migrationBuilder.UpdateData(
                table: "Days",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 25, 14, 49, 38, 225, DateTimeKind.Local).AddTicks(2602), new DateTime(2023, 7, 25, 14, 49, 38, 225, DateTimeKind.Local).AddTicks(2602) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 25, 14, 49, 38, 225, DateTimeKind.Local).AddTicks(2669), new DateTime(2023, 7, 25, 14, 49, 38, 225, DateTimeKind.Local).AddTicks(2669) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 25, 14, 49, 38, 225, DateTimeKind.Local).AddTicks(2671), new DateTime(2023, 7, 25, 14, 49, 38, 225, DateTimeKind.Local).AddTicks(2671) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 25, 14, 49, 38, 225, DateTimeKind.Local).AddTicks(2705), new DateTime(2023, 7, 25, 14, 49, 38, 225, DateTimeKind.Local).AddTicks(2706) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 25, 14, 49, 38, 225, DateTimeKind.Local).AddTicks(2707), new DateTime(2023, 7, 25, 14, 49, 38, 225, DateTimeKind.Local).AddTicks(2707) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 25, 14, 49, 38, 225, DateTimeKind.Local).AddTicks(2708), new DateTime(2023, 7, 25, 14, 49, 38, 225, DateTimeKind.Local).AddTicks(2709) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 25, 14, 49, 38, 225, DateTimeKind.Local).AddTicks(2710), new DateTime(2023, 7, 25, 14, 49, 38, 225, DateTimeKind.Local).AddTicks(2710) });
        }
    }
}
