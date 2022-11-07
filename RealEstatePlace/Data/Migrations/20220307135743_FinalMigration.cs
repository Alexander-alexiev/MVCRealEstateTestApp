using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RealEstatePlace.Migrations
{
    public partial class FinalMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2022, 3, 7, 13, 57, 42, 648, DateTimeKind.Utc).AddTicks(9971));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2022, 2, 28, 15, 19, 29, 100, DateTimeKind.Utc).AddTicks(3034));
        }
    }
}
