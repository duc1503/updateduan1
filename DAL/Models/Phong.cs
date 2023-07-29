using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Phong
    {
        public Guid Id { get; set; }
        public string MaPhong { get; set; }
        public int TinhTrang { get; set; }
        public Guid IDLoaiPhong { get; set; }
    
        public virtual LoaiPhong LoaiPhong { get; set; }
        
    }
}
