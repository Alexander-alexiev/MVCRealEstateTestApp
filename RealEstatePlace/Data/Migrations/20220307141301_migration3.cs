using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RealEstatePlace.Migrations
{
    public partial class migration3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2022, 3, 7, 14, 13, 1, 56, DateTimeKind.Utc).AddTicks(8450));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2022, 3, 7, 13, 57, 42, 648, DateTimeKind.Utc).AddTicks(9971));
        }
    }
}
