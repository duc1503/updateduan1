using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;

namespace DAL.IRepositories
{
    public interface IPhieuThueRepository
    {
        public bool Add(PhieuThue obj);
        public bool Upadate(PhieuThue obj);
        public bool Remove(PhieuThue obj);
        public List<PhieuThue> GetAll();
    }
}
