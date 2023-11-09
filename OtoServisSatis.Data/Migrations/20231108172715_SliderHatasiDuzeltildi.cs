using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OtoServisSatis.Data.Migrations
{
    /// <inheritdoc />
    public partial class SliderHatasiDuzeltildi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "Sliders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Baslik = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Aciklama = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Resim = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Link = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sliders", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Kullanicilar",
                keyColumn: "Id",
                keyValue: 1,
                column: "EklenmeTarihi",
                value: new DateTime(2023, 11, 8, 20, 27, 15, 693, DateTimeKind.Local).AddTicks(3094));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sliders");

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
    }
}
