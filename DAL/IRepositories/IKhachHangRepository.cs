using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;

namespace DAL.IRepositories
{
    public interface IKhachHangRepository
    {
        public bool Add(KhachHang obj);
        public bool Upadate(KhachHang obj);
        public bool Remove(KhachHang obj);
        public List<KhachHang> GetAll();
    }
}
