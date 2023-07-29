using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.IRepositories;
using DAL.Models;

namespace DAL.Repositories
{
    public class PhieuThueRepository : IPhieuThueRepository
    {
        private QLKS_DA1_DbContext _DbContext;

        public PhieuThueRepository()
        {
            _DbContext = new QLKS_DA1_DbContext();
        }
        public bool Add(PhieuThue obj)
        {
            try
            {
                if (obj == null)
                {
                    return false;
                }
                else
                {
                    obj.ID = Guid.NewGuid();
                    _DbContext.PhieuThues.Add(obj);
                    _DbContext.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {

                return false;
            }
        }

        public List<PhieuThue> GetAll()
        {
            return _DbContext.PhieuThues.ToList();
        }

        public bool Remove(PhieuThue obj)
        {
            try
            {
                if (obj == null)
                {
                    return false;
                }
                else
                {
                    var pt = _DbContext.PhieuThues.ToList().FirstOrDefault(p => p.ID == obj.ID);
                    _DbContext.PhieuThues.Remove(pt);
                    _DbContext.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool Upadate(PhieuThue obj)
        {
            try
            {
                if (obj == null)
                {
                    return false;
                }
                else
                {
                    var pt = _DbContext.PhieuThues.ToList().FirstOrDefault(p => p.ID == obj.ID);
                    pt.IdKH = obj.IdKH;
                    pt.IdNV = obj.IdNV;
                    pt.NgayLapPhieu = obj.NgayLapPhieu;
                    _DbContext.PhieuThues.Update(pt);
                    _DbContext.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
