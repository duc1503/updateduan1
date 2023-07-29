using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;

namespace DAL.IRepositories
{
    public interface ILoaiPhongRepository
    {
        public bool Add(LoaiPhong obj);
        public bool Upadate(LoaiPhong obj);
        public bool Remove(LoaiPhong obj);
        public List<LoaiPhong> GetAll();
    }
}
