using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class Fix_Unique : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropUniqueConstraint(
                name: "AK_TaiKhoan_TenTaiKhoan",
                table: "TaiKhoan");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_Phong_MaPhong",
                table: "Phong");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_NhanVien_MaNV",
                table: "NhanVien");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_LoaiTienNghi_MaLoaiTienNghi",
                table: "LoaiTienNghi");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_LoaiPhong_MaLoaiPhong",
                table: "LoaiPhong");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_LoaiDichVu_MaLoaiDichVu",
                table: "LoaiDichVu");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_KhachHang_MaKH",
                table: "KhachHang");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_HoaDon_MaHD",
                table: "HoaDon");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_DichVu_MaDichVu",
                table: "DichVu");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_ChucVu_MaCV",
                table: "ChucVu");

            migrationBuilder.CreateIndex(
                name: "IX_TaiKhoan_TenTaiKhoan",
                table: "TaiKhoan",
                column: "TenTaiKhoan",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Phong_MaPhong",
                table: "Phong",
                column: "MaPhong",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_NhanVien_MaNV",
                table: "NhanVien",
                column: "MaNV",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_LoaiTienNghi_MaLoaiTienNghi",
                table: "LoaiTienNghi",
                column: "MaLoaiTienNghi",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_LoaiPhong_MaLoaiPhong",
                table: "LoaiPhong",
                column: "MaLoaiPhong",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_LoaiDichVu_MaLoaiDichVu",
                table: "LoaiDichVu",
                column: "MaLoaiDichVu",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_KhachHang_MaKH",
                table: "KhachHang",
                column: "MaKH",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_MaHD",
                table: "HoaDon",
                column: "MaHD",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DichVu_MaDichVu",
                table: "DichVu",
                column: "MaDichVu",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ChucVu_MaCV",
                table: "ChucVu",
                column: "MaCV",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietTienNghi_MaCTTienNghi",
                table: "ChiTietTienNghi",
                column: "MaCTTienNghi",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_TaiKhoan_TenTaiKhoan",
                table: "TaiKhoan");

            migrationBuilder.DropIndex(
                name: "IX_Phong_MaPhong",
                table: "Phong");

            migrationBuilder.DropIndex(
                name: "IX_NhanVien_MaNV",
                table: "NhanVien");

            migrationBuilder.DropIndex(
                name: "IX_LoaiTienNghi_MaLoaiTienNghi",
                table: "LoaiTienNghi");

            migrationBuilder.DropIndex(
                name: "IX_LoaiPhong_MaLoaiPhong",
                table: "LoaiPhong");

            migrationBuilder.DropIndex(
                name: "IX_LoaiDichVu_MaLoaiDichVu",
                table: "LoaiDichVu");

            migrationBuilder.DropIndex(
                name: "IX_KhachHang_MaKH",
                table: "KhachHang");

            migrationBuilder.DropIndex(
                name: "IX_HoaDon_MaHD",
                table: "HoaDon");

            migrationBuilder.DropIndex(
                name: "IX_DichVu_MaDichVu",
                table: "DichVu");

            migrationBuilder.DropIndex(
                name: "IX_ChucVu_MaCV",
                table: "ChucVu");

            migrationBuilder.DropIndex(
                name: "IX_ChiTietTienNghi_MaCTTienNghi",
                table: "ChiTietTienNghi");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_TaiKhoan_TenTaiKhoan",
                table: "TaiKhoan",
                column: "TenTaiKhoan");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_Phong_MaPhong",
                table: "Phong",
                column: "MaPhong");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_NhanVien_MaNV",
                table: "NhanVien",
                column: "MaNV");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_LoaiTienNghi_MaLoaiTienNghi",
                table: "LoaiTienNghi",
                column: "MaLoaiTienNghi");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_LoaiPhong_MaLoaiPhong",
                table: "LoaiPhong",
                column: "MaLoaiPhong");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_LoaiDichVu_MaLoaiDichVu",
                table: "LoaiDichVu",
                column: "MaLoaiDichVu");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_KhachHang_MaKH",
                table: "KhachHang",
                column: "MaKH");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_HoaDon_MaHD",
                table: "HoaDon",
                column: "MaHD");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_DichVu_MaDichVu",
                table: "DichVu",
                column: "MaDichVu");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_ChucVu_MaCV",
                table: "ChucVu",
                column: "MaCV");
        }
    }
}
