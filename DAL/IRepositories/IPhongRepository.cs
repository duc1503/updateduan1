using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;

namespace DAL.IRepositories
{
    public interface IPhongRepository
    {
        public bool Add(Phong obj);
        public bool Upadate(Phong obj);
        public bool Remove(Phong obj);
        public List<Phong> GetAll();

        public bool UpdateTrangThaiPhong(Phong obj);
    }
}
