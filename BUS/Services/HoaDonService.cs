using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BUS.IServices;
using BUS.ViewModels;
using DAL.IRepositories;
using DAL.Repositories;
using BUS.Ultilities;
using DAL.Models;

namespace BUS.Services
{
    public class HoaDonService : IHoaDonService
    {
        private IHoaDonRepository _hoaDonRepository;
        private Validations _validations;
        private IChiTietPhieuThueRepository _chiTietPhieuThueRepository;
        private IKhachHangRepository _khachHangRepository;
        private INhanVienRepository _nhanVienRepository;
        private IPhongRepository _phongRepository;
        private IHoaDonChiTietRepository _hoaDonChiTietRepository;
        private IDichVuRepository _dichVuRepository;
        private IPhieuThueRepository _phieuThueRepository;
        private ILoaiDichVuRepository _loaiDichVuRepository;
        private ILoaiPhongRepository _loaiPhongRepository;

        public HoaDonService()
        {
            _hoaDonRepository = new HoaDonRepository();
            _validations = new Validations();
            _chiTietPhieuThueRepository = new ChiTietPhieuThueRepository();
            _khachHangRepository = new KhachHangRepository();
            _nhanVienRepository = new NhanVienRepository();
            _phongRepository = new PhongRepository();
            _hoaDonChiTietRepository = new HoaDonChiTietRepository();
            _dichVuRepository = new DichVuRepository();
            _phieuThueRepository = new PhieuThueRepository();
            _loaiDichVuRepository = new LoaiDichVuRepository();
            _loaiPhongRepository = new LoaiPhongRepository();
        }
        private string Validate(HoaDonView obj)
        {
            return string.Empty;
        }
        public string Add(HoaDonView obj)
        {
            try
            {
                if (obj == null)
                {
                    return "Nhận phòng that bai";
                }
                else
                {
                    HoaDon hd = new HoaDon();
                    hd.MaHD = obj.MaHD;
                    hd.NgayTaoHD = obj.NgayTaoHD;
                    hd.IdCTPhieuThue = obj.IdCTPhieuThue;
                    if (_hoaDonRepository.Add(hd))
                    {
                        return "Nhận phòng thành công";
                    }
                    return "Nhận phòng  that bai";
                }
            }
            catch (Exception)
            {
                return "Nhận phòng  that bai";

            }
        }

        public List<HoaDonView> GetCTHoaDon(Guid Id)
        {
            List<HoaDonView> _lst = new List<HoaDonView>();
            if (Id==Guid.Empty)
            {
                _lst = (from a in _hoaDonRepository.GetAll()
                        join b in _hoaDonChiTietRepository.GetAll() on a.Id equals b.IdHoaDon
                        join c in _dichVuRepository.GetAll() on b.IdDichVu equals c.Id
                        select new HoaDonView()
                        {
                            Id = a.Id,
                            SoLuongDichVu = b.SoLuong,
                            DonGia = b.DonGia,
                            TenDichVu = c.TenDichVu
                        }).ToList();
            }
            else
            {
                _lst = (from a in _hoaDonRepository.GetAll()
                        join b in _hoaDonChiTietRepository.GetAll() on a.Id equals b.IdHoaDon
                        join c in _dichVuRepository.GetAll() on b.IdDichVu equals c.Id
                        where a.Id.ToString().ToLower().Contains(Id.ToString().ToLower())
                        select new HoaDonView()
                        {
                            Id = a.Id,
                            SoLuongDichVu = b.SoLuong,
                            DonGia = b.DonGia,
                            TenDichVu = c.TenDichVu
                        }).ToList();
            }
            return _lst;
        }
        public List<HoaDonView> GetCTPhong(Guid Id)
        {
            List<HoaDonView> _lst = new List<HoaDonView>();
            if(Id == Guid.Empty)
            {
                _lst = (from a in _hoaDonRepository.GetAll()
                        join b in _chiTietPhieuThueRepository.GetAll() on a.IdCTPhieuThue equals b.ID
                        join c in _phongRepository.GetAll() on b.IdPhong equals c.Id
                        join d in _loaiPhongRepository.GetAll() on c.IDLoaiPhong equals d.ID
                        select new HoaDonView()
                        {
                            Id = a.Id,
                            NgayBatDau = b.NgayBatDau,
                            NgayKetThuc = b.NgayKetThuc,
                            MaPhong = c.MaPhong,
                            GiaNgay = d.GiaNgay,
                            TenLoaiPhong = d.TenLoaiPhong
                        }).ToList();
            }
            else
            {
                _lst = (from a in _hoaDonRepository.GetAll()
                        join b in _chiTietPhieuThueRepository.GetAll() on a.IdCTPhieuThue equals b.ID
                        join c in _phongRepository.GetAll() on b.IdPhong equals c.Id
                        join d in _loaiPhongRepository.GetAll() on c.IDLoaiPhong equals d.ID
                        where a.Id.ToString().ToLower().Contains(Id.ToString().ToLower())
                        select new HoaDonView()
                        {
                            Id = a.Id,
                            NgayBatDau = b.NgayBatDau,
                            NgayKetThuc = b.NgayKetThuc,
                            MaPhong = c.MaPhong,
                            GiaNgay = d.GiaNgay,
                            TenLoaiPhong = d.TenLoaiPhong
                        }).ToList();
            }
            return _lst;
        }

