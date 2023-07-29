using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BUS.ViewModels;
namespace BUS.IServices
{
    public interface IQLLoaiTienNghiService
    {
        public string Add(LoaiTienNghiView obj);
        public string Update(LoaiTienNghiView obj);
        public string Remove(LoaiTienNghiView obj);
        public List<LoaiTienNghiView> GetAll();
        public string GetTenLoaiTNById(Guid Id);
        public List<LoaiTienNghiView> Search(string name);

        Guid GetIdByName(string TenLoaiTN);

    }
}
