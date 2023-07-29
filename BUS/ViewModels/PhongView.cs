using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.ViewModels
{
    public class PhongView
    {
        public Guid Id { get; set; }
        public string MaPhong { get; set; }
        public int TinhTrang { get; set; }
        public Guid IDLoaiPhong { get; set; }
  

        public string TenLoaiPhong { get; set; }
        public int Gia { get; set; }
    }
}
