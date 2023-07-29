using BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IServices
{
    public interface IQLLoaiPhongService
    {
        List<LoaiPhongView> GetAll();
        List<LoaiPhongView> Search(string TenLoaiPhong);
        string Add(LoaiPhongView loaiPhongView);
        string Remove(LoaiPhongView loaiPhongView);
        string Update(LoaiPhongView loaiPhongView);

    }
}
