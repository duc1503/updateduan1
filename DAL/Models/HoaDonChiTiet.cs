using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class HoaDonChiTiet
    {
        public Guid IdDichVu { get; set; }
        public Guid IdHoaDon { get; set; }
        public int SoLuong { get; set; }
        public int DonGia { get; set; }
        public virtual HoaDon HoaDon { get; set; }
        public virtual DichVu DichVu { get; set; }
    }
}
