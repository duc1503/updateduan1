using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class LoaiDichVu
    {
        public Guid ID { get; set; }
        public string MaLoaiDichVu { get; set; }
        public string TenLoaiDichVu { get; set; }
    }
}
