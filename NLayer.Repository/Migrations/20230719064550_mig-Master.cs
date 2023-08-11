using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NLayer.Repository.Migrations
{
    public partial class migMaster : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Condition = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Classes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WeekCount = table.Column<int>(type: "int", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Condition = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyOffical = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OfficalTCKN = table.Column<int>(type: "int", nullable: false),
                    OfficalName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OfficalSurname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OfficalTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OfficalPhone = table.Column<int>(type: "int", nullable: false),
                    OfficalEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OfficalAdress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyPhone = table.Column<int>(type: "int", nullable: false),
                    CompanyPhone2 = table.Column<int>(type: "int", nullable: false),
                    CompanyAdress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyAdress2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyCity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyDistrict = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ZipCode = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Condition = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Days",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Condition = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Days", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DepartmentManager = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Condition = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Notes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Task = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Favorite = table.Column<bool>(type: "bit", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Condition = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TodoLists",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Task = table.Column<bool>(type: "bit", nullable: true),
                    Favorite = table.Column<bool>(type: "bit", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Condition = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TodoLists", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AppRoleId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_AppRoleId",
                        column: x => x.AppRoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pollings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PollingDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClassId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Condition = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pollings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pollings_Classes_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Classes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentIdentity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SurName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SchoolClass = table.Column<int>(type: "int", nullable: false),
                    School = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<bool>(type: "bit", nullable: false),
                    GuardianIdentity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GuardianName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GuardianSurName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GuardianJob = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GuardianPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GuardianEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<int>(type: "int", nullable: false),
                    ClassId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Condition = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Students_Classes_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Classes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ClassDays",
                columns: table => new
                {
                    ClassId = table.Column<int>(type: "int", nullable: false),
                    DayId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassDays", x => new { x.DayId, x.ClassId });
                    table.ForeignKey(
                        name: "FK_ClassDays_Classes_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Classes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClassDays_Days_DayId",
                        column: x => x.DayId,
                        principalTable: "Days",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TCKN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Salary = table.Column<int>(type: "int", nullable: false),
                    Iban = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FinishDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: false),
                    Mother = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Father = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UrgentPerson = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UrgentPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Condition = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employees_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PaymentMethod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaymentStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Condition = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Payments_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudentPollings",
                columns: table => new
                {
                    PollingId = table.Column<int>(type: "int", nullable: false),
                    StudentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentPollings", x => new { x.PollingId, x.StudentId });
                    table.ForeignKey(
                        name: "FK_StudentPollings_Pollings_PollingId",
                        column: x => x.PollingId,
                        principalTable: "Pollings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentPollings_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DepartmentEmployees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentId = table.Column<int>(type: "int", nullable: false),
                    EmployeesId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Condition = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepartmentEmployees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DepartmentEmployees_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DepartmentEmployees_Employees_EmployeesId",
                        column: x => x.EmployeesId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "Condition", "CreatedDate", "ImageUrl", "Name", "UpdatedDate", "WeekCount" },
                values: new object[,]
                {
                    { 1, true, new DateTime(2023, 7, 19, 9, 45, 50, 401, DateTimeKind.Local).AddTicks(5114), null, "Python", new DateTime(2023, 7, 19, 9, 45, 50, 401, DateTimeKind.Local).AddTicks(5127), 0 },
                    { 2, true, new DateTime(2023, 7, 19, 9, 45, 50, 401, DateTimeKind.Local).AddTicks(5128), null, "Java", new DateTime(2023, 7, 19, 9, 45, 50, 401, DateTimeKind.Local).AddTicks(5128), 0 },
                    { 3, true, new DateTime(2023, 7, 19, 9, 45, 50, 401, DateTimeKind.Local).AddTicks(5151), null, "Php", new DateTime(2023, 7, 19, 9, 45, 50, 401, DateTimeKind.Local).AddTicks(5152), 0 },
                    { 4, true, new DateTime(2023, 7, 19, 9, 45, 50, 401, DateTimeKind.Local).AddTicks(5152), null, "R", new DateTime(2023, 7, 19, 9, 45, 50, 401, DateTimeKind.Local).AddTicks(5153), 0 },
                    { 5, true, new DateTime(2023, 7, 19, 9, 45, 50, 401, DateTimeKind.Local).AddTicks(5154), null, "Javascript", new DateTime(2023, 7, 19, 9, 45, 50, 401, DateTimeKind.Local).AddTicks(5154), 0 }
                });

            migrationBuilder.InsertData(
                table: "Days",
                columns: new[] { "Id", "Condition", "CreatedDate", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, true, new DateTime(2023, 7, 19, 9, 45, 50, 401, DateTimeKind.Local).AddTicks(5214), "Pazatesi", new DateTime(2023, 7, 19, 9, 45, 50, 401, DateTimeKind.Local).AddTicks(5214) },
                    { 2, true, new DateTime(2023, 7, 19, 9, 45, 50, 401, DateTimeKind.Local).AddTicks(5215), "Salı", new DateTime(2023, 7, 19, 9, 45, 50, 401, DateTimeKind.Local).AddTicks(5215) },
                    { 3, true, new DateTime(2023, 7, 19, 9, 45, 50, 401, DateTimeKind.Local).AddTicks(5216), "Çarşamba", new DateTime(2023, 7, 19, 9, 45, 50, 401, DateTimeKind.Local).AddTicks(5216) },
                    { 4, true, new DateTime(2023, 7, 19, 9, 45, 50, 401, DateTimeKind.Local).AddTicks(5217), "Perşembe", new DateTime(2023, 7, 19, 9, 45, 50, 401, DateTimeKind.Local).AddTicks(5218) },
                    { 5, true, new DateTime(2023, 7, 19, 9, 45, 50, 401, DateTimeKind.Local).AddTicks(5218), "Cuma", new DateTime(2023, 7, 19, 9, 45, 50, 401, DateTimeKind.Local).AddTicks(5219) },
                    { 6, true, new DateTime(2023, 7, 19, 9, 45, 50, 401, DateTimeKind.Local).AddTicks(5219), "Cumartesi", new DateTime(2023, 7, 19, 9, 45, 50, 401, DateTimeKind.Local).AddTicks(5220) },
                    { 7, true, new DateTime(2023, 7, 19, 9, 45, 50, 401, DateTimeKind.Local).AddTicks(5220), "Pazar", new DateTime(2023, 7, 19, 9, 45, 50, 401, DateTimeKind.Local).AddTicks(5221) }
                });

            migrationBuilder.InsertData(
                table: "ClassDays",
                columns: new[] { "ClassId", "DayId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 },
                    { 3, 3 }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Adress", "ClassId", "Condition", "CreatedDate", "Gender", "GuardianEmail", "GuardianIdentity", "GuardianJob", "GuardianName", "GuardianPhone", "GuardianSurName", "Name", "Price", "School", "SchoolClass", "StudentIdentity", "SurName", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "Antalya/Kepez Kültür Mah. Galipkaya cad. BinaNo:29 NO:4", 1, true, new DateTime(2023, 7, 19, 9, 45, 50, 401, DateTimeKind.Local).AddTicks(5279), false, null, null, null, "Hatice", "05525326858", "Çakır", "Ahmet", 500, null, 0, null, "Çakır", new DateTime(2023, 7, 19, 9, 45, 50, 401, DateTimeKind.Local).AddTicks(5280) },
                    { 2, "Antalya/Kepze Kültür Mah. Galipkaya cad. BinaNo:12 NO:1", 2, true, new DateTime(2023, 7, 19, 9, 45, 50, 401, DateTimeKind.Local).AddTicks(5281), true, null, null, null, "Ahmet", "05525326858", "Topal", "Mehmet", 500, null, 0, null, "Topal", new DateTime(2023, 7, 19, 9, 45, 50, 401, DateTimeKind.Local).AddTicks(5282) },
                    { 3, "Antalya/Kepez Kültür Mah. Galipkaya cad. BinaNo:76 NO:3", 1, true, new DateTime(2023, 7, 19, 9, 45, 50, 401, DateTimeKind.Local).AddTicks(5283), true, null, null, null, "Hatice", "05525326858", "Bozkır", "Veli", 500, null, 0, null, "Bozkır", new DateTime(2023, 7, 19, 9, 45, 50, 401, DateTimeKind.Local).AddTicks(5283) },
                    { 4, "Antalya/Kepez Kültür Mah. Galipkaya cad. BinaNo:5 NO:42", 3, true, new DateTime(2023, 7, 19, 9, 45, 50, 401, DateTimeKind.Local).AddTicks(5284), true, null, null, null, "Hatice", "05525326858", "Kılınç", "Oğuzhan", 500, null, 0, null, "Kılınç", new DateTime(2023, 7, 19, 9, 45, 50, 401, DateTimeKind.Local).AddTicks(5285) },
                    { 5, "Antalya/Kepez Kültür Mah. Galipkaya cad. BinaNo:2 NO:43", 1, true, new DateTime(2023, 7, 19, 9, 45, 50, 401, DateTimeKind.Local).AddTicks(5286), true, null, null, null, "Hatice", "05525326858", "Bozkurt", "Metehan", 500, null, 0, null, "Bozkurt", new DateTime(2023, 7, 19, 9, 45, 50, 401, DateTimeKind.Local).AddTicks(5286) },
                    { 6, "Antalya/Kepez Kültür Mah. Galipkaya cad. BinaNo:59 NO:44", 2, true, new DateTime(2023, 7, 19, 9, 45, 50, 401, DateTimeKind.Local).AddTicks(5287), true, null, null, null, "Yeliz", "05525326858", "Eroğlu", "İbrahim", 500, null, 0, null, "Eroğlu", new DateTime(2023, 7, 19, 9, 45, 50, 401, DateTimeKind.Local).AddTicks(5288) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_AppRoleId",
                table: "AspNetUserRoles",
                column: "AppRoleId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ClassDays_ClassId",
                table: "ClassDays",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentEmployees_DepartmentId",
                table: "DepartmentEmployees",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentEmployees_EmployeesId",
                table: "DepartmentEmployees",
                column: "EmployeesId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DepartmentId",
                table: "Employees",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_StudentId",
                table: "Payments",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Pollings_ClassId",
                table: "Pollings",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentPollings_StudentId",
                table: "StudentPollings",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_ClassId",
                table: "Students",
                column: "ClassId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "ClassDays");

            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropTable(
                name: "DepartmentEmployees");

            migrationBuilder.DropTable(
                name: "Notes");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "StudentPollings");

            migrationBuilder.DropTable(
                name: "TodoLists");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Days");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Pollings");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Classes");
        }
    }
}
