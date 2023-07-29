using BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IServices
{
    public interface IQLTaiKhoanServices
    {
        string Add(TaiKhoanView obj);
        string Update(TaiKhoanView obj);
        string Delete(TaiKhoanView obj);
        Guid GetIDbyName(string Name);
        string GetNamebyID(Guid ID);

        List<TaiKhoanView> GetAll();
        List<TaiKhoanView> Sreach(string TuKhoa);
    }
}
