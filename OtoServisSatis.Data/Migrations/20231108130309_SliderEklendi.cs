using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OtoServisSatis.Data.Migrations
{
    /// <inheritdoc />
    public partial class SliderEklendi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Servisler",
                table: "Servisler");

            migrationBuilder.RenameTable(
                name: "Servisler",
                newName: "Servis");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Servis",
                table: "Servis",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Kullanicilar",
                keyColumn: "Id",
                keyValue: 1,
                column: "EklenmeTarihi",
                value: new DateTime(2023, 11, 8, 16, 3, 9, 584, DateTimeKind.Local).AddTicks(7975));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Servis",
                table: "Servis");

            migrationBuilder.RenameTable(
                name: "Servis",
                newName: "Servisler");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Servisler",
                table: "Servisler",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Kullanicilar",
                keyColumn: "Id",
                keyValue: 1,
                column: "EklenmeTarihi",
                value: new DateTime(2023, 11, 8, 15, 50, 32, 588, DateTimeKind.Local).AddTicks(9195));
        }
    }
}
