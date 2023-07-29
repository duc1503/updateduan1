using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;
using BUS.ViewModels;

namespace BUS.IServices
{
    public interface IQLLoaiDichVuService
    {
        string Add(LoaiDichVuView obj);
        string Delete(LoaiDichVuView obj);
        string Update(LoaiDichVuView obj);
        List<LoaiDichVuView> Sreach(string tukhoa);
        List<LoaiDichVuView> GetAll();
    }
}
