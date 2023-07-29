using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;

namespace DAL.IRepositories
{
    public interface IDichVuRepository
    {
        public bool Add(DichVu obj);
        public bool Upadate(DichVu obj);
        public bool Remove(DichVu obj);
        public List<DichVu> GetAll();
    }
}
