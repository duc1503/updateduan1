using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.IRepositories;
using DAL.Models;

namespace DAL.Repositories
{
    public class KhachHangRepository : IKhachHangRepository
    {
        private QLKS_DA1_DbContext _dbContext;
        public KhachHangRepository()
        {
            _dbContext = new QLKS_DA1_DbContext();
        }
        public bool Add(KhachHang obj)
        {
            try
            {
                if (obj == null) return false;
                obj.ID = Guid.NewGuid();
                _dbContext.KhachHangs.Add(obj);
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
          
        }

        public List<KhachHang> GetAll()
        {
            return _dbContext.KhachHangs.ToList();
        }

        public bool Remove(KhachHang obj)
        {
            try
            {
                if (obj == null) return false;
                var temobj = _dbContext.KhachHangs.FirstOrDefault(c => c.ID == obj.ID);
                _dbContext.KhachHangs.Remove(temobj);
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;

            }
            //if (obj == null) return false;
            //var temobj = _dbContext.KhachHangs.FirstOrDefault(c => c.ID == obj.ID);
            //_dbContext.KhachHangs.Remove(temobj);
            //_dbContext.SaveChanges();
            //return true;
        }

        public bool Upadate(KhachHang obj)
        {
            try
            {
                if (obj == null) return false;
                var temobj = _dbContext.KhachHangs.FirstOrDefault(c => c.ID == obj.ID);
                temobj.MaKH = obj.MaKH;
                temobj.HovaTen = obj.HovaTen;
                temobj.CCCD = obj.CCCD;
                temobj.SDT = obj.SDT;
                temobj.QuocTich = obj.QuocTich;
                temobj.GioiTinh = obj.GioiTinh;
                temobj.DiaChi = obj.DiaChi;
                _dbContext.KhachHangs.Update(temobj);
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
