using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;
using BUS.ViewModels;

namespace BUS.IServices
{
    public interface IQLDichVuService
    {
        string Add(DichVuView obj);
        string Delete(DichVuView obj);
        string Update(DichVuView obj);
        List<DichVuView> Sreach(string tukhoa);
        List<DichVuView> GetAll();
        public Guid GetIdDvByName(string name);
    }
}
