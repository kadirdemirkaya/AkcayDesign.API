using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class columnAdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0a41149e-8ad9-4f18-85c5-cbd43afb8ef4"),
                column: "CreatedTime",
                value: new DateTime(2023, 7, 6, 14, 49, 54, 925, DateTimeKind.Local).AddTicks(4056));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6382203e-e51f-4982-a551-38fc7ca492a6"),
                column: "CreatedTime",
                value: new DateTime(2023, 7, 6, 14, 49, 54, 925, DateTimeKind.Local).AddTicks(4020));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a0e8e78e-342c-43db-8542-499118ee87c0"),
                column: "CreatedTime",
                value: new DateTime(2023, 7, 6, 14, 49, 54, 925, DateTimeKind.Local).AddTicks(4051));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ea437201-61f6-4bde-ad28-d2bf5f0ced94"),
                column: "CreatedTime",
                value: new DateTime(2023, 7, 6, 14, 49, 54, 925, DateTimeKind.Local).AddTicks(4060));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0a41149e-8ad9-4f18-85c5-cbd43afb8ef4"),
                column: "CreatedTime",
                value: new DateTime(2023, 7, 5, 18, 58, 28, 37, DateTimeKind.Local).AddTicks(7753));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6382203e-e51f-4982-a551-38fc7ca492a6"),
                column: "CreatedTime",
                value: new DateTime(2023, 7, 5, 18, 58, 28, 37, DateTimeKind.Local).AddTicks(7710));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a0e8e78e-342c-43db-8542-499118ee87c0"),
                column: "CreatedTime",
                value: new DateTime(2023, 7, 5, 18, 58, 28, 37, DateTimeKind.Local).AddTicks(7744));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ea437201-61f6-4bde-ad28-d2bf5f0ced94"),
                column: "CreatedTime",
                value: new DateTime(2023, 7, 5, 18, 58, 28, 37, DateTimeKind.Local).AddTicks(7760));
        }
    }
}
