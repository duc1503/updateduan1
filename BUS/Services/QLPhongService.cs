using BUS.IServices;
using BUS.ViewModels;
using DAL.IRepositories;
using DAL.Models;
using DAL.Repositories;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class IPhongService : IQLPhongService
    {
        ILoaiPhongRepository iLoaiPhongRepository;
        IPhongRepository iPhongRepository;
        IChiTietTienNghiRepository iChiTietTienNghiRepository;
        public IPhongService()
        {
            iPhongRepository = new PhongRepository();
            iLoaiPhongRepository = new LoaiPhongRepository();
            iChiTietTienNghiRepository = new ChiTietTienNghiRepository();
        }
        public string Add(PhongView obj)
        {
            try
            {
                if (obj == null)
                {
                    return "Không có đối tượng truyền vào";
                }
                else
                {
                    var phong = new Phong
                    {
                        //Id = obj.Id,
                        MaPhong = obj.MaPhong,
                        TinhTrang = obj.TinhTrang,
                        IDLoaiPhong = obj.IDLoaiPhong,

                    };
                    if (iPhongRepository.Add(phong))
                    {
                        return "Thêm phòng thành công";
                    }
                    else
                    {
                        return "Thêm phòng không thành công";
                    };
                }
            }
            catch (Exception)
            {

                return "Thêm phòng không thành công";
            }
        }
        
        public List<PhongView> GetAll()
        {
            List<PhongView> _list = new List<PhongView>();
            _list = (from a in iPhongRepository.GetAll()
                  
                     join b in iLoaiPhongRepository.GetAll() on a.IDLoaiPhong equals b.ID
                     select new PhongView
                     {
                         Id = a.Id,
                         MaPhong = a.MaPhong,
                         TinhTrang = a.TinhTrang,
                         IDLoaiPhong = a.IDLoaiPhong,
                         Gia = b.GiaNgay,
                         TenLoaiPhong = b.TenLoaiPhong,
                        
                     }).ToList();
            return _list;

        }


        public string Remove(PhongView obj)
        {
            try
            {
                if (obj == null) return "Không có đối tượng truyền vào";
                var phong = iPhongRepository.GetAll().FirstOrDefault(c => c.Id == obj.Id);
                if (iPhongRepository.Remove(phong))
                {
                    return "Xóa phòng thành công";
                }
                else
                {
                    return "Xóa phòng không thành công";
                }
            }
            catch (Exception)
            {

                return "Xóa phòng không thành công";
            }
        }

        public string Update(PhongView obj)
        {
            try
            {
                if (obj == null) return "Không có đối tượng truyền vào";
                var phong = new Phong()
                {
                    Id = obj.Id,
                    MaPhong = obj.MaPhong,
                    IDLoaiPhong = obj.IDLoaiPhong,

                    TinhTrang = obj.TinhTrang
                };
                if (iPhongRepository.Upadate(phong))
                {
                    return "Sửa Phòng thành công";
                }
                else
                {
                    return "Sửa Phòng không thành công";
                }
            }
            catch (Exception)
            {

                return "Sửa Phòng không thành công";
            }

        }

        public Guid GetIdLoaiPhongByName(string Name)
        {
            var phong = iLoaiPhongRepository.GetAll().FirstOrDefault(p => p.TenLoaiPhong == Name);
            return phong.ID;
        }

        public List<PhongView> Search(string name)
        {
            var lst = GetAll().Where(p => p.MaPhong.Contains(name));
            return lst.ToList();
        }

        public string UpdateTrangThaiPhong(PhongView phongView)
        {
            try
            {
                if (phongView == null) return "Không có đối tượng truyền vào";
                var phong = new Phong()
                {
                    Id = phongView.Id,
                    TinhTrang = phongView.TinhTrang
                };
                if (iPhongRepository.Upadate(phong))
                {
                    return "Sửa tT Phòng thành công";
                }
                else
                {
                    return "Sửa tt Phòng không thành công";
                }
            }
            catch (Exception)
            {

                return "Sửa tt Phòng không thành công";
            }
        }
    }
}
