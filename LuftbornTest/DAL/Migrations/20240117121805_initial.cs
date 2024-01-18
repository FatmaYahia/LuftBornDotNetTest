using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AccessLevels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccessLevels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SystemUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JobTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SystemUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SystemViews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SystemViews", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FK_Gender = table.Column<int>(type: "int", nullable: false),
                    Fk_Department = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employees_Departments_Fk_Department",
                        column: x => x.Fk_Department,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employees_Genders_FK_Gender",
                        column: x => x.FK_Gender,
                        principalTable: "Genders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SystemUserPermissions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FK_SystemUser = table.Column<int>(type: "int", nullable: false),
                    FK_AccessLevel = table.Column<int>(type: "int", nullable: false),
                    FK_SystemView = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SystemUserPermissions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SystemUserPermissions_AccessLevels_FK_AccessLevel",
                        column: x => x.FK_AccessLevel,
                        principalTable: "AccessLevels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SystemUserPermissions_SystemUsers_FK_SystemUser",
                        column: x => x.FK_SystemUser,
                        principalTable: "SystemUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SystemUserPermissions_SystemViews_FK_SystemView",
                        column: x => x.FK_SystemView,
                        principalTable: "SystemViews",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AccessLevels",
                columns: new[] { "Id", "CreatedAt", "LastModifiedAt", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 1, 17, 14, 18, 5, 30, DateTimeKind.Unspecified).AddTicks(9303), new DateTime(2024, 1, 17, 14, 18, 5, 30, DateTimeKind.Unspecified).AddTicks(9395), "FullAccess" },
                    { 2, new DateTime(2024, 1, 17, 14, 18, 5, 30, DateTimeKind.Unspecified).AddTicks(9428), new DateTime(2024, 1, 17, 14, 18, 5, 30, DateTimeKind.Unspecified).AddTicks(9437), "ControlAccess" },
                    { 3, new DateTime(2024, 1, 17, 14, 18, 5, 30, DateTimeKind.Unspecified).AddTicks(9446), new DateTime(2024, 1, 17, 14, 18, 5, 30, DateTimeKind.Unspecified).AddTicks(9453), "ViewAccess" }
                });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "Id", "CreatedAt", "LastModifiedAt", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 1, 17, 14, 18, 5, 31, DateTimeKind.Unspecified).AddTicks(232), new DateTime(2024, 1, 17, 14, 18, 5, 31, DateTimeKind.Unspecified).AddTicks(244), "Male" },
                    { 2, new DateTime(2024, 1, 17, 14, 18, 5, 31, DateTimeKind.Unspecified).AddTicks(253), new DateTime(2024, 1, 17, 14, 18, 5, 31, DateTimeKind.Unspecified).AddTicks(260), "Female" }
                });

            migrationBuilder.InsertData(
                table: "SystemUsers",
                columns: new[] { "Id", "CreatedAt", "Email", "FullName", "IsActive", "JobTitle", "LastModifiedAt", "Password" },
                values: new object[] { 1, new DateTime(2024, 1, 17, 14, 18, 5, 30, DateTimeKind.Unspecified).AddTicks(9800), "Developer@App.com", "Developer", true, "Developer", new DateTime(2024, 1, 17, 14, 18, 5, 30, DateTimeKind.Unspecified).AddTicks(9812), "hahm9974qs" });

            migrationBuilder.InsertData(
                table: "SystemViews",
                columns: new[] { "Id", "CreatedAt", "LastModifiedAt", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 1, 17, 14, 18, 5, 30, DateTimeKind.Unspecified).AddTicks(9696), new DateTime(2024, 1, 17, 14, 18, 5, 30, DateTimeKind.Unspecified).AddTicks(9714), "Home" },
                    { 2, new DateTime(2024, 1, 17, 14, 18, 5, 30, DateTimeKind.Unspecified).AddTicks(9724), new DateTime(2024, 1, 17, 14, 18, 5, 30, DateTimeKind.Unspecified).AddTicks(9731), "SystemView" },
                    { 3, new DateTime(2024, 1, 17, 14, 18, 5, 30, DateTimeKind.Unspecified).AddTicks(9739), new DateTime(2024, 1, 17, 14, 18, 5, 30, DateTimeKind.Unspecified).AddTicks(9745), "SystemUser" }
                });

            migrationBuilder.InsertData(
                table: "SystemUserPermissions",
                columns: new[] { "Id", "CreatedAt", "FK_AccessLevel", "FK_SystemUser", "FK_SystemView", "LastModifiedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 1, 17, 14, 18, 5, 31, DateTimeKind.Unspecified).AddTicks(133), 1, 1, 1, new DateTime(2024, 1, 17, 14, 18, 5, 31, DateTimeKind.Unspecified).AddTicks(153) },
                    { 2, new DateTime(2024, 1, 17, 14, 18, 5, 31, DateTimeKind.Unspecified).AddTicks(163), 1, 1, 2, new DateTime(2024, 1, 17, 14, 18, 5, 31, DateTimeKind.Unspecified).AddTicks(169) },
                    { 3, new DateTime(2024, 1, 17, 14, 18, 5, 31, DateTimeKind.Unspecified).AddTicks(177), 1, 1, 3, new DateTime(2024, 1, 17, 14, 18, 5, 31, DateTimeKind.Unspecified).AddTicks(183) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_Fk_Department",
                table: "Employees",
                column: "Fk_Department");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_FK_Gender",
                table: "Employees",
                column: "FK_Gender");

            migrationBuilder.CreateIndex(
                name: "IX_SystemUserPermissions_FK_AccessLevel",
                table: "SystemUserPermissions",
                column: "FK_AccessLevel");

            migrationBuilder.CreateIndex(
                name: "IX_SystemUserPermissions_FK_SystemUser",
                table: "SystemUserPermissions",
                column: "FK_SystemUser");

            migrationBuilder.CreateIndex(
                name: "IX_SystemUserPermissions_FK_SystemView",
                table: "SystemUserPermissions",
                column: "FK_SystemView");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "SystemUserPermissions");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Genders");

            migrationBuilder.DropTable(
                name: "AccessLevels");

            migrationBuilder.DropTable(
                name: "SystemUsers");

            migrationBuilder.DropTable(
                name: "SystemViews");
        }
    }
}
