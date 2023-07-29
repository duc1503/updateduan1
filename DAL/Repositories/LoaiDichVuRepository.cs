using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.IRepositories;
using DAL.Models;

namespace DAL.Repositories
{
    public class LoaiDichVuRepository : ILoaiDichVuRepository
    {
        private QLKS_DA1_DbContext _dbContext;
        public LoaiDichVuRepository()
        {
            _dbContext = new QLKS_DA1_DbContext();
        }
        public bool Add(LoaiDichVu obj)
        {
            try
            {
                if (obj == null) return false;

                _dbContext.LoaiDichVus.Add(obj);
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
            
        }

        public List<LoaiDichVu> GetAll()
        {
            return _dbContext.LoaiDichVus.ToList();
        }

        public bool Remove(LoaiDichVu obj)
        {
            try
            {
                if (obj == null) return false;
                var temobj = _dbContext.LoaiDichVus.FirstOrDefault(c => c.ID == obj.ID);
                _dbContext.LoaiDichVus.Remove(temobj);
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool Upadate(LoaiDichVu obj)
        {
            try
            {
                if (obj == null) return false;
                var temobj = _dbContext.LoaiDichVus.FirstOrDefault(c => c.ID == obj.ID);
                temobj.MaLoaiDichVu = obj.MaLoaiDichVu;
                temobj.TenLoaiDichVu = obj.TenLoaiDichVu;
                _dbContext.LoaiDichVus.Update(temobj);
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
