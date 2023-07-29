using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;

namespace DAL.IRepositories
{
    public interface IChucVuRepository
    {
        public bool Add(ChucVu obj);
        public bool Upadate(ChucVu obj);
        public bool Remove(ChucVu obj);
        public List<ChucVu> GetAll();
    }
}
