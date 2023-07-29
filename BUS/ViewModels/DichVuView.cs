using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.ViewModels
{
    public class DichVuView
    {
        public Guid Id { get; set; }
        public string MaDichVu { get; set; }
        public string TenDichVu { get; set; }
        public int Gia { get; set; }

        public Guid IDLoaiDichVu { get; set; }

        public string TenLoaiDV { get; set; }
       // public int SoLuong { get; set; }
    }
}
