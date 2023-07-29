using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class KhachHang
    {
        public Guid ID { get; set; }
        public string MaKH { get; set; }
        public string HovaTen { get; set; }
        public string CCCD { get; set; }
        public string SDT { get; set; }
        public string DiaChi { get; set; }
        public int GioiTinh { get; set; }
        public string QuocTich { get; set; }
    }
}
