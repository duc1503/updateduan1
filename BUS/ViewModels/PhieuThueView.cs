using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.ViewModels
{
    public class PhieuThueView
    {
        public Guid ID { get; set; }
        public DateTime NgayLapPhieu { get; set; }
        public Guid IdKH { get; set; }
        public Guid? IdNV { get; set; }

        public string TenKH { get; set; }
        public string TenNV { get; set; }
        public int MaPhieuThue { get; set; }
    }
}
