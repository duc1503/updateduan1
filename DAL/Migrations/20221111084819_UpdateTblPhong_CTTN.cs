using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class UpdateTblPhong_CTTN : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Phong_ChiTietTienNghi_IdCTTienNghi",
                table: "Phong");

            migrationBuilder.DropIndex(
                name: "IX_Phong_IdCTTienNghi",
                table: "Phong");

            migrationBuilder.AddColumn<Guid>(
                name: "IdPhong",
                table: "ChiTietTienNghi",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietTienNghi_IdPhong",
                table: "ChiTietTienNghi",
                column: "IdPhong");

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietTienNghi_Phong_IdPhong",
                table: "ChiTietTienNghi",
                column: "IdPhong",
                principalTable: "Phong",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietTienNghi_Phong_IdPhong",
                table: "ChiTietTienNghi");

            migrationBuilder.DropIndex(
                name: "IX_ChiTietTienNghi_IdPhong",
                table: "ChiTietTienNghi");

            migrationBuilder.DropColumn(
                name: "IdPhong",
                table: "ChiTietTienNghi");

            migrationBuilder.CreateIndex(
                name: "IX_Phong_IdCTTienNghi",
                table: "Phong",
                column: "IdCTTienNghi");

            migrationBuilder.AddForeignKey(
                name: "FK_Phong_ChiTietTienNghi_IdCTTienNghi",
                table: "Phong",
                column: "IdCTTienNghi",
                principalTable: "ChiTietTienNghi",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
