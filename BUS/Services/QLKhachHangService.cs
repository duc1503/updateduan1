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

namespace BUS.Services
{
    public class QLKhachHangService : IQLKhachHangService
    {
        IKhachHangRepository _iKhachHangRepository;
        List<KhachHangView> _lstKhachHangView;
        public QLKhachHangService()
        {
            _iKhachHangRepository = new KhachHangRepository();
            _lstKhachHangView = new List<KhachHangView>();

        }      

        public string Add(KhachHangView khv)
        {
            try
            {
                if (khv == null)
                {
                    return "Thêm thất bại";
                }
                else
                {
                    KhachHang kh = new KhachHang()
                    {
                        ID = khv.ID,
                        MaKH = khv.MaKH,
                        HovaTen = khv.HovaTen,
                        CCCD = khv.CCCD,
                        SDT = khv.SDT,
                        DiaChi = khv.DiaChi,
                        GioiTinh = khv.GioiTinh,
                        QuocTich = khv.QuocTich,
                    };
                    if (_iKhachHangRepository.Add(kh))
                    {
                        return "Thêm thành công";
                    }
                    return "Thêm thất bại";
                }
            }
            catch (Exception)
            {

                return "Thêm thất bại";
            }
            
        }

        public List<KhachHangView> GetAll()
        {
            _lstKhachHangView = (from a in _iKhachHangRepository.GetAll()
                                 select new KhachHangView()
                                 {
                                     ID = a.ID,
                                     MaKH = a.MaKH,
                                     HovaTen = a.HovaTen,
                                     CCCD = a.CCCD,
                                     SDT = a.SDT,
                                     DiaChi = a.DiaChi,
                                     GioiTinh = a.GioiTinh,
                                     QuocTich = a.QuocTich
                                 }).ToList();
            return _lstKhachHangView;
        }

       

        public List<KhachHangView> Search(string search)
        {
            _lstKhachHangView = GetAll().Where(x => x.HovaTen.Contains(search)).ToList();
            return _lstKhachHangView;
        }

        public string Update(KhachHangView khv)
        {
            try
            {
                if (khv == null)
                {
                    return "Sửa thất bại";
                }
                else
                {
                    var x = _iKhachHangRepository.GetAll().FirstOrDefault(x => x.ID == khv.ID);
                    x.MaKH = khv.MaKH;
                    x.HovaTen = khv.HovaTen;
                    x.CCCD = khv.CCCD;
                    x.SDT = khv.SDT;
                    x.DiaChi = khv.DiaChi;
                    x.GioiTinh = khv.GioiTinh;
                    x.QuocTich = khv.QuocTich;
                    if (_iKhachHangRepository.Upadate(x))
                    {
                        return "Sửa thành công";
                    }
                    return "Sửa thất bại";
                }
            }
            catch (Exception)
            {

                return "Sửa thất bại";
            }
            
        }

        public string Remove(KhachHangView khv)
        {
            try
            {
                if (khv == null)
                {
                    return "Xóa thất bại";
                }
                else
                {
                    var kh = _iKhachHangRepository.GetAll().FirstOrDefault(p => p.ID == khv.ID);
                    if (_iKhachHangRepository.Remove(kh))
                    {
                        return "Xóa thành công";
                    }
                    return "Xóa thất bại";
                }
            }
            catch (Exception)
            {

                return "Xóa thất bại";
            }
        }
    }
}

