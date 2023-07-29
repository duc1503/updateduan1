using BUS.IServices;
using BUS.ViewModels;
using DAL.IRepositories;
using DAL.Models;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BUS.Services
{
    public class QLNhanVienServices : IQLNhanVienServices
    {
        private INhanVienRepository _iNhanVienRepository;
        private IChucVuRepository _iChucVuRepository;

        public QLNhanVienServices()
        {
            _iNhanVienRepository= new NhanVienRepository();
            _iChucVuRepository = new ChucVuRepository();
        }
        public string Add(NhanVienView obj)
        {
            try
            {
                if (obj == null)
                {
                    return "Không có đối tượng truyền vào";
                }
                else
                {
                    var NhanVienNew = new NhanVien()
                    {
                        ID = obj.ID,
                        MaNV = obj.MaNV,
                        TenNV = obj.TenNV,
                        NgaySinh = obj.NgaySinh,
                        GioiTinh = obj.GioiTinh,
                        DiaChi = obj.DiaChi,
                        SDT = obj.SDT,
                        CCCD = obj.CCCD,
                        Luong = obj.Luong,
                        IDCv = obj.IDCv,
                    };
                    if (_iNhanVienRepository.Add(NhanVienNew))
                    {
                        return "Thêm thành công";
                    }
                    else
                    {
                        return "Thêm thất bại";
                    }
                }
            }
            catch (Exception)
            {

                return "Thêm thất bại";
            }
        }

        public string Delete(NhanVienView obj)
        {
            try
            {
                if (obj == null)
                {
                    return "Không có đối tượng truyền vào";
                }
                else
                {
                    var NhanVienNew = _iNhanVienRepository.GetAll().FirstOrDefault(c => c.ID == obj.ID);
                    if (_iNhanVienRepository.Remove(NhanVienNew))
                    {
                        return "Xóa thành công";
                    }
                    else
                    {
                        return "Xóa thất bại";
                    }
                }
            }
            catch (Exception)
            {

                return "Xóa thất bại";
            }
        }

        public List<NhanVienView> GetAll()
        {
            List<NhanVienView> listNV = new List<NhanVienView>();
            listNV = (from a in _iNhanVienRepository.GetAll()
                            join b in _iChucVuRepository.GetAll() on a.IDCv equals b.ID
                            select new NhanVienView()
                            {
                                ID = a.ID,
                                MaNV = a.MaNV,
                                TenNV = a.TenNV,
                                NgaySinh = a.NgaySinh,
                                GioiTinh = a.GioiTinh,
                                DiaChi = a.DiaChi,
                                SDT = a.SDT,
                                CCCD = a.CCCD,
                                Luong = a.Luong,
                                IDCv = a.IDCv,
                                TenCV = b.TenCV,
                            }).ToList();
            return listNV;
        }

        public Guid GetIDbyName(string Name)
        {
            var nv = GetAll().FirstOrDefault(a => a.TenNV == Name);
            if (nv == null)
            {
                return Guid.Empty;
            }
            else
            {
                return nv.ID;
            }
        }

        public string GetNamebyID(Guid ID)
        {
            var nv = GetAll().FirstOrDefault(a => a.ID == ID);
            if (nv == null)
            {
                return "Không thể lấy được TenNV";
            }
            else
            {
                return nv.TenNV.ToString();
            }
        }

        public string Update(NhanVienView obj)
        {
            try
            {
                if (obj == null)
                {
                    return "Không có đối tượng truyền vào";
                }
                else
                {
                    var NhanVienNew = _iNhanVienRepository.GetAll().FirstOrDefault(c => c.ID == obj.ID);
                    NhanVienNew.MaNV = obj.MaNV;
                    NhanVienNew.TenNV = obj.TenNV;
                    NhanVienNew.NgaySinh = obj.NgaySinh;
                    NhanVienNew.GioiTinh = obj.GioiTinh;
                    NhanVienNew.DiaChi = obj.DiaChi;
                    NhanVienNew.SDT = obj.SDT;
                    NhanVienNew.CCCD = obj.CCCD;
                    NhanVienNew.Luong = obj.Luong;
                    NhanVienNew.IDCv = obj.IDCv;
                    if (_iNhanVienRepository.Upadate(NhanVienNew))
                    {
                        return "Sửa thành công";

                    }
                    else
                    {
                        return "Sửa thất bại";

                    }

                }
            }
            catch (Exception)
            {

                return "Sửa thất bại";
            }
        }
    }
}
