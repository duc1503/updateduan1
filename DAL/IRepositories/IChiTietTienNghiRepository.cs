using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;

namespace DAL.IRepositories
{
    public interface IChiTietTienNghiRepository
    {
        public bool Add(ChiTietTienNghi obj);
        public bool Upadate(ChiTietTienNghi obj);
        public bool Remove(ChiTietTienNghi obj);
        public List<ChiTietTienNghi> GetAll();
    }
}
