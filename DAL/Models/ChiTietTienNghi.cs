using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class ChiTietTienNghi
    {
        public Guid ID { get; set; }
        public string MaCTTienNghi { get; set; }
        public string TenCTTienNghi { get; set; }

        public Guid IDLoaiTienNghi { get; set; }

        public Guid? IdPhong { get; set; }

        public virtual LoaiTienNghi LoaiTienNghi { get; set; }
        public virtual Phong? Phong { get; set; }
    }
}
