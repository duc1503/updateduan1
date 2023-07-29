using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;

namespace DAL.IRepositories
{
    public interface IHoaDonRepository
    {
        public bool Add(HoaDon obj);
        public bool Upadate(HoaDon obj);
        public bool Remove(HoaDon obj);
        public List<HoaDon> GetAll();
    }
}
