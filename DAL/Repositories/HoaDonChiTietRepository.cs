using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.IRepositories;
using DAL.Models;

namespace DAL.Repositories
{
    public class HoaDonChiTietRepository : IHoaDonChiTietRepository
    {
        private QLKS_DA1_DbContext _dbContext;

        public HoaDonChiTietRepository()
        {
            _dbContext = new QLKS_DA1_DbContext();
        }
        public bool Add(HoaDonChiTiet obj)
        {
            try
            {
                if (obj == null)
                {
                    return false;
                }
                else
                {
                    _dbContext.HoaDonChiTiets.Add(obj);
                    _dbContext.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {

                return false;
            }
       
        }

        public List<HoaDonChiTiet> GetAll()
        {
            return _dbContext.HoaDonChiTiets.ToList();
        }

        public bool Remove(HoaDonChiTiet obj)
        {
            try
            {
                if (obj == null)
                {
                    return false;
                }
                else
                {
                    var hdct = _dbContext.HoaDonChiTiets.ToList().FirstOrDefault(p => p.IdHoaDon == obj.IdHoaDon);
                    _dbContext.HoaDonChiTiets.Remove(hdct);
                    _dbContext.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool Upadate(HoaDonChiTiet obj)
        {
            //try
            //{
            //    if (obj == null)
            //    {
            //        return false;
            //    }
            //    else
            //    {
            //        var hdct = _dbContext.HoaDonChiTiets.ToList().FirstOrDefault(p => p.IdHoaDon == obj.IdHoaDon);
            //        hdct.SoLuong = obj.SoLuong;
            //        hdct.DonGia = obj.DonGia;
            //        hdct.IdDichVu = obj.IdDichVu;
            //        _dbContext.HoaDonChiTiets.Update(hdct);
            //        _dbContext.SaveChanges();
            //        return true;
            //    }
            //}
            //catch (Exception)
            //{

            //    return false;
            //}

            if (obj == null)
            {
                return false;
            }
            else
            {
                var hdct = _dbContext.HoaDonChiTiets.ToList().FirstOrDefault(p => p.IdHoaDon == obj.IdHoaDon && p.IdDichVu == obj.IdDichVu);
                hdct.SoLuong = obj.SoLuong;
                hdct.DonGia = obj.DonGia;
                //hdct.IdDichVu = obj.IdDichVu;
                _dbContext.HoaDonChiTiets.Update(hdct);
                _dbContext.SaveChanges();
                return true;
            }
        }
    }
}
