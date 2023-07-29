using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class updateDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PhieuThue",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NgayLapPhieu = table.Column<DateTime>(type: "datetime", nullable: false),
                    IdKH = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdNV = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhieuThue", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PhieuThue_KhachHang_IdKH",
                        column: x => x.IdKH,
                        principalTable: "KhachHang",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PhieuThue_NhanVien_IdNV",
                        column: x => x.IdNV,
                        principalTable: "NhanVien",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CTPhieuThue",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NgayBatDau = table.Column<DateTime>(type: "datetime", nullable: false),
                    NgayKetThuc = table.Column<DateTime>(type: "datetime", nullable: false),
                    IdPhieuThue = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdPhong = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CTPhieuThue", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CTPhieuThue_PhieuThue_IdPhieuThue",
                        column: x => x.IdPhieuThue,
                        principalTable: "PhieuThue",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CTPhieuThue_Phong_IdPhong",
                        column: x => x.IdPhong,
                        principalTable: "Phong",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HoaDon",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaHD = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    NgayTaoHD = table.Column<DateTime>(type: "datetime", nullable: false),
                    IdCTPhieuThue = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDon", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HoaDon_CTPhieuThue_IdCTPhieuThue",
                        column: x => x.IdCTPhieuThue,
                        principalTable: "CTPhieuThue",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HoaDonChiTiet",
                columns: table => new
                {
                    IdDichVu = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdHoaDon = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    DonGia = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDonChiTiet", x => new { x.IdHoaDon, x.IdDichVu });
                    table.ForeignKey(
                        name: "FK_HoaDonChiTiet_DichVu_IdDichVu",
                        column: x => x.IdDichVu,
                        principalTable: "DichVu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HoaDonChiTiet_HoaDon_IdHoaDon",
                        column: x => x.IdHoaDon,
                        principalTable: "HoaDon",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CTPhieuThue_IdPhieuThue",
                table: "CTPhieuThue",
                column: "IdPhieuThue");

            migrationBuilder.CreateIndex(
                name: "IX_CTPhieuThue_IdPhong",
                table: "CTPhieuThue",
                column: "IdPhong");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_IdCTPhieuThue",
                table: "HoaDon",
                column: "IdCTPhieuThue",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonChiTiet_IdDichVu",
                table: "HoaDonChiTiet",
                column: "IdDichVu");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuThue_IdKH",
                table: "PhieuThue",
                column: "IdKH");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuThue_IdNV",
                table: "PhieuThue",
                column: "IdNV");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HoaDonChiTiet");

            migrationBuilder.DropTable(
                name: "HoaDon");

            migrationBuilder.DropTable(
                name: "CTPhieuThue");

            migrationBuilder.DropTable(
                name: "PhieuThue");
        }
    }
}
