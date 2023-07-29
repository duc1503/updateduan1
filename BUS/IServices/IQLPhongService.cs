using BUS.ViewModels;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IServices
{
    public interface IQLPhongService
    {
        List<PhongView> GetAll();

        List<PhongView> Search(string name);
        string Add(PhongView phongView);
        string Remove(PhongView phongView);
        string Update(PhongView phongView);

        string UpdateTrangThaiPhong(PhongView phongView);
        Guid GetIdLoaiPhongByName(string Name);
    }
}
