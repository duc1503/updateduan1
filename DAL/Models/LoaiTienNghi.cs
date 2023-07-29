using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class LoaiTienNghi
    {
        public Guid ID { get; set; }
        public string MaLoaiTienNghi { get; set; }
        public string TenLoaiTienNghi { get; set; }
    }
}
