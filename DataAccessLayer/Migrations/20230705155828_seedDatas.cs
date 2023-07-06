using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class seedDatas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedTime", "DeletedTime", "IsSuccess", "Name", "UpdatedTime" },
                values: new object[,]
                {
                    { new Guid("0a41149e-8ad9-4f18-85c5-cbd43afb8ef4"), new DateTime(2023, 7, 5, 18, 58, 28, 37, DateTimeKind.Local).AddTicks(7753), null, true, "Yemek Masası Tasarımı", null },
                    { new Guid("6382203e-e51f-4982-a551-38fc7ca492a6"), new DateTime(2023, 7, 5, 18, 58, 28, 37, DateTimeKind.Local).AddTicks(7710), null, true, "Mutfak Tasarımı ", null },
                    { new Guid("a0e8e78e-342c-43db-8542-499118ee87c0"), new DateTime(2023, 7, 5, 18, 58, 28, 37, DateTimeKind.Local).AddTicks(7744), null, true, "Yemek Odası Tasarımı", null },
                    { new Guid("ea437201-61f6-4bde-ad28-d2bf5f0ced94"), new DateTime(2023, 7, 5, 18, 58, 28, 37, DateTimeKind.Local).AddTicks(7760), null, true, "Banyo Tasarımı", null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0a41149e-8ad9-4f18-85c5-cbd43afb8ef4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6382203e-e51f-4982-a551-38fc7ca492a6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a0e8e78e-342c-43db-8542-499118ee87c0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ea437201-61f6-4bde-ad28-d2bf5f0ced94"));
        }
    }
}
