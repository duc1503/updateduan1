using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class updateFK_Tbl_PT : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PhieuThue_KhachHang_IdKH",
                table: "PhieuThue");

            migrationBuilder.DropForeignKey(
                name: "FK_PhieuThue_NhanVien_IdNV",
                table: "PhieuThue");

            migrationBuilder.AlterColumn<Guid>(
                name: "IdNV",
                table: "PhieuThue",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "IdKH",
                table: "PhieuThue",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddForeignKey(
                name: "FK_PhieuThue_KhachHang_IdKH",
                table: "PhieuThue",
                column: "IdKH",
                principalTable: "KhachHang",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_PhieuThue_NhanVien_IdNV",
                table: "PhieuThue",
                column: "IdNV",
                principalTable: "NhanVien",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PhieuThue_KhachHang_IdKH",
                table: "PhieuThue");

            migrationBuilder.DropForeignKey(
                name: "FK_PhieuThue_NhanVien_IdNV",
                table: "PhieuThue");

            migrationBuilder.AlterColumn<Guid>(
                name: "IdNV",
                table: "PhieuThue",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "IdKH",
                table: "PhieuThue",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_PhieuThue_KhachHang_IdKH",
                table: "PhieuThue",
                column: "IdKH",
                principalTable: "KhachHang",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PhieuThue_NhanVien_IdNV",
                table: "PhieuThue",
                column: "IdNV",
                principalTable: "NhanVien",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
