using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ErpCore.Database.Migrations
{
    public partial class UpdateAllDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Locations_Customers_CustomerId",
                table: "Locations");

            migrationBuilder.DropForeignKey(
                name: "FK_Locations_Employes_EmployeeId",
                table: "Locations");

            migrationBuilder.DropIndex(
                name: "IX_Locations_CustomerId",
                table: "Locations");

            migrationBuilder.DropIndex(
                name: "IX_Locations_EmployeeId",
                table: "Locations");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "Locations");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "Locations");

            migrationBuilder.DropColumn(
                name: "Education",
                table: "Employes");

            migrationBuilder.RenameColumn(
                name: "Ranking",
                table: "Employes",
                newName: "LocationId");

            migrationBuilder.AddColumn<int>(
                name: "LocationId",
                table: "Customers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employes_LocationId",
                table: "Employes",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_LocationId",
                table: "Customers",
                column: "LocationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Locations_LocationId",
                table: "Customers",
                column: "LocationId",
                principalTable: "Locations",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Employes_Locations_LocationId",
                table: "Employes",
                column: "LocationId",
                principalTable: "Locations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Locations_LocationId",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_Employes_Locations_LocationId",
                table: "Employes");

            migrationBuilder.DropIndex(
                name: "IX_Employes_LocationId",
                table: "Employes");

            migrationBuilder.DropIndex(
                name: "IX_Customers_LocationId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "LocationId",
                table: "Customers");

            migrationBuilder.RenameColumn(
                name: "LocationId",
                table: "Employes",
                newName: "Ranking");

            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "Locations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "Locations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Education",
                table: "Employes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Locations_CustomerId",
                table: "Locations",
                column: "CustomerId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Locations_EmployeeId",
                table: "Locations",
                column: "EmployeeId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Locations_Customers_CustomerId",
                table: "Locations",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Locations_Employes_EmployeeId",
                table: "Locations",
                column: "EmployeeId",
                principalTable: "Employes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
