using BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IServices
{
    public interface IQLChiTietPhieuThueService
    {
        List<ChiTietPhieuThueView> GetAll();
        List<ChiTietPhieuThueView> Search();
        string Add(ChiTietPhieuThueView ctptv);
        string Update(ChiTietPhieuThueView ctptv);
        string Remove(ChiTietPhieuThueView ctptv);
    }
}
