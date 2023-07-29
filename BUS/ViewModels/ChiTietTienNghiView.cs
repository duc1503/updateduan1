using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.ViewModels
{
    public class ChiTietTienNghiView
    {
        public Guid ID { get; set; }
        public string MaCTTienNghi { get; set; }
        public string TenCTTienNghi { get; set; }

        public Guid IDLoaiTienNghi { get; set; }

        public Guid? IdPhong { get; set; }

        public string TenLoaiTienNghi { get; set; }
        public string? MaPhong { get; set; }
    }
}
