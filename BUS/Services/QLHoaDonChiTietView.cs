using BUS.IServices;
using BUS.ViewModels;
using DAL.IRepositories;
using DAL.Models;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class QLHoaDonChiTietView : IQLHoaDonChiTietView
    {
        private IHoaDonChiTietRepository _ihdctRepos;
        private IHoaDonRepository _ihdRepos;
        private IDichVuRepository _idvRepos;

        public QLHoaDonChiTietView()
        {
            _ihdctRepos = new HoaDonChiTietRepository();
            _ihdRepos = new HoaDonRepository();
            _idvRepos = new DichVuRepository();
        }
        public string Add(HoaDonChiTietView hdctv)
        {
            try
            {
                if (hdctv == null)
                {
                    return "THem that bai";
                }
                else
                {
                    HoaDonChiTiet hdct = new HoaDonChiTiet();
                    hdct.SoLuong = hdctv.SoLuong;
                    hdct.DonGia = hdctv.DonGia;
                    hdct.IdDichVu = hdctv.IdDichVu;
                    hdct.IdHoaDon = hdctv.IdHoaDon;
                    if (_ihdctRepos.Add(hdct))
                    {
                        return "Them thanh cong";
                    }
                    return "THem that bai";
                }
            }
            catch (Exception)
            {

                return "THem that bai";
            }
        }

        public List<HoaDonChiTietView> GetAll()
        {
            List<HoaDonChiTietView> lst = new List<HoaDonChiTietView>();
            lst = (from a in _ihdctRepos.GetAll()
                   join b in _ihdRepos.GetAll() on a.IdHoaDon equals b.Id
                   join c in _idvRepos.GetAll() on a.IdDichVu equals c.Id
                   select new HoaDonChiTietView()
                   {
                       IdHoaDon = b.Id,
                       IdDichVu = c.Id,
                       SoLuong = a.SoLuong,
                       DonGia = a.DonGia,
                       TenDV = c.TenDichVu
                   }
                   ).ToList();
            return lst;
        }

        public string Remove(HoaDonChiTietView hdctv)
        {
            try
            {
                if (hdctv == null)
                {
                    return "THem that bai";
                }
                else
                {
                    var hdct = _ihdctRepos.GetAll().FirstOrDefault(p => p.IdHoaDon == hdctv.IdHoaDon);
                    if (_ihdctRepos.Remove(hdct))
                    {
                        return "Xoa thanh cong";
                    }
                    return "Xoa that bai";
                }
            }
            catch (Exception)
            {

                return "Xoa that bai";
            }
        }

        public List<HoaDonChiTietView> Search()
        {
            throw new NotImplementedException();
        }

        public string Update(HoaDonChiTietView hdctv)
        {
            try
            {
                if (hdctv == null)
                {
                    return "THem that bai";
                }
                else
                {
                    var hdct = _ihdctRepos.GetAll().FirstOrDefault(p => p.IdHoaDon == hdctv.IdHoaDon && p.IdDichVu == hdctv.IdDichVu);
                    hdct.SoLuong = hdctv.SoLuong;
                    hdct.DonGia = hdctv.DonGia;
                    //hdct.IdDichVu = hdctv.IdDichVu;
                    if (_ihdctRepos.Upadate(hdct))
                    {
                        return "Xoa thanh cong";
                    }
                    return "Xoa that bai";
                }
            }
            catch
            {

                return "Xoa that bai";
            }


        }
    }
}
