using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class HoaDon
    {
        public Guid Id { get; set; }
        public string MaHD { get; set; }
        public DateTime NgayTaoHD { get; set; }
        public Guid IdCTPhieuThue { get; set; }
        public int TrangThai { get; set; }
        public DateTime? NgayTT { get; set; }
        public virtual ChiTietPhieuThue ChiTietPhieuThue { get; set; }
        
    }
}
