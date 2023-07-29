using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.ViewModels
{
    public class HoaDonChiTietView
    {
        public Guid IdDichVu { get; set; }
        public Guid IdHoaDon { get; set; }
        public int SoLuong { get; set; }
        public int DonGia { get; set; }
        public string TenDV { get; set; }

    }
}