        public List<HoaDonView> GetListHD(Guid Id)
        {
            List<HoaDonView> _lst = new List<HoaDonView>();
            if (Id==Guid.Empty)
            {
                _lst = (from a in _hoaDonRepository.GetAll()
                        join b in _chiTietPhieuThueRepository.GetAll() on a.IdCTPhieuThue equals b.ID
                        join c in _phieuThueRepository.GetAll() on b.IdPhieuThue equals c.ID
                        join d in _khachHangRepository.GetAll() on c.IdKH equals d.ID
                        join e in _nhanVienRepository.GetAll() on c.IdNV equals e.ID
                        join f in _phongRepository.GetAll() on b.IdPhong equals f.Id
                        select new HoaDonView()
                        {
                            Id = a.Id,
                            MaHD = a.MaHD,
                            NgayTaoHD = a.NgayTaoHD,
                            NgayTT = a.NgayTT,
                            TenNV = e.TenNV,
                            TenKH = d.HovaTen,
                            MaPhong = f.MaPhong,
                            TrangThai = a.TrangThai
                        }).OrderBy(c => c.MaHD).ToList();
            }
            else
            {
                _lst = (from a in _hoaDonRepository.GetAll()
                        join b in _chiTietPhieuThueRepository.GetAll() on a.IdCTPhieuThue equals b.ID
                        join c in _phieuThueRepository.GetAll() on b.IdPhieuThue equals c.ID
                        join d in _khachHangRepository.GetAll() on c.IdKH equals d.ID
                        join e in _nhanVienRepository.GetAll() on c.IdNV equals e.ID
                        join f in _phongRepository.GetAll() on b.IdPhong equals f.Id
                        where a.Id.ToString().ToLower().Contains(Id.ToString().ToLower())
                        select new HoaDonView()
                        {
                            Id = a.Id,
                            MaHD = a.MaHD,
                            NgayTaoHD = a.NgayTaoHD,
                            NgayTT = a.NgayTT,
                            TenNV = e.TenNV,
                            TenKH = d.HovaTen,
                            MaPhong = f.MaPhong,
                            TrangThai = a.TrangThai
                        }).OrderBy(c => c.MaHD).ToList();
            }
            return _lst;
        }
        public string Remove(HoaDonView obj)
        {
            throw new NotImplementedException();
        }

        public string Update(HoaDonView obj)
        {
            try
            {
                var index = _hoaDonRepository.GetAll().FirstOrDefault(c => c.Id == obj.Id);
                if (index == null) return "Không tìm thấy";
                index.TrangThai = obj.TrangThai;
                index.NgayTT = DateTime.Now;
                if (_hoaDonRepository.Upadate(index))
                {
                    return "Sửa Thành Công";
                }
                return "Sửa Không Thành Công";
            }
            catch (Exception)
            {

                return "Sửa Không Thành Công";
            }
        }

        public List<HoaDonView> Search(string keyWord)
        {
            return GetListHD(Guid.Empty).Where(c => c.MaHD.ToUpper().Contains(keyWord.ToUpper())).ToList();
        }

        public List<HoaDonView> GetAll()
        {
            List<HoaDonView> hdv = new List<HoaDonView>();
            hdv = (from a in _hoaDonRepository.GetAll()
                   join b in _chiTietPhieuThueRepository.GetAll() on a.IdCTPhieuThue equals b.ID
                   select new HoaDonView()
                   {
                       Id = a.Id,
                       MaHD = a.MaHD,
                       NgayTaoHD = a.NgayTaoHD,
                       IdCTPhieuThue = b.ID,
                       NgayTT = a.NgayTT,
                       TrangThai = a.TrangThai
                   }
                   ).ToList();
            return hdv;
        }
    }
}
