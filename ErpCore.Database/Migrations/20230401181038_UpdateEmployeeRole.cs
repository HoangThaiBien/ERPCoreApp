using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ErpCore.Database.Migrations
{
    public partial class UpdateEmployeeRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employes_EmployeeRoles_EmployeeRoleId",
                table: "Employes");

            migrationBuilder.DropIndex(
                name: "IX_Employes_EmployeeRoleId",
                table: "Employes");

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeRoleId",
                table: "Employes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Employes_EmployeeRoleId",
                table: "Employes",
                column: "EmployeeRoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employes_EmployeeRoles_EmployeeRoleId",
                table: "Employes",
                column: "EmployeeRoleId",
                principalTable: "EmployeeRoles",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employes_EmployeeRoles_EmployeeRoleId",
                table: "Employes");

            migrationBuilder.DropIndex(
                name: "IX_Employes_EmployeeRoleId",
                table: "Employes");

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeRoleId",
                table: "Employes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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
    }
}
