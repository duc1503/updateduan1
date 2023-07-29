using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;

namespace DAL.IRepositories
{
    public interface ITaiKhoanRepository
    {
        public bool Add(TaiKhoan obj);
        public bool Update(TaiKhoan obj);
        public bool Remove(TaiKhoan obj);
        public List<TaiKhoan> GetAll();
    }
}
