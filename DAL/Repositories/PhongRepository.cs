using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.IRepositories;
using DAL.Models;

namespace DAL.Repositories
{
    public class PhongRepository : IPhongRepository
    {
        private QLKS_DA1_DbContext _Db;
        public PhongRepository()
        {
            _Db = new QLKS_DA1_DbContext();
        }
        public bool Add(Phong obj)
        {
            try
            {
                if (obj == null)
                {
                    return false;
                }
                obj.Id = Guid.NewGuid();
                _Db.Add(obj);
                _Db.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public List<Phong> GetAll()
        {
            return _Db.Phongs.ToList();
        }

        public bool Remove(Phong obj)
        {
            try
            {
                if (obj == null)
                {
                    return false;
                }
                var phong = GetAll().FirstOrDefault(a => a.Id == obj.Id);
                _Db.Remove(phong);
                _Db.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool Upadate(Phong obj)
        {
            try
            {
                if (obj == null)
                {
                    return false;
                }
                var x = _Db.Phongs.FirstOrDefault(a => a.Id == obj.Id);
                x.MaPhong = obj.MaPhong;
                x.TinhTrang = obj.TinhTrang;
                x.IDLoaiPhong = obj.IDLoaiPhong;

                _Db.Update(x);
                _Db.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool UpdateTrangThaiPhong(Phong obj)
        {
            try
            {
                if (obj == null)
                {
                    return false;
                }
                var x = _Db.Phongs.FirstOrDefault(a => a.Id == obj.Id);
                x.TinhTrang = obj.TinhTrang;
                _Db.Update(x);
                _Db.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
