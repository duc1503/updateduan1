using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;
using BUS.ViewModels;
using BUS.IServices;
using DAL.IRepositories;
using DAL.Repositories;

namespace BUS.Services
{
    public class QLDichVuService : IQLDichVuService
    {
        private IDichVuRepository _iDichVuRepository;
        private ILoaiDichVuRepository _iLoaiDichVuRepository;
        private List<DichVuView> _list;
        public QLDichVuService()
        {
            _iDichVuRepository = new DichVuRepository();
            _iLoaiDichVuRepository = new LoaiDichVuRepository();
            _list = new List<DichVuView>();
        }
        public string Add(DichVuView obj)
        {
            try
            {
                if (obj == null)
                {
                    return "Không tìm dc đối tượng";
                }
                else
                {
                    var DichVuView = new DichVu()
                    {
                        Id = obj.Id,
                        IDLoaiDichVu = obj.IDLoaiDichVu,
                        TenDichVu = obj.TenDichVu,
                        MaDichVu = obj.MaDichVu,
                        Gia = obj.Gia
                    };
                    if (_iDichVuRepository.Add(DichVuView))
                    {
                        return "Thêm thành công";
                    }
                    else
                    {
                        return "Thêm thất bại";
                    }
                }
            }
            catch (Exception)
            {

                return "Thêm thất bại";
            }
        }

        public string Delete(DichVuView obj)
        {
            try
            {
                if (obj == null)
                {
                    return "Không có đối tượng truyền vào";
                }
                else
                {
                    var DichVuView = _iDichVuRepository.GetAll().FirstOrDefault(c => c.Id == obj.Id);
                    if (_iDichVuRepository.Remove(DichVuView))
                    {
                        return "Xóa thành công";
                    }
                    else
                    {
                        return "Xóa thất bại";
                    }
                }
            }
            catch (Exception)
            {

                return "Xóa thất bại";
            }
        }

        public List<DichVuView> GetAll()
        {
            _list = (from a in _iDichVuRepository.GetAll()
                     join b in _iLoaiDichVuRepository.GetAll() on a.IDLoaiDichVu equals b.ID
                     select new DichVuView()
                     {
                         Id = a.Id,
                         IDLoaiDichVu = b.ID,
                         TenLoaiDV = b.TenLoaiDichVu,
                         MaDichVu = a.MaDichVu,
                         TenDichVu = a.TenDichVu,
                         Gia = a.Gia
                     }).ToList();
            return _list;
        }

        public List<DichVuView> Sreach(string tukhoa)
        {
            var tk = GetAll().Where(p => p.TenDichVu.Contains(tukhoa));
            return tk.ToList();
        }

        public string Update(DichVuView obj)
        {
            try
            {
                if (obj == null)
                {
                    return "Không có đối tượng truyền vào";
                }
                else
                {
                    var DichVuView = _iDichVuRepository.GetAll().FirstOrDefault(c => c.Id == obj.Id);
                    DichVuView.IDLoaiDichVu = obj.IDLoaiDichVu;
                    DichVuView.TenDichVu = obj.TenDichVu;
                    DichVuView.MaDichVu = obj.MaDichVu;
                    DichVuView.Gia = obj.Gia;
                    if (_iDichVuRepository.Upadate(DichVuView))
                    {
                        return "Sửa thành công";
                    }
                    else
                    {
                        return "Sửa thất bại";
                    }
                }
            }
            catch (Exception)
            {

                return "Sửa thất bại";
            }
        }

     
        public Guid GetIdDvByName(string name)
        {
            var dv = _iDichVuRepository.GetAll().FirstOrDefault(p => p.TenDichVu == name);
            return dv.Id;
        }
    }
}
