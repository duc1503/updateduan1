using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BUS.IServices;
using BUS.Ultilities;
using BUS.ViewModels;
using DAL.IRepositories;
using DAL.Models;
using DAL.Repositories;

namespace BUS.Services
{
    public class ChucVuService : IChucVuService
    {
        private IChucVuRepository _chucVuRepository;
        private Validations _validations;
        public ChucVuService()
        {
            _chucVuRepository = new ChucVuRepository();
            _validations = new Validations();
        }
        private string Validate(ChucVuView obj)
        {
            if (_validations.CheckRong(obj.MaCV)==false) return "Nhập đầy đủ dữ liệu";
            if (_validations.CheckRong(obj.TenCV)==false) return "Nhập đầy đủ dữ liệu";
            return string.Empty;
        }
        private ChucVu GetChucVu(ChucVuView obj)
        {
            return new ChucVu()
            {
                ID = obj.ID,
                MaCV = obj.MaCV,
                TenCV = obj.TenCV,
            };
        }
        public string Add(ChucVuView obj)
        {
            try
            {
                string a = Validate(obj);
                if (a != string.Empty) return a;
                var temp = _chucVuRepository.GetAll().FindIndex(c => c.MaCV == obj.MaCV);
                if (temp != -1) return "Đã có mã Chức Vụ này";
                if (_chucVuRepository.Add(GetChucVu(obj))) return "Thêm thành công";
                return "Thêm không thành công";
            }
            catch (Exception)
            {

                return "Thêm không thành công";
            }
        }

        public List<ChucVuView> GetAll()
        {
            List<ChucVuView> _lst = new List<ChucVuView>();
            _lst = (from a in _chucVuRepository.GetAll()
                   select new ChucVuView()
                   {
                       ID = a.ID,
                       MaCV = a.MaCV,
                       TenCV=a.TenCV,
                   }).ToList();
            return _lst;
        }
        public string Remove(ChucVuView obj)
        {
            try
            {
                var temp = _chucVuRepository.GetAll().FindIndex(c => c.ID == obj.ID);
                if (temp == -1) return "Không tìm thấy";
                if (_chucVuRepository.Remove(GetChucVu(obj))) return "Xóa thành công";
                return "Xóa không thành công";
            }
            catch (Exception)
            {

                return "Xóa không thành công";
            }
        }

        public string Update(ChucVuView obj)
        {
            try
            {
                string a = Validate(obj);
                if (a != string.Empty) return a;
                var temp = _chucVuRepository.GetAll().FindIndex(c => c.ID == obj.ID);
                if (temp == -1) return "Không tìm thấy";
                var temp1 = _chucVuRepository.GetAll().Where(c => c.ID != obj.ID).ToList();
                if (temp1.FindIndex(c => c.MaCV == obj.MaCV) != -1) return "Đã có mã Chức Vụ này";
                if (_chucVuRepository.Upadate(GetChucVu(obj))) return "Sửa thành công";
                return "Sửa không thành công";
            }
            catch (Exception)
            {

                return "Sửa không thành công";
            }
        }
        public List<ChucVuView> GetList(string obj)
        {
            if (obj == string.Empty) return GetAll();
            return GetAll().Where(c => c.MaCV.Contains(obj)).ToList();
        }
    }
}
