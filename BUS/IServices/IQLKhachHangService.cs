using BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IServices
{
    public interface IQLKhachHangService
    {
        public string Add(KhachHangView khv);
        public string Remove(KhachHangView khv);
        public string Update(KhachHangView khv);
        public List<KhachHangView> GetAll();
        public List<KhachHangView> Search(string search);
        
     
    }
}
