using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.IRepositories;
using DAL.Models;

namespace DAL.Repositories
{
    public class ChiTietPhieuThueRepository : IChiTietPhieuThueRepository
    {
        private QLKS_DA1_DbContext _DbContext;

        public ChiTietPhieuThueRepository()
        {
            _DbContext = new QLKS_DA1_DbContext();

        }
        public bool Add(ChiTietPhieuThue obj)
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
                    _DbContext.ChiTietPhieuThues.Add(obj);
                    _DbContext.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {

                return false;
            }
        }

        public List<ChiTietPhieuThue> GetAll()
        {
            return _DbContext.ChiTietPhieuThues.ToList();
        }

        public bool Remove(ChiTietPhieuThue obj)
        {
            try
            {
                if (obj == null)
                {
                    return false;
                }
                else
                {
                    var ctpt = _DbContext.ChiTietPhieuThues.ToList().FirstOrDefault(p => p.ID == obj.ID);
                    _DbContext.ChiTietPhieuThues.Remove(ctpt);
                    _DbContext.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {

                return false;
            }
            
        }

        public bool Upadate(ChiTietPhieuThue obj)
        {
            try
            {
                if (obj == null)
                {
                    return false;
                }
                else
                {
                    var ctpt = _DbContext.ChiTietPhieuThues.ToList().FirstOrDefault(p => p.ID == obj.ID);
                    ctpt.IdPhieuThue = obj.IdPhieuThue;
                    ctpt.IdPhong = obj.IdPhong;
                    ctpt.NgayBatDau = obj.NgayBatDau;
                    ctpt.NgayKetThuc = obj.NgayKetThuc;
                    _DbContext.ChiTietPhieuThues.Update(ctpt);
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
