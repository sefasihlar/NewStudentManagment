using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NLayer.Repository.Migrations
{
    public partial class migProjects : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProjectManager",
                table: "Projects",
                type: "nvarchar(max)",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProjectManager",
                table: "Projects");

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 11, 32, 58, 742, DateTimeKind.Local).AddTicks(6201), new DateTime(2023, 7, 21, 11, 32, 58, 742, DateTimeKind.Local).AddTicks(6211) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 11, 32, 58, 742, DateTimeKind.Local).AddTicks(6212), new DateTime(2023, 7, 21, 11, 32, 58, 742, DateTimeKind.Local).AddTicks(6213) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 11, 32, 58, 742, DateTimeKind.Local).AddTicks(6237), new DateTime(2023, 7, 21, 11, 32, 58, 742, DateTimeKind.Local).AddTicks(6237) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 11, 32, 58, 742, DateTimeKind.Local).AddTicks(6238), new DateTime(2023, 7, 21, 11, 32, 58, 742, DateTimeKind.Local).AddTicks(6238) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 11, 32, 58, 742, DateTimeKind.Local).AddTicks(6239), new DateTime(2023, 7, 21, 11, 32, 58, 742, DateTimeKind.Local).AddTicks(6239) });

            migrationBuilder.UpdateData(
                table: "Days",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 11, 32, 58, 742, DateTimeKind.Local).AddTicks(6304), new DateTime(2023, 7, 21, 11, 32, 58, 742, DateTimeKind.Local).AddTicks(6305) });

            migrationBuilder.UpdateData(
                table: "Days",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 11, 32, 58, 742, DateTimeKind.Local).AddTicks(6306), new DateTime(2023, 7, 21, 11, 32, 58, 742, DateTimeKind.Local).AddTicks(6306) });

            migrationBuilder.UpdateData(
                table: "Days",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 11, 32, 58, 742, DateTimeKind.Local).AddTicks(6307), new DateTime(2023, 7, 21, 11, 32, 58, 742, DateTimeKind.Local).AddTicks(6307) });

            migrationBuilder.UpdateData(
                table: "Days",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 11, 32, 58, 742, DateTimeKind.Local).AddTicks(6308), new DateTime(2023, 7, 21, 11, 32, 58, 742, DateTimeKind.Local).AddTicks(6309) });

            migrationBuilder.UpdateData(
                table: "Days",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 11, 32, 58, 742, DateTimeKind.Local).AddTicks(6309), new DateTime(2023, 7, 21, 11, 32, 58, 742, DateTimeKind.Local).AddTicks(6310) });

            migrationBuilder.UpdateData(
                table: "Days",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 11, 32, 58, 742, DateTimeKind.Local).AddTicks(6310), new DateTime(2023, 7, 21, 11, 32, 58, 742, DateTimeKind.Local).AddTicks(6311) });

            migrationBuilder.UpdateData(
                table: "Days",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 11, 32, 58, 742, DateTimeKind.Local).AddTicks(6312), new DateTime(2023, 7, 21, 11, 32, 58, 742, DateTimeKind.Local).AddTicks(6312) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 11, 32, 58, 742, DateTimeKind.Local).AddTicks(6378), new DateTime(2023, 7, 21, 11, 32, 58, 742, DateTimeKind.Local).AddTicks(6378) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 11, 32, 58, 742, DateTimeKind.Local).AddTicks(6380), new DateTime(2023, 7, 21, 11, 32, 58, 742, DateTimeKind.Local).AddTicks(6380) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 11, 32, 58, 742, DateTimeKind.Local).AddTicks(6381), new DateTime(2023, 7, 21, 11, 32, 58, 742, DateTimeKind.Local).AddTicks(6382) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 11, 32, 58, 742, DateTimeKind.Local).AddTicks(6383), new DateTime(2023, 7, 21, 11, 32, 58, 742, DateTimeKind.Local).AddTicks(6383) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 11, 32, 58, 742, DateTimeKind.Local).AddTicks(6384), new DateTime(2023, 7, 21, 11, 32, 58, 742, DateTimeKind.Local).AddTicks(6385) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 11, 32, 58, 742, DateTimeKind.Local).AddTicks(6386), new DateTime(2023, 7, 21, 11, 32, 58, 742, DateTimeKind.Local).AddTicks(6386) });
        }
    }
}
