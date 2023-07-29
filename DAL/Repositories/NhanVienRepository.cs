using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.IRepositories;
using DAL.Models;

namespace DAL.Repositories
{
    public class NhanVienRepository : INhanVienRepository
    {
        private QLKS_DA1_DbContext _dbContext;
        public NhanVienRepository()
        {
            _dbContext = new QLKS_DA1_DbContext();  
        }
        public bool Add(NhanVien obj)
        {
            try
            {
                if (obj == null) return false;
                obj.ID = Guid.NewGuid();
                _dbContext.NhanViens.Add(obj);
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public List<NhanVien> GetAll()
        {
            return _dbContext.NhanViens.ToList();
        }

        public bool Remove(NhanVien obj)
        {
            try
            {
                if (obj == null) return false;
                var temobj = _dbContext.NhanViens.FirstOrDefault(c => c.ID == obj.ID);
                _dbContext.NhanViens.Remove(temobj);
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool Upadate(NhanVien obj)
        {
            try
            {
                if (obj == null) return false;
                var temobj = _dbContext.NhanViens.FirstOrDefault(c => c.ID == obj.ID);
                temobj.IDCv = obj.IDCv;
                temobj.MaNV = obj.MaNV;
                temobj.TenNV = obj.TenNV;
                temobj.SDT = obj.SDT;
                temobj.CCCD = obj.CCCD;
                temobj.NgaySinh = obj.NgaySinh;
                temobj.GioiTinh = obj.GioiTinh;
                temobj.DiaChi = obj.DiaChi;
                temobj.Luong = obj.Luong;
                _dbContext.NhanViens.Update(temobj);
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
