using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ErpCore.Database.Migrations
{
    public partial class UpdateEmployee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AcademicLevel",
                table: "Employes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfBirth",
                table: "Employes",
                type: "date",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Department",
                table: "Employes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Education",
                table: "Employes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EmployeeRoleId",
                table: "Employes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Ranking",
                table: "Employes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "WorkExperience",
                table: "Employes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "EmployeeRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdateBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeRoles", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employes_EmployeeRoleId",
                table: "Employes",
                column: "EmployeeRoleId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Employes_EmployeeRoles_EmployeeRoleId",
                table: "Employes",
                column: "EmployeeRoleId",
                principalTable: "EmployeeRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employes_EmployeeRoles_EmployeeRoleId",
                table: "Employes");

            migrationBuilder.DropTable(
                name: "EmployeeRoles");

            migrationBuilder.DropIndex(
                name: "IX_Employes_EmployeeRoleId",
                table: "Employes");

            migrationBuilder.DropColumn(
                name: "AcademicLevel",
                table: "Employes");

            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "Employes");

            migrationBuilder.DropColumn(
                name: "Department",
                table: "Employes");

            migrationBuilder.DropColumn(
                name: "Education",
                table: "Employes");

            migrationBuilder.DropColumn(
                name: "EmployeeRoleId",
                table: "Employes");

            migrationBuilder.DropColumn(
                name: "Ranking",
                table: "Employes");

            migrationBuilder.DropColumn(
                name: "WorkExperience",
                table: "Employes");
        }
    }
}
