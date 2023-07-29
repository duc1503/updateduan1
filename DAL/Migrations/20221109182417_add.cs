using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class add : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ChucVu",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaCV = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    TenCV = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChucVu", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "KhachHang",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaKH = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    HoTen = table.Column<string>(type: "nvarchar(30)", nullable: false),
                    CCCD = table.Column<string>(type: "nvarchar(12)", nullable: false),
                    SDT = table.Column<string>(type: "nvarchar(12)", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(30)", nullable: false),
                    GioiTinh = table.Column<int>(type: "int", nullable: false),
                    QuocTich = table.Column<string>(type: "nvarchar(20)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhachHang", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "LoaiDichVu",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaLoaiDichVu = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    TenLoaiDichVu = table.Column<string>(type: "nvarchar(20)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiDichVu", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "LoaiPhong",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaLoaiPhong = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    TenLoaiPhong = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    SoGiuong = table.Column<int>(type: "int", nullable: false),
                    GiayNgay = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiPhong", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "LoaiTienNghi",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaLoaiTienNghi = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    TenLoaiTienNghi = table.Column<string>(type: "nvarchar(20)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiTienNghi", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "NhanVien",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaNV = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    TenNV = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    NgaySinh = table.Column<DateTime>(type: "datetime", nullable: false),
                    GioiTinh = table.Column<int>(type: "int", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    SDT = table.Column<string>(type: "nvarchar(12)", nullable: false),
                    CCCD = table.Column<string>(type: "nvarchar(12)", nullable: false),
                    Luong = table.Column<int>(type: "int", nullable: false),
                    IDCv = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanVien", x => x.ID);
                    table.ForeignKey(
                        name: "FK_NhanVien_ChucVu_IDCv",
                        column: x => x.IDCv,
                        principalTable: "ChucVu",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DichVu",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaDichVu = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    TenDichVu = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    Gia = table.Column<int>(name: "Gia ", type: "int", nullable: false),
                    IDLoaiDichVu = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DichVu", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DichVu_LoaiDichVu_IDLoaiDichVu",
                        column: x => x.IDLoaiDichVu,
                        principalTable: "LoaiDichVu",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietTienNghi",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaCTTienNghi = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    TenCTTienNghi = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    IDLoaiTienNghi = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietTienNghi", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ChiTietTienNghi_LoaiTienNghi_IDLoaiTienNghi",
                        column: x => x.IDLoaiTienNghi,
                        principalTable: "LoaiTienNghi",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TaiKhoan",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenTaiKhoan = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    MatKhau = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    CapDoQuyen = table.Column<int>(type: "int", nullable: false),
                    IDNv = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaiKhoan", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TaiKhoan_NhanVien_IDNv",
                        column: x => x.IDNv,
                        principalTable: "NhanVien",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Phong",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaPhong = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    TinhTrang = table.Column<int>(type: "int", nullable: false),
                    IDLoaiPhong = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdCTTienNghi = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phong", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Phong_ChiTietTienNghi_IdCTTienNghi",
                        column: x => x.IdCTTienNghi,
                        principalTable: "ChiTietTienNghi",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Phong_LoaiPhong_IDLoaiPhong",
                        column: x => x.IDLoaiPhong,
                        principalTable: "LoaiPhong",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietTienNghi_IDLoaiTienNghi",
                table: "ChiTietTienNghi",
                column: "IDLoaiTienNghi");

            migrationBuilder.CreateIndex(
                name: "IX_DichVu_IDLoaiDichVu",
                table: "DichVu",
                column: "IDLoaiDichVu");

            migrationBuilder.CreateIndex(
                name: "IX_NhanVien_IDCv",
                table: "NhanVien",
                column: "IDCv");

            migrationBuilder.CreateIndex(
                name: "IX_Phong_IdCTTienNghi",
                table: "Phong",
                column: "IdCTTienNghi");

            migrationBuilder.CreateIndex(
                name: "IX_Phong_IDLoaiPhong",
                table: "Phong",
                column: "IDLoaiPhong");

            migrationBuilder.CreateIndex(
                name: "IX_TaiKhoan_IDNv",
                table: "TaiKhoan",
                column: "IDNv",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DichVu");

            migrationBuilder.DropTable(
                name: "KhachHang");

            migrationBuilder.DropTable(
                name: "Phong");

            migrationBuilder.DropTable(
                name: "TaiKhoan");

            migrationBuilder.DropTable(
                name: "LoaiDichVu");

            migrationBuilder.DropTable(
                name: "ChiTietTienNghi");

            migrationBuilder.DropTable(
                name: "LoaiPhong");

            migrationBuilder.DropTable(
                name: "NhanVien");

            migrationBuilder.DropTable(
                name: "LoaiTienNghi");

            migrationBuilder.DropTable(
                name: "ChucVu");
        }
    }
}
