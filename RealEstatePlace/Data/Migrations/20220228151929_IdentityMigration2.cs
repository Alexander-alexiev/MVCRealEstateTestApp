using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RealEstatePlace.Migrations
{
    public partial class IdentityMigration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2022, 2, 28, 15, 19, 29, 100, DateTimeKind.Utc).AddTicks(3034));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2022, 2, 25, 8, 19, 40, 886, DateTimeKind.Utc).AddTicks(2805));
        }
    }
}
