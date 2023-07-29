using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;

namespace DAL.IRepositories
{
    public interface IHoaDonChiTietRepository
    {
        public bool Add(HoaDonChiTiet obj);
        public bool Upadate(HoaDonChiTiet obj);
        public bool Remove(HoaDonChiTiet obj);
        public List<HoaDonChiTiet> GetAll();
    }
}
