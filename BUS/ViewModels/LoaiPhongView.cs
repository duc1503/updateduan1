using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.ViewModels
{
    public class LoaiPhongView
    {
        public Guid ID { get; set; }
        public string MaLoaiPhong { get; set; }
        public string TenLoaiPhong { get; set; }
        public int SoGiuong { get; set; }
        public int GiaNgay { get; set; }
    }
}
