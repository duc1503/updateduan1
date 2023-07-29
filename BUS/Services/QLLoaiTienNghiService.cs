using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BUS.IServices;
using BUS.ViewModels;
using DAL.Repositories;
using DAL.IRepositories;
using DAL.Models;
namespace BUS.Services
{
    public class QLLoaiTienNghiService : IQLLoaiTienNghiService
    {
        private ILoaiTienNghiRepository _LoaiTNRepos;
        public QLLoaiTienNghiService()
        {
            _LoaiTNRepos = new LoaiTienNghiRepository();
        }
        public string Add(LoaiTienNghiView obj)
        {
            try
            {
                if (obj == null)
                {
                    return "Không có đối tượng truyền vào";
                }
                else
                {
                    var ltn = new LoaiTienNghi()
                    {
                        ID = obj.ID,
                        MaLoaiTienNghi = obj.MaLoaiTienNghi,
                        TenLoaiTienNghi = obj.TenLoaiTienNghi,
                    };
                    if (_LoaiTNRepos.Add(ltn))
                    {
                        return "Thêm loại tiện nghi thành công";
                    }
                    else
                    {
                        return "Thêm loại tiện nghi thất bại";
                    }

                };
            }
            catch (Exception)
            {

                return "Thêm loại tiện nghi thất bại";
            }
        }

        public List<LoaiTienNghiView> GetAll()
        {
            List<LoaiTienNghiView> list = new List<LoaiTienNghiView>();
            list = (from a in _LoaiTNRepos.GetAll()
                    select new LoaiTienNghiView
                    {
                        ID = a.ID,
                        MaLoaiTienNghi = a.MaLoaiTienNghi,
                        TenLoaiTienNghi = a.TenLoaiTienNghi
                    }).ToList();
            return list;
        }

        public string GetTenLoaiTNById(Guid Id)
        {
            var ltn = _LoaiTNRepos.GetAll().Find(a => a.ID == Id);
            return ltn.TenLoaiTienNghi;
        }

        public Guid GetIdByName(string TenLoaiTN)
        {
            var ltn = _LoaiTNRepos.GetAll().FirstOrDefault(p => p.TenLoaiTienNghi == TenLoaiTN);
            return ltn.ID;
        }

        public string Remove(LoaiTienNghiView obj)
        {
            try
            {
                if (obj == null)
                {
                    return "Không tìm được đối tượng để xóa";
                }
                else
                {
                    var ltn = _LoaiTNRepos.GetAll().FirstOrDefault(a => a.ID == obj.ID);
                    if (_LoaiTNRepos.Remove(ltn))
                    {
                        return "Xóa loại tiện nghi thành công";
                    }
                    return "Xóa loại tiện nghi thất bại";
                }
            }
            catch (Exception)
            {

                return "Xóa loại tiện nghi thất bại";
            }
        }

        public List<LoaiTienNghiView> Search(string name)
        {
            var cttn = GetAll().Where(a => a.TenLoaiTienNghi.Contains(name)).ToList();
            return cttn;
        }

        public string Update(LoaiTienNghiView obj)
        {
            try
            {
                if (obj == null)
                {
                    return "Không tìm được đối tượng để sửa";
                }
                else
                {
                    var ltn = _LoaiTNRepos.GetAll().FirstOrDefault(a => a.ID == obj.ID);
                    ltn.MaLoaiTienNghi = obj.MaLoaiTienNghi;
                    ltn.TenLoaiTienNghi = obj.TenLoaiTienNghi;
                    if (_LoaiTNRepos.Upadate(ltn))
                    {
                        return "Sửa thông tin loại tiện nghi thành công";
                    }
                    else
                    {
                        return "Sửa thông tin loại tiện nghi thất bại, vui lòng thử lại";
                    }

                };
            }
            catch (Exception)
            {

                return "Sửa thông tin loại tiện nghi thất bại, vui lòng thử lại";
            }
        }
    }
}
