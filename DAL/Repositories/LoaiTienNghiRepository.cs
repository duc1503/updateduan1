using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.IRepositories;
using DAL.Models;

namespace DAL.Repositories
{
    public class LoaiTienNghiRepository : ILoaiTienNghiRepository
    {
        QLKS_DA1_DbContext _Db;
        public LoaiTienNghiRepository()
        {
            _Db = new QLKS_DA1_DbContext();
        }
        public bool Add(LoaiTienNghi obj)
        {
            try
            {
                if (obj == null)
                {
                    return false;
                }

                obj.ID = Guid.NewGuid();
                _Db.Add(obj);
                _Db.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public List<LoaiTienNghi> GetAll()
        {
            return _Db.LoaiTienNghis.ToList();
        }

        public bool Remove(LoaiTienNghi obj)
        {
            try
            {
                if (obj == null)
                {
                    return false;
                }
                var loaiTN = GetAll().FirstOrDefault(a => a.ID == obj.ID);
                _Db.Remove(loaiTN);
                _Db.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool Upadate(LoaiTienNghi obj)
        {
            try
            {
                if (obj == null)
                {
                    return false;
                }
                var x = _Db.LoaiTienNghis.FirstOrDefault(a => a.ID == obj.ID);
                x.MaLoaiTienNghi = obj.MaLoaiTienNghi;
                x.TenLoaiTienNghi = obj.TenLoaiTienNghi;
                _Db.LoaiTienNghis.Update(x);
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
