using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.ViewModels
{
    public class ChiTietPhieuThueView
    {
        public Guid ID { get; set; }
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }
        public Guid IdPhieuThue { get; set; }
        public Guid IdPhong { get; set; }
        public DateTime NgayLapPhieu { get; set; }
        public string MaPhong { get; set; }

        public Guid? IdKH { get; set; }
       // public string MaCTPT { get; set; }
    }
}
