using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;

namespace DAL.IRepositories
{
    public interface INhanVienRepository
    {
        public bool Add(NhanVien obj);
        public bool Upadate(NhanVien obj);
        public bool Remove(NhanVien obj);
        public List<NhanVien> GetAll();
    }
}
