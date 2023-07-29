using BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IServices
{
    public interface IQLNhanVienServices
    {
        string Add(NhanVienView obj);
        string Update(NhanVienView obj);
        string Delete(NhanVienView obj);
        Guid GetIDbyName(string Name);
        string GetNamebyID(Guid ID);

        List<NhanVienView> GetAll();
    }
}
