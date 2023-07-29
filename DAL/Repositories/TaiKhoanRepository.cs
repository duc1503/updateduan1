using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.IRepositories;
using DAL.Models;

namespace DAL.Repositories
{
    public class TaiKhoanRepository : ITaiKhoanRepository
    {
        private QLKS_DA1_DbContext _DbContext;

        public TaiKhoanRepository()
        {
            _DbContext = new QLKS_DA1_DbContext();
        }
        public bool Add(TaiKhoan obj)
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
                    _DbContext.TaiKhoans.Add(obj);
                    _DbContext.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {

                return false;
            }
        }

        public List<TaiKhoan> GetAll()
        {
            return _DbContext.TaiKhoans.ToList();   
        }

        public bool Remove(TaiKhoan obj)
        {
            try
            {
                if (obj == null)
                {
                    return false;
                }
                else
                {
                    var tk = _DbContext.TaiKhoans.ToList().FirstOrDefault(p => p.ID == obj.ID);
                    _DbContext.TaiKhoans.Remove(tk);
                    _DbContext.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool Update(TaiKhoan obj)
        {
            try
            {
                if (obj == null)
                {
                    return false;
                }
                else
                {
                    var tk = _DbContext.TaiKhoans.ToList().FirstOrDefault(p => p.ID == obj.ID);
                    //tk.IDNv = obj.IDNv;
                    //tk.TenTaiKhoan = obj.TenTaiKhoan;
                    tk.CapDoQuyen = obj.CapDoQuyen;
                    tk.MatKhau = obj.MatKhau;
                    _DbContext.TaiKhoans.Update(tk);
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
