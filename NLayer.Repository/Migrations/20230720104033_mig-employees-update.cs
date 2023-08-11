using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NLayer.Repository.Migrations
{
    public partial class migemployeesupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 20, 13, 40, 33, 373, DateTimeKind.Local).AddTicks(6738), new DateTime(2023, 7, 20, 13, 40, 33, 373, DateTimeKind.Local).AddTicks(6747) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 20, 13, 40, 33, 373, DateTimeKind.Local).AddTicks(6748), new DateTime(2023, 7, 20, 13, 40, 33, 373, DateTimeKind.Local).AddTicks(6748) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 20, 13, 40, 33, 373, DateTimeKind.Local).AddTicks(6749), new DateTime(2023, 7, 20, 13, 40, 33, 373, DateTimeKind.Local).AddTicks(6749) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 20, 13, 40, 33, 373, DateTimeKind.Local).AddTicks(6750), new DateTime(2023, 7, 20, 13, 40, 33, 373, DateTimeKind.Local).AddTicks(6751) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 20, 13, 40, 33, 373, DateTimeKind.Local).AddTicks(6751), new DateTime(2023, 7, 20, 13, 40, 33, 373, DateTimeKind.Local).AddTicks(6752) });

            migrationBuilder.UpdateData(
                table: "Days",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 20, 13, 40, 33, 373, DateTimeKind.Local).AddTicks(6814), new DateTime(2023, 7, 20, 13, 40, 33, 373, DateTimeKind.Local).AddTicks(6815) });

            migrationBuilder.UpdateData(
                table: "Days",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 20, 13, 40, 33, 373, DateTimeKind.Local).AddTicks(6815), new DateTime(2023, 7, 20, 13, 40, 33, 373, DateTimeKind.Local).AddTicks(6816) });

            migrationBuilder.UpdateData(
                table: "Days",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 20, 13, 40, 33, 373, DateTimeKind.Local).AddTicks(6817), new DateTime(2023, 7, 20, 13, 40, 33, 373, DateTimeKind.Local).AddTicks(6817) });

            migrationBuilder.UpdateData(
                table: "Days",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 20, 13, 40, 33, 373, DateTimeKind.Local).AddTicks(6818), new DateTime(2023, 7, 20, 13, 40, 33, 373, DateTimeKind.Local).AddTicks(6818) });

            migrationBuilder.UpdateData(
                table: "Days",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 20, 13, 40, 33, 373, DateTimeKind.Local).AddTicks(6819), new DateTime(2023, 7, 20, 13, 40, 33, 373, DateTimeKind.Local).AddTicks(6819) });

            migrationBuilder.UpdateData(
                table: "Days",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 20, 13, 40, 33, 373, DateTimeKind.Local).AddTicks(6820), new DateTime(2023, 7, 20, 13, 40, 33, 373, DateTimeKind.Local).AddTicks(6820) });

            migrationBuilder.UpdateData(
                table: "Days",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 20, 13, 40, 33, 373, DateTimeKind.Local).AddTicks(6821), new DateTime(2023, 7, 20, 13, 40, 33, 373, DateTimeKind.Local).AddTicks(6822) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 20, 13, 40, 33, 373, DateTimeKind.Local).AddTicks(6882), new DateTime(2023, 7, 20, 13, 40, 33, 373, DateTimeKind.Local).AddTicks(6883) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 20, 13, 40, 33, 373, DateTimeKind.Local).AddTicks(6885), new DateTime(2023, 7, 20, 13, 40, 33, 373, DateTimeKind.Local).AddTicks(6885) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 20, 13, 40, 33, 373, DateTimeKind.Local).AddTicks(6886), new DateTime(2023, 7, 20, 13, 40, 33, 373, DateTimeKind.Local).AddTicks(6887) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 20, 13, 40, 33, 373, DateTimeKind.Local).AddTicks(6888), new DateTime(2023, 7, 20, 13, 40, 33, 373, DateTimeKind.Local).AddTicks(6888) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 20, 13, 40, 33, 373, DateTimeKind.Local).AddTicks(6889), new DateTime(2023, 7, 20, 13, 40, 33, 373, DateTimeKind.Local).AddTicks(6890) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 20, 13, 40, 33, 373, DateTimeKind.Local).AddTicks(6891), new DateTime(2023, 7, 20, 13, 40, 33, 373, DateTimeKind.Local).AddTicks(6891) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Title",
                table: "Employees");

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 9, 45, 50, 401, DateTimeKind.Local).AddTicks(5114), new DateTime(2023, 7, 19, 9, 45, 50, 401, DateTimeKind.Local).AddTicks(5127) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 9, 45, 50, 401, DateTimeKind.Local).AddTicks(5128), new DateTime(2023, 7, 19, 9, 45, 50, 401, DateTimeKind.Local).AddTicks(5128) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 9, 45, 50, 401, DateTimeKind.Local).AddTicks(5151), new DateTime(2023, 7, 19, 9, 45, 50, 401, DateTimeKind.Local).AddTicks(5152) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 9, 45, 50, 401, DateTimeKind.Local).AddTicks(5152), new DateTime(2023, 7, 19, 9, 45, 50, 401, DateTimeKind.Local).AddTicks(5153) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 9, 45, 50, 401, DateTimeKind.Local).AddTicks(5154), new DateTime(2023, 7, 19, 9, 45, 50, 401, DateTimeKind.Local).AddTicks(5154) });

            migrationBuilder.UpdateData(
                table: "Days",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 9, 45, 50, 401, DateTimeKind.Local).AddTicks(5214), new DateTime(2023, 7, 19, 9, 45, 50, 401, DateTimeKind.Local).AddTicks(5214) });

            migrationBuilder.UpdateData(
                table: "Days",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 9, 45, 50, 401, DateTimeKind.Local).AddTicks(5215), new DateTime(2023, 7, 19, 9, 45, 50, 401, DateTimeKind.Local).AddTicks(5215) });

            migrationBuilder.UpdateData(
                table: "Days",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 9, 45, 50, 401, DateTimeKind.Local).AddTicks(5216), new DateTime(2023, 7, 19, 9, 45, 50, 401, DateTimeKind.Local).AddTicks(5216) });

            migrationBuilder.UpdateData(
                table: "Days",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 9, 45, 50, 401, DateTimeKind.Local).AddTicks(5217), new DateTime(2023, 7, 19, 9, 45, 50, 401, DateTimeKind.Local).AddTicks(5218) });

            migrationBuilder.UpdateData(
                table: "Days",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 9, 45, 50, 401, DateTimeKind.Local).AddTicks(5218), new DateTime(2023, 7, 19, 9, 45, 50, 401, DateTimeKind.Local).AddTicks(5219) });

            migrationBuilder.UpdateData(
                table: "Days",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 9, 45, 50, 401, DateTimeKind.Local).AddTicks(5219), new DateTime(2023, 7, 19, 9, 45, 50, 401, DateTimeKind.Local).AddTicks(5220) });

            migrationBuilder.UpdateData(
                table: "Days",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 9, 45, 50, 401, DateTimeKind.Local).AddTicks(5220), new DateTime(2023, 7, 19, 9, 45, 50, 401, DateTimeKind.Local).AddTicks(5221) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 9, 45, 50, 401, DateTimeKind.Local).AddTicks(5279), new DateTime(2023, 7, 19, 9, 45, 50, 401, DateTimeKind.Local).AddTicks(5280) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 9, 45, 50, 401, DateTimeKind.Local).AddTicks(5281), new DateTime(2023, 7, 19, 9, 45, 50, 401, DateTimeKind.Local).AddTicks(5282) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 9, 45, 50, 401, DateTimeKind.Local).AddTicks(5283), new DateTime(2023, 7, 19, 9, 45, 50, 401, DateTimeKind.Local).AddTicks(5283) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 9, 45, 50, 401, DateTimeKind.Local).AddTicks(5284), new DateTime(2023, 7, 19, 9, 45, 50, 401, DateTimeKind.Local).AddTicks(5285) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 9, 45, 50, 401, DateTimeKind.Local).AddTicks(5286), new DateTime(2023, 7, 19, 9, 45, 50, 401, DateTimeKind.Local).AddTicks(5286) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 9, 45, 50, 401, DateTimeKind.Local).AddTicks(5287), new DateTime(2023, 7, 19, 9, 45, 50, 401, DateTimeKind.Local).AddTicks(5288) });
        }
    }
}
