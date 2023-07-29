using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;

namespace DAL.IRepositories
{
    public interface ILoaiDichVuRepository
    {
        public bool Add(LoaiDichVu obj);
        public bool Upadate(LoaiDichVu obj);
        public bool Remove(LoaiDichVu obj);
        public List<LoaiDichVu> GetAll();
    }
}
