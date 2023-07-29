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
    public class ILoaiPhongService : IQLLoaiPhongService
    {
        ILoaiPhongRepository iLoaiPhongRepository;
        public ILoaiPhongService()
        {
            iLoaiPhongRepository = new LoaiPhongRepository();
        }

        public string Add(LoaiPhongView loaiPhongView)
        {
            try
            {
                if (loaiPhongView == null) return "Không có đối tượng truyền vào";
                var LoaiPhong = new LoaiPhong()
                {
                    ID = loaiPhongView.ID,
                    MaLoaiPhong = loaiPhongView.MaLoaiPhong,
                    TenLoaiPhong = loaiPhongView.TenLoaiPhong,
                    GiaNgay = loaiPhongView.GiaNgay,
                    SoGiuong = loaiPhongView.SoGiuong,
                };
                if (iLoaiPhongRepository.Add(LoaiPhong))
                {
                    return "Thêm  thành công";
                }
                else
                {
                    return "Thêm không thành công";
                }
            }
            catch (Exception)
            {

                return "Thêm không thành công";
            }
            
        }

        public List<LoaiPhongView> GetAll()
        {
            List<LoaiPhongView> _list = new List<LoaiPhongView>();
            _list=(from a in iLoaiPhongRepository.GetAll()
                   select new LoaiPhongView
                   {
                       ID = a.ID,
                       MaLoaiPhong=a.MaLoaiPhong,
                       TenLoaiPhong=a.TenLoaiPhong,
                       SoGiuong=a.SoGiuong,
                       GiaNgay=a.GiaNgay
                   }).ToList();
            return _list;
        }

        public string Remove(LoaiPhongView loaiPhongView)
        {
            try
            {
                if (loaiPhongView == null) return "Không có đối tượng truyền vào";
                var loaiPhong = iLoaiPhongRepository.GetAll().FirstOrDefault(c => c.ID == loaiPhongView.ID);
                if (iLoaiPhongRepository.Remove(loaiPhong)) return "Xóa thành công";
                else
                {
                    return "Xóa không thành công";
                }
            }
            catch (Exception)
            {

                return "Xóa không thành công";
            }
            
        }

        public List<LoaiPhongView> Search(string TenLoaiPhong)
        {
            var lstSearch = GetAll().Where(p => p.TenLoaiPhong.Contains(TenLoaiPhong));
            return lstSearch.ToList();
        }

        public string Update(LoaiPhongView loaiPhongView)
        {
            try
            {
                if (loaiPhongView == null) return "không có đối tượng truyền vào";
                var loaiPhong = new LoaiPhong()
                {
                    ID = loaiPhongView.ID,
                    MaLoaiPhong = loaiPhongView.MaLoaiPhong,
                    TenLoaiPhong = loaiPhongView.TenLoaiPhong,
                    GiaNgay = loaiPhongView.GiaNgay,
                    SoGiuong = loaiPhongView.SoGiuong,
                };
                if (iLoaiPhongRepository.Upadate(loaiPhong))
                {
                    return "Sửa thành công";
                }
                else
                {
                    return "Sửa Không thành công";
                }
            }
            catch (Exception)
            {

                return "Sửa Không thành công";
            }
        }
    }
}
