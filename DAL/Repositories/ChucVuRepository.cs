using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.IRepositories;
using DAL.Models;

namespace DAL.Repositories
{
    public class ChucVuRepository : IChucVuRepository
    {
        private QLKS_DA1_DbContext _db;
        public ChucVuRepository()
        {
            _db = new QLKS_DA1_DbContext();
        }
        public bool Add(ChucVu obj)
        {
            try
            {
                if (obj == null)
                {
                    return false;
                }
                if (_db.ChucVus.FirstOrDefault(c => c.MaCV == obj.MaCV) != null) return false;
                obj.ID = Guid.NewGuid();
                _db.Add(obj);
                _db.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
           
        }

        public List<ChucVu> GetAll()
        {
            return _db.ChucVus.ToList();
        }

        public bool Remove(ChucVu obj)
        {
            try
            {
                if (obj == null)
                {
                    return false;
                }
                var indext = GetAll().FirstOrDefault(c => c.ID == obj.ID);
                if (indext == null) return false;
                _db.Remove(indext);
                _db.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool Upadate(ChucVu obj)
        {
            try
            {
                if (obj == null)
                {
                    return false;
                }
                var indext = GetAll().FirstOrDefault(c => c.ID == obj.ID);
                if (indext == null) return false;
                indext.MaCV = obj.MaCV;
                indext.TenCV = obj.TenCV;
                _db.ChucVus.Update(indext);
                _db.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
