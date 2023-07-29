using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class NhanVien
    {
        public Guid ID { get; set; }

       
        public string MaNV { get; set; }
        public string TenNV { get; set; }
        public DateTime NgaySinh { get; set; }
        public int GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public string SDT { get; set; }
        public string CCCD { get; set; }
        public int Luong { get; set; }

        // foreign key
        public Guid IDCv { get; set; }
        public virtual ChucVu ChucVu { get; set; }

        public TaiKhoan TaiKhoan { get; set; }

    }
}
