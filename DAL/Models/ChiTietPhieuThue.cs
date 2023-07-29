using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class ChiTietPhieuThue
    {
        public Guid ID { get; set; }
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }
        public Guid IdPhieuThue { get; set; }
        public Guid IdPhong { get; set; }
        //public string MaCTPT { get; set; }

        public virtual Phong Phong { get; set; }
        public virtual PhieuThue PhieuThue { get; set; }

        public virtual HoaDon HoaDon { get; set; }
    }
}
