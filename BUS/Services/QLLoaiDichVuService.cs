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
    public class QLLoaiDichVuService : IQLLoaiDichVuService
    {
        private ILoaiDichVuRepository _iLoaiDichVuRepository;
        private List<LoaiDichVuView> _list;
        public QLLoaiDichVuService()
        {
            _iLoaiDichVuRepository = new LoaiDichVuRepository();
            _list = new List<LoaiDichVuView>();
        }
        public string Add(LoaiDichVuView obj)
        {

            try
            {
                if (obj == null)
                {
                    return "Không tìm dc đối tượng";
                }
                else
                {
                    var LoaiDichVuView = new LoaiDichVu()
                    {
                        ID = obj.ID,
                        MaLoaiDichVu = obj.MaLoaiDichVu,
                        TenLoaiDichVu = obj.TenLoaiDichVu
                    };
                    if (_iLoaiDichVuRepository.Add(LoaiDichVuView))
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

        public string Delete(LoaiDichVuView obj)
        {
            try
            {
                if (obj == null)
                {
                    return "Không có đối tượng truyền vào";
                }
                else
                {
                    var LoaiDichVuView = _iLoaiDichVuRepository.GetAll().FirstOrDefault(c => c.ID == obj.ID);
                    if (_iLoaiDichVuRepository.Remove(LoaiDichVuView))
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


        public List<LoaiDichVuView> GetAll()
        {
            _list = (from a in _iLoaiDichVuRepository.GetAll()
                     select new LoaiDichVuView()
                     {
                         ID = a.ID,
                         MaLoaiDichVu = a.MaLoaiDichVu,
                         TenLoaiDichVu = a.TenLoaiDichVu
                     }).ToList();
            return _list;
        }

        public List<LoaiDichVuView> Sreach(string tukhoa)
        {
            var tk = GetAll().Where(p => p.TenLoaiDichVu.Contains(tukhoa));
            return tk.ToList();
        }

        public string Update(LoaiDichVuView obj)
        {
            try
            {
                if (obj == null)
                {
                    return "Không có đối tượng truyền vào";
                }
                else
                {
                    var LoaiDichVuView = _iLoaiDichVuRepository.GetAll().FirstOrDefault(c => c.ID == obj.ID);
                    LoaiDichVuView.MaLoaiDichVu = obj.MaLoaiDichVu;
                    LoaiDichVuView.TenLoaiDichVu = obj.TenLoaiDichVu;
                    if (_iLoaiDichVuRepository.Upadate(LoaiDichVuView))
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
    }
}
