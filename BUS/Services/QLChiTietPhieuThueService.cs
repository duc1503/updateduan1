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
    public class QLChiTietPhieuThueService : IQLChiTietPhieuThueService
    {
        private IChiTietPhieuThueRepository _ictptRepos;
        private IPhongRepository _iphongRepos;
        private IPhieuThueRepository _iptRepos;

        public QLChiTietPhieuThueService()
        {
            _ictptRepos = new ChiTietPhieuThueRepository();
            _iphongRepos = new PhongRepository();
            _iptRepos = new PhieuThueRepository();
        }
        public string Add(ChiTietPhieuThueView ctptv)
        {
            try
            {
                if (ctptv == null)
                {
                    return "Đặt phòng thất bại";
                }
                else
                {
                    ChiTietPhieuThue ctpt = new ChiTietPhieuThue();
                    ctpt.NgayBatDau = ctptv.NgayBatDau;
                    ctpt.NgayKetThuc = ctptv.NgayKetThuc;
                    ctpt.IdPhieuThue = ctptv.IdPhieuThue;
                    ctpt.IdPhong = ctptv.IdPhong;
                    // ctpt.MaCTPT = ctptv.MaCTPT;
                    if (_ictptRepos.Add(ctpt))
                    {
                        return "Đặt phòng thành công";
                    }
                    return "Đặt phòng thất bại";
                }
            }
            catch (Exception)
            {
                return "Đặt phòng thất bại";

            }
           
        }

        public List<ChiTietPhieuThueView> GetAll()
        {
            List<ChiTietPhieuThueView> lst = new List<ChiTietPhieuThueView>();
            lst = (from a in _ictptRepos.GetAll()
                   join b in _iphongRepos.GetAll() on a.IdPhong equals b.Id
                   join c in _iptRepos.GetAll() on a.IdPhieuThue equals c.ID
                   select new ChiTietPhieuThueView()
                   {
                       ID = a.ID,
                       NgayBatDau = a.NgayBatDau,
                       NgayKetThuc = a.NgayKetThuc,
                       IdPhieuThue = c.ID,
                       IdPhong = b.Id,
                       NgayLapPhieu = c.NgayLapPhieu,
                       MaPhong = b.MaPhong,
                       IdKH = c.IdKH,
                      // MaCTPT = a.MaCTPT
                      
                   }
                   ).ToList();
            return lst;
        }

        public string Remove(ChiTietPhieuThueView ctptv)
        {
            try
            {
                if (ctptv == null)
                {
                    return "Xoa that bai";
                }
                else
                {
                    var ctpt = _ictptRepos.GetAll().FirstOrDefault(p => p.ID == ctptv.ID);
                    if (_ictptRepos.Remove(ctpt))
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

        public List<ChiTietPhieuThueView> Search()
        {
            throw new NotImplementedException();
        }

        public string Update(ChiTietPhieuThueView ctptv)
        {
            try
            {
                if (ctptv == null)
                {
                    return "Sua that bai";
                }
                else
                {
                    var ctpt = _ictptRepos.GetAll().FirstOrDefault(p => p.ID == ctptv.ID);
                    ctpt.NgayBatDau = ctptv.NgayBatDau;
                    ctpt.NgayKetThuc = ctptv.NgayKetThuc;
                    ctpt.IdPhieuThue = ctptv.IdPhieuThue;
                    ctpt.IdPhong = ctptv.IdPhong;
                    // ctpt.MaCTPT = ctptv.MaCTPT;
                    if (_ictptRepos.Upadate(ctpt))
                    {
                        return "Sua thanh cong";
                    }
                    return "Sua that bai";
                }
            }
            catch (Exception)
            {

                return "Sua that bai";
            }
        }
    }
}
