using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BUS.ViewModels;

namespace BUS.IServices
{
    public interface IChucVuService
    {
        public string Add(ChucVuView obj);
        public string Update(ChucVuView obj);
        public string Remove(ChucVuView obj);
        public List<ChucVuView> GetAll();
        public List<ChucVuView> GetList(string obj);
    }
}
