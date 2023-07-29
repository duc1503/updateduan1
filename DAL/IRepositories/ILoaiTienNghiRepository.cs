using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;

namespace DAL.IRepositories
{
    public interface ILoaiTienNghiRepository
    {
        public bool Add(LoaiTienNghi obj);
        public bool Upadate(LoaiTienNghi obj);
        public bool Remove(LoaiTienNghi obj);
        public List<LoaiTienNghi> GetAll();
    }
}
