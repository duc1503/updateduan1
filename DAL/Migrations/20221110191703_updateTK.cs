using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class updateTK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TaiKhoan_NhanVien_IDNv",
                table: "TaiKhoan");

            migrationBuilder.DropIndex(
                name: "IX_TaiKhoan_IDNv",
                table: "TaiKhoan");

            migrationBuilder.AlterColumn<Guid>(
                name: "IDNv",
                table: "TaiKhoan",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.CreateIndex(
                name: "IX_TaiKhoan_IDNv",
                table: "TaiKhoan",
                column: "IDNv",
                unique: true,
                filter: "[IDNv] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_TaiKhoan_NhanVien_IDNv",
                table: "TaiKhoan",
                column: "IDNv",
                principalTable: "NhanVien",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TaiKhoan_NhanVien_IDNv",
                table: "TaiKhoan");

            migrationBuilder.DropIndex(
                name: "IX_TaiKhoan_IDNv",
                table: "TaiKhoan");

            migrationBuilder.AlterColumn<Guid>(
                name: "IDNv",
                table: "TaiKhoan",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TaiKhoan_IDNv",
                table: "TaiKhoan",
                column: "IDNv",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_TaiKhoan_NhanVien_IDNv",
                table: "TaiKhoan",
                column: "IDNv",
                principalTable: "NhanVien",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
