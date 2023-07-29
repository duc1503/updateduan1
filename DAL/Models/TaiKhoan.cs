using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class TaiKhoan
    {
        public Guid ID { get; set; }
        public string TenTaiKhoan { get; set; }
        public string MatKhau { get; set; }
        public int CapDoQuyen { get; set; }
        public Guid? IDNv { get; set; }
        public virtual NhanVien? NhanVien { get; set; }
    }
}
