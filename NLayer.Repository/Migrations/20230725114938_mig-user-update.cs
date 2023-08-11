using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NLayer.Repository.Migrations
{
    public partial class miguserupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Condition",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Condition",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 11, 36, 28, 509, DateTimeKind.Local).AddTicks(4828), new DateTime(2023, 7, 21, 11, 36, 28, 509, DateTimeKind.Local).AddTicks(4838) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 11, 36, 28, 509, DateTimeKind.Local).AddTicks(4839), new DateTime(2023, 7, 21, 11, 36, 28, 509, DateTimeKind.Local).AddTicks(4840) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 11, 36, 28, 509, DateTimeKind.Local).AddTicks(4841), new DateTime(2023, 7, 21, 11, 36, 28, 509, DateTimeKind.Local).AddTicks(4841) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 11, 36, 28, 509, DateTimeKind.Local).AddTicks(4842), new DateTime(2023, 7, 21, 11, 36, 28, 509, DateTimeKind.Local).AddTicks(4842) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 11, 36, 28, 509, DateTimeKind.Local).AddTicks(4843), new DateTime(2023, 7, 21, 11, 36, 28, 509, DateTimeKind.Local).AddTicks(4844) });

            migrationBuilder.UpdateData(
                table: "Days",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 11, 36, 28, 509, DateTimeKind.Local).AddTicks(4907), new DateTime(2023, 7, 21, 11, 36, 28, 509, DateTimeKind.Local).AddTicks(4908) });

            migrationBuilder.UpdateData(
                table: "Days",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 11, 36, 28, 509, DateTimeKind.Local).AddTicks(4909), new DateTime(2023, 7, 21, 11, 36, 28, 509, DateTimeKind.Local).AddTicks(4909) });

            migrationBuilder.UpdateData(
                table: "Days",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 11, 36, 28, 509, DateTimeKind.Local).AddTicks(4910), new DateTime(2023, 7, 21, 11, 36, 28, 509, DateTimeKind.Local).AddTicks(4910) });

            migrationBuilder.UpdateData(
                table: "Days",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 11, 36, 28, 509, DateTimeKind.Local).AddTicks(4911), new DateTime(2023, 7, 21, 11, 36, 28, 509, DateTimeKind.Local).AddTicks(4912) });

            migrationBuilder.UpdateData(
                table: "Days",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 11, 36, 28, 509, DateTimeKind.Local).AddTicks(4912), new DateTime(2023, 7, 21, 11, 36, 28, 509, DateTimeKind.Local).AddTicks(4913) });

            migrationBuilder.UpdateData(
                table: "Days",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 11, 36, 28, 509, DateTimeKind.Local).AddTicks(4913), new DateTime(2023, 7, 21, 11, 36, 28, 509, DateTimeKind.Local).AddTicks(4914) });

            migrationBuilder.UpdateData(
                table: "Days",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 11, 36, 28, 509, DateTimeKind.Local).AddTicks(4915), new DateTime(2023, 7, 21, 11, 36, 28, 509, DateTimeKind.Local).AddTicks(4915) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 11, 36, 28, 509, DateTimeKind.Local).AddTicks(5020), new DateTime(2023, 7, 21, 11, 36, 28, 509, DateTimeKind.Local).AddTicks(5020) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 11, 36, 28, 509, DateTimeKind.Local).AddTicks(5022), new DateTime(2023, 7, 21, 11, 36, 28, 509, DateTimeKind.Local).AddTicks(5023) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 11, 36, 28, 509, DateTimeKind.Local).AddTicks(5024), new DateTime(2023, 7, 21, 11, 36, 28, 509, DateTimeKind.Local).AddTicks(5024) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 11, 36, 28, 509, DateTimeKind.Local).AddTicks(5025), new DateTime(2023, 7, 21, 11, 36, 28, 509, DateTimeKind.Local).AddTicks(5026) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 11, 36, 28, 509, DateTimeKind.Local).AddTicks(5027), new DateTime(2023, 7, 21, 11, 36, 28, 509, DateTimeKind.Local).AddTicks(5027) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 11, 36, 28, 509, DateTimeKind.Local).AddTicks(5029), new DateTime(2023, 7, 21, 11, 36, 28, 509, DateTimeKind.Local).AddTicks(5029) });
        }
    }
}
