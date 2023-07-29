using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.IRepositories;
using DAL.Models;
namespace DAL.Repositories
{
    public class LoaiPhongRepository : ILoaiPhongRepository
    {
        private QLKS_DA1_DbContext _Db;
        public LoaiPhongRepository()
        {
            _Db = new QLKS_DA1_DbContext();
        }
        public bool Add(LoaiPhong obj)
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

        public List<LoaiPhong> GetAll()
        {
            return _Db.LoaiPhongs.ToList();
        }

        public bool Remove(LoaiPhong obj)
        {
            try
            {
                if (obj == null)
                {
                    return false;
                }
                var loaiphong = GetAll().FirstOrDefault(a => a.ID == obj.ID);
                _Db.Remove(loaiphong);
                _Db.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
           
        }

        public bool Upadate(LoaiPhong obj)
        {
            try
            {
                if (obj == null)
                {
                    return false;
                }
                var x = _Db.LoaiPhongs.FirstOrDefault(a => a.ID == obj.ID);
                x.MaLoaiPhong = obj.MaLoaiPhong;
                x.TenLoaiPhong = obj.TenLoaiPhong;
                x.SoGiuong = obj.SoGiuong;
                x.GiaNgay = obj.GiaNgay;
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
