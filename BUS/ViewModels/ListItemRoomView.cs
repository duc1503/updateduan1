using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.ViewModels
{
    public class ListItemRoomView
    {
        public Guid IdRoom { get; set; }
        public Guid? IdKH { get; set; }
        //public string? TenKH { get; set; }
        //public string MaPhong { get; set; }
        public string TrangThaiPhongThue { get; set; }// đang thuê/ phòng trống / phòng đã đặt
        public int TrangThaiDonDep { get; set; } // đã dọn dẹp / chưa dọn dẹp / đang sửa chữa
       
        //public Guid IdLoaiPhong { get; set; }
        //public string TenLoaiPhong { get; set; }
    }
}
