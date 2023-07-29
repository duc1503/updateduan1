using BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IServices
{
    public interface IQLHoaDonChiTietView
    {
        List<HoaDonChiTietView> GetAll();
        List<HoaDonChiTietView> Search();
        string Add(HoaDonChiTietView hdctv);
        string Remove(HoaDonChiTietView hdctv);
        string Update(HoaDonChiTietView hdctv);
    }
}
