using BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IServices
{
    public interface IQLPhieuThueService
    {
        public string Add(PhieuThueView khv);
        public string Remove(PhieuThueView khv);
        public string Update(PhieuThueView khv);
        public List<PhieuThueView> GetAll();
        
    }
}
