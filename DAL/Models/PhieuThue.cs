using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class PhieuThue
    {
        public Guid ID { get; set; }
        public DateTime NgayLapPhieu { get; set; }
        public Guid? IdKH { get; set; }
        public Guid? IdNV { get; set; }
        public int MaPhieuThue { get; set; }
        public virtual KhachHang? KhachHang { get; set; }
        public virtual NhanVien? NhanVien { get; set; }
    }
}
