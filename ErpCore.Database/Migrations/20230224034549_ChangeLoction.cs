using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ErpCore.Database.Migrations
{
    public partial class ChangeLoction : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Locations_District_DistrictId",
                table: "Locations");

            migrationBuilder.DropForeignKey(
                name: "FK_Locations_Province_ProvinceId",
                table: "Locations");

            migrationBuilder.DropForeignKey(
                name: "FK_Locations_Wards_WardId",
                table: "Locations");

            migrationBuilder.DropTable(
                name: "Wards");

            migrationBuilder.DropTable(
                name: "District");

            migrationBuilder.DropTable(
                name: "Province");

            migrationBuilder.DropIndex(
                name: "IX_Locations_DistrictId",
                table: "Locations");

            migrationBuilder.DropIndex(
                name: "IX_Locations_ProvinceId",
                table: "Locations");

            migrationBuilder.DropIndex(
                name: "IX_Locations_WardId",
                table: "Locations");

            migrationBuilder.DropColumn(
                name: "DistrictId",
                table: "Locations");

            migrationBuilder.DropColumn(
                name: "ProvinceId",
                table: "Locations");

            migrationBuilder.DropColumn(
                name: "WardId",
                table: "Locations");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DistrictId",
                table: "Locations",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProvinceId",
                table: "Locations",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "WardId",
                table: "Locations",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Province",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Province", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "District",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProvinceId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_District", x => x.Id);
                    table.ForeignKey(
                        name: "FK_District_Province_ProvinceId",
                        column: x => x.ProvinceId,
                        principalTable: "Province",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Wards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DistrictId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Wards_District_DistrictId",
                        column: x => x.DistrictId,
                        principalTable: "District",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Locations_DistrictId",
                table: "Locations",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_Locations_ProvinceId",
                table: "Locations",
                column: "ProvinceId");

            migrationBuilder.CreateIndex(
                name: "IX_Locations_WardId",
                table: "Locations",
                column: "WardId");

            migrationBuilder.CreateIndex(
                name: "IX_District_ProvinceId",
                table: "District",
                column: "ProvinceId");

            migrationBuilder.CreateIndex(
                name: "IX_Wards_DistrictId",
                table: "Wards",
                column: "DistrictId");

            migrationBuilder.AddForeignKey(
                name: "FK_Locations_District_DistrictId",
                table: "Locations",
                column: "DistrictId",
                principalTable: "District",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Locations_Province_ProvinceId",
                table: "Locations",
                column: "ProvinceId",
                principalTable: "Province",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Locations_Wards_WardId",
                table: "Locations",
                column: "WardId",
                principalTable: "Wards",
                principalColumn: "Id");
        }
    }
}
