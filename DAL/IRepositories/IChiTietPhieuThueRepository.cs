using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;

namespace DAL.IRepositories
{
    public interface IChiTietPhieuThueRepository
    {
        public bool Add(ChiTietPhieuThue obj);
        public bool Upadate(ChiTietPhieuThue obj);
        public bool Remove(ChiTietPhieuThue obj);
        public List<ChiTietPhieuThue> GetAll();
    }
}
