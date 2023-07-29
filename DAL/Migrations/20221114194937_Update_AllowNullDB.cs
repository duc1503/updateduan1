using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class Update_AllowNullDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietTienNghi_Phong_IdPhong",
                table: "ChiTietTienNghi");

            migrationBuilder.AlterColumn<Guid>(
                name: "IdPhong",
                table: "ChiTietTienNghi",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietTienNghi_Phong_IdPhong",
                table: "ChiTietTienNghi",
                column: "IdPhong",
                principalTable: "Phong",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietTienNghi_Phong_IdPhong",
                table: "ChiTietTienNghi");

            migrationBuilder.AlterColumn<Guid>(
                name: "IdPhong",
                table: "ChiTietTienNghi",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietTienNghi_Phong_IdPhong",
                table: "ChiTietTienNghi",
                column: "IdPhong",
                principalTable: "Phong",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
