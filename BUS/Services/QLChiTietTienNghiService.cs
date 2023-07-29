using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BUS.IServices;
using BUS.ViewModels;
using DAL.Repositories;
using DAL.IRepositories;
using DAL.Models;
namespace BUS.Services
{
    public class QLChiTietTienNghiService : IQLChiTietTienNghiService
    {
        private IChiTietTienNghiRepository _chiTienNghiRepository;
        private ILoaiTienNghiRepository _loaitnRepos;
        private IPhongRepository _PhongRepos;
        public QLChiTietTienNghiService()
        {
            _chiTienNghiRepository = new ChiTietTienNghiRepository();
            _loaitnRepos = new LoaiTienNghiRepository();
            _PhongRepos = new PhongRepository();
        }
        public string Add(ChiTietTienNghiView obj)
        {
            try
            {
                if (obj == null)
                {
                    return "Không có đối tượng để thêm";
                }
                else
                {
                    var cttn = new ChiTietTienNghi()
                    {
                        ID = obj.ID,
                        MaCTTienNghi = obj.MaCTTienNghi,
                        IdPhong = obj.IdPhong,
                        TenCTTienNghi = obj.TenCTTienNghi,
                        IDLoaiTienNghi = obj.IDLoaiTienNghi,

                    };
                    if (_chiTienNghiRepository.Add(cttn))
                    {
                        return "Thêm tiện nghi thành công";
                    }
                    else
                    {
                        return "Thêm tiện nghi thất bại";
                    }

                };
            }
            catch (Exception)
            {

                return "Thêm tiện nghi thất bại";
            }
        }
        
        public List<ChiTietTienNghiView> GetAll()
        {
            List<ChiTietTienNghiView> lst = new List<ChiTietTienNghiView>();
            lst = (from a in _chiTienNghiRepository.GetAll()
                   join b in _loaitnRepos.GetAll() on a.IDLoaiTienNghi equals b.ID
                   join c in _PhongRepos.GetAll() on a.IdPhong equals c.Id
                   select new ChiTietTienNghiView
                   {
                       ID = a.ID,
                       MaCTTienNghi = a.MaCTTienNghi,
                       IdPhong = a.IdPhong,
                       TenCTTienNghi = a.TenCTTienNghi,
                       IDLoaiTienNghi = a.IDLoaiTienNghi,
                       TenLoaiTienNghi = b.TenLoaiTienNghi,
                       MaPhong = c.MaPhong
                       //MaPhong = _PhongRepos.GetAll().Where(p => p.Id == a.IdPhong).Select(p => p.MaPhong)
                   }).ToList();

            List<ChiTietTienNghiView> lstEmpty = new List<ChiTietTienNghiView>();
            lstEmpty = (from a in _chiTienNghiRepository.GetAll()
                   join b in _loaitnRepos.GetAll() on a.IDLoaiTienNghi equals b.ID
                   where a.IdPhong == null
                   select new ChiTietTienNghiView
                   {
                       ID = a.ID,
                       MaCTTienNghi = a.MaCTTienNghi,
                       IdPhong = a.IdPhong,
                       TenCTTienNghi = a.TenCTTienNghi,
                       IDLoaiTienNghi = a.IDLoaiTienNghi,
                       TenLoaiTienNghi = b.TenLoaiTienNghi
                   }).ToList();

            List<ChiTietTienNghiView> lstALl = new List<ChiTietTienNghiView>();
            foreach (var item in lst)
            {
                lstALl.Add(item);
            }
            foreach (var item in lstEmpty)
            {
                lstALl.Add(item);
            }
            return lstALl.ToList();
        }

        public List<CTTNTrongView> GetEmptyCTTN()
        {
            List<CTTNTrongView> lst = new List<CTTNTrongView>();
            lst = (from a in _chiTienNghiRepository.GetAll()
                   join b in _loaitnRepos.GetAll() on a.IDLoaiTienNghi equals b.ID
                   select new CTTNTrongView()
                   {
                       ID = a.ID,
                       MaCTTienNghi = a.MaCTTienNghi,
                       
                       TenCTTienNghi = a.TenCTTienNghi,
                       IDLoaiTienNghi = a.IDLoaiTienNghi,
                       TenLoaiTienNghi = b.TenLoaiTienNghi,
                       IdPhong = a.IdPhong
                   }).ToList();
            var lstEmpty = lst.Where( p => p.IdPhong == null);
            return lstEmpty.ToList();
        }

        public List<ChiTietTienNghiView> GetListCTTNRoom(Guid IdRoom)
        {
            List<ChiTietTienNghiView> lst = new List<ChiTietTienNghiView>();
            lst = (from a in _chiTienNghiRepository.GetAll()
                   join b in _loaitnRepos.GetAll() on a.IDLoaiTienNghi equals b.ID
                   join c in _PhongRepos.GetAll() on a.IdPhong equals c.Id
                   //where a.IdPhong == IdRoom
                   select new ChiTietTienNghiView
                   {
                       ID = a.ID,
                       MaCTTienNghi = a.MaCTTienNghi,
                       IdPhong = a.IdPhong,
                       TenCTTienNghi = a.TenCTTienNghi,
                       IDLoaiTienNghi = a.IDLoaiTienNghi,
                       TenLoaiTienNghi = b.TenLoaiTienNghi,
                       MaPhong = c.MaPhong
                   }).ToList();
             return lst.Where(p => p.IdPhong == IdRoom).ToList();
            //return lst.Where(p => p.IdPhong == Guid.Parse("86393AF9-2C4F-43C5-861C-1605E3B96938")).ToList();
            //return lst;
        }

        public string Remove(ChiTietTienNghiView obj)
        {
            try
            {
                if (obj == null)
                {
                    return "Không có đối tượng để xóa";
                }
                else
                {
                    var tn = _chiTienNghiRepository.GetAll().FirstOrDefault(a => a.ID == obj.ID);
                    if (_chiTienNghiRepository.Remove(tn))
                    {
                        return "Xóa tiện nghi thành công";
                    }
                    else
                    {
                        return "Xóa tiện nghi thất bại";
                    }

                }
            }
            catch (Exception)
            {

                return "Xóa tiện nghi thất bại";
            }
        }

        public List<ChiTietTienNghiView> Search(string name)
        {
            var cttn = GetAll().Where(a => a.TenCTTienNghi.Contains(name)).ToList();
            return cttn;
        }

        public string Update(ChiTietTienNghiView obj)
        {
            try
            {
                if (obj == null)
                {
                    return "Không tìm được đối tượng để sửa";
                }
                else
                {
                    var ltn = _chiTienNghiRepository.GetAll().FirstOrDefault(a => a.ID == obj.ID);
                    ltn.MaCTTienNghi = obj.MaCTTienNghi;
                    ltn.IdPhong = obj.IdPhong;
                    ltn.TenCTTienNghi = obj.TenCTTienNghi;
                    ltn.IDLoaiTienNghi = obj.IDLoaiTienNghi;
                    if (_chiTienNghiRepository.Upadate(ltn))
                    {
                        return "Sửa thông tin tiện nghi thành công";
                    }
                    else
                    {
                        return "Sửa thông tin thất bại, vui lòng thử lại";
                    }
                };
            }
            catch (Exception)
            {

                return "Sửa thông tin thất bại, vui lòng thử lại";
            }
        }

        public Guid GetIdByRoomCode(string roomCode)
        {
       
                var phong = _PhongRepos.GetAll().FirstOrDefault(p => p.MaPhong == roomCode);
                return phong.Id;
        }
    }
}
