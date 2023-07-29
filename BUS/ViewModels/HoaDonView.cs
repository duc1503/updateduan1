using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.ViewModels
{
    public class HoaDonView
    {
        // HD
        public Guid Id { get; set; }
        public string MaHD { get; set; }
        public DateTime NgayTaoHD { get; set; }
        public DateTime? NgayTT { get; set; }
        public int TrangThai { get; set; }
        // CTPT
        public Guid IdCTPhieuThue { get; set; }
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }
        // KH
        public Guid IdKH { get; set; }
        public string TenKH { get; set; }
        // NV
        public Guid IdNV { get;set; }
        public string TenNV { get; set; }
        // Phong
        public Guid IdPhong { get; set; }
        public string MaPhong { get; set; }
        // Loai Phong(Lay gia ngay)
        public int GiaNgay { get; set; }
        public string TenLoaiPhong { get; set; }


        // Có thể bỏ join 2 bảng HDCT và dịch vụ tuy nhiên sẽ cần phải tạo thêm 1 dtg con cho form hóa đơn khi in thông tin ra .
        // khi đó 1 hóa đơn sẽ bao gồm toàn bộ thông tin của 5 bảng trên + thêm 1 dtg để hiển thị HoaDonChiTietView
        // Trong HoaDonChiTietView sẽ hiển thị các dịch vụ của mỗi phòng đã sử dụng


        // HDCT
        public Guid IdDichVu { get; set; }
        public int SoLuongDichVu { get; set; }
        public int DonGia { get; set; }
        // Dich vu
        public string TenDichVu { get; set; }
        public int TongTien { get; set; }
    }
}
