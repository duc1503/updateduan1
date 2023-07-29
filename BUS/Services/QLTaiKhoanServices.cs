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
    public class QLTaiKhoanServices : IQLTaiKhoanServices
    {
        private ITaiKhoanRepository _iTaiKhoanRepository;
        private INhanVienRepository _iNhanVienRepository;
        public QLTaiKhoanServices()
        {
            _iTaiKhoanRepository = new TaiKhoanRepository();
            _iNhanVienRepository = new NhanVienRepository();
        }
        public string Add(TaiKhoanView obj)
        {
            try
            {
                if (obj == null)
                {
                    return "Không có đối tượng truyền vào";
                }
                else
                {
                    var TaiKhoanNew = new TaiKhoan()
                    {
                        ID = obj.ID,
                        TenTaiKhoan = obj.TenTaiKhoan,
                        MatKhau = obj.MatKhau,
                        CapDoQuyen = obj.CapDoQuyen,
                        IDNv = obj.IDNv,
                    };
                    if (_iTaiKhoanRepository.Add(TaiKhoanNew))
                    {
                        return "Thêm thành công";
                    }
                    else
                    {
                        return "Thêm thất b";
                    }
                }
            }
            catch (Exception)
            {

                return "Thêm thất b";
            }
        }
        public string Update(TaiKhoanView obj)
        {
            try
            {
                if (obj == null)
                {
                    return "Không có đối tượng truyền vào";
                }
                else
                {
                    var taikhoan = _iTaiKhoanRepository.GetAll().FirstOrDefault(c => c.ID == obj.ID);
                    //taikhoan.TenTaiKhoan = obj.TenTaiKhoan;
                    taikhoan.MatKhau = obj.MatKhau;
                    taikhoan.CapDoQuyen = obj.CapDoQuyen;
                    //taikhoan.IDNv = obj.IDNv;
                    if (_iTaiKhoanRepository.Update(taikhoan))
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
        public string Delete(TaiKhoanView obj)
        {
            try
            {
                if (obj == null)
                {
                    return "Không có đối tượng truyền vào";
                }
                else
                {
                    var taiKhoan = _iTaiKhoanRepository.GetAll().FirstOrDefault(c => c.ID == obj.ID);
                    if (_iTaiKhoanRepository.Remove(taiKhoan))
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

        public List<TaiKhoanView> GetAll()
        {
            List<TaiKhoanView> listTaiKhoanCoNV = new List<TaiKhoanView>();
            listTaiKhoanCoNV = (from a in _iTaiKhoanRepository.GetAll()
                            join b in _iNhanVienRepository.GetAll() on a.IDNv equals b.ID
                            select new TaiKhoanView()
                            {
                                ID = a.ID,
                                IDNv= a.IDNv,
                                TenTaiKhoan = a.TenTaiKhoan,
                                MatKhau = a.MatKhau,
                                CapDoQuyen = a.CapDoQuyen,
                                TenNV = b.TenNV,
                                MaNv=b.MaNV
                            }).ToList();

            List<TaiKhoanView> listTaiKhoanKCoNV = new List<TaiKhoanView>();
            listTaiKhoanKCoNV = (from a in _iTaiKhoanRepository.GetAll()
                                 where a.IDNv == null
                                select new TaiKhoanView()
                                {
                                    ID = a.ID,
                                    TenTaiKhoan = a.TenTaiKhoan,
                                    MatKhau = a.MatKhau,
                                    CapDoQuyen = a.CapDoQuyen,
                                }).ToList();

            var listAllAccount = new List<TaiKhoanView>();
            foreach (var item in listTaiKhoanCoNV)
            {
                listAllAccount.Add(item);
            }

            foreach (var item in listTaiKhoanKCoNV)
            {
                listAllAccount.Add(item);
            }
            return listAllAccount.ToList();
        }

        public Guid GetIDbyName(string Name)
        {
            var tk = GetAll().FirstOrDefault(a => a.TenTaiKhoan == Name);
            if (tk == null )
            {
                return Guid.Empty;
            }
            else
            {
                return tk.ID;
            }
        }

        public string GetNamebyID(Guid ID)
        {
            var tk = GetAll().FirstOrDefault(a => a.ID == ID);
            if (tk == null)
            {
                return "Không lấy được tên tài khoản";
            }
            else
            {
                return tk.TenTaiKhoan;
            }
        }

        public List<TaiKhoanView> Sreach(string TuKhoa)
        {
            var tk = GetAll().Where(a => a.TenTaiKhoan.Contains(TuKhoa));
            return (List<TaiKhoanView>) tk;
        }
    }
}
