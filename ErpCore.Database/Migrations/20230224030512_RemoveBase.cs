using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ErpCore.Database.Migrations
{
    public partial class RemoveBase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Wards");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Wards");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Wards");

            migrationBuilder.DropColumn(
                name: "LastUpdateAt",
                table: "Wards");

            migrationBuilder.DropColumn(
                name: "LastUpdateBy",
                table: "Wards");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Provinces");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Provinces");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Provinces");

            migrationBuilder.DropColumn(
                name: "LastUpdateAt",
                table: "Provinces");

            migrationBuilder.DropColumn(
                name: "LastUpdateBy",
                table: "Provinces");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Districts");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Districts");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Districts");

            migrationBuilder.DropColumn(
                name: "LastUpdateAt",
                table: "Districts");

            migrationBuilder.DropColumn(
                name: "LastUpdateBy",
                table: "Districts");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Wards",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Wards",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Wards",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdateAt",
                table: "Wards",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastUpdateBy",
                table: "Wards",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Provinces",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Provinces",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Provinces",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdateAt",
                table: "Provinces",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastUpdateBy",
                table: "Provinces",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Districts",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Districts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Districts",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdateAt",
                table: "Districts",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastUpdateBy",
                table: "Districts",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
