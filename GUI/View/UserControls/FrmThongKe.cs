using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS.IServices;
using BUS.Services;
using BUS.ViewModels;
namespace GUI.View.UserControls
{
    public partial class FrmThongKe : Form
    {
        private IHoaDonService _qlHoadon;
        public DateTime NgayThanhToanHD { get; set; }
        public int GiaTienTraPhongMuon = 50000;
        double SoNgayThue = 0;
        public int TongTienPhaiTra { get; set; }
        public double tongTien { get; set; }
        public FrmThongKe()
        {
            InitializeComponent();
            _qlHoadon = new HoaDonService();
            LoadCmb();
            LoadData();
        }
        private void LoadCmb()
        {
            for (int i = 1900; i <= DateTime.Now.Year; i++)
            {
                cmb_Nam.Items.Add(i);
            }
            cmb_Nam.Text = Convert.ToString(DateTime.Now.Year);
        }
        private void LoadData()
        {
            dtg_thongke.Rows.Clear();
            int stt = 1;
            dtg_thongke.ColumnCount = 4;
            dtg_thongke.Columns[0].Name = "STT";
            dtg_thongke.Columns[1].Name = "Thang";
            dtg_thongke.Columns[2].Name = "Nam";
            dtg_thongke.Columns[3].Name = "Doanh Thu";
            dtg_thongke.Rows.Clear();
            for(int i = 1; i <= 12; i++)
            {
                dtg_thongke.Rows.Add(stt++, i, cmb_Nam.Text, TongTienThang(i,Convert.ToInt32(cmb_Nam.Text)));
            }
        }
        public double TongTienThang(int Month,int Year)
        {
            double i = 0;

            foreach (var x in _qlHoadon.GetListHD(Guid.Empty).Where(c=> c.TrangThai == 1 && c.NgayTT.Value.Month == Month &&  c.NgayTT.Value.Year == Year))

            {
                i += TinhTienThanhToan(x.Id);
            }
            return i;
        }

        private double TinhTienThanhToan(Guid Id)
        {
            double tienPhong = 0;
            int tienDV = 0;
            double SoNgayTinhToan = 0;
            foreach (var x in _qlHoadon.GetCTPhong(Id))
            {

                int count = 0;
                DateTime NgayBDThue = x.NgayBatDau;
                DateTime NgayTT = NgayThanhToanHD;
                TimeSpan SLNgayThue = NgayTT - NgayBDThue;
                TimeSpan SoNgayThueDatTruoc = x.NgayKetThuc - x.NgayBatDau;

                if (SLNgayThue.TotalHours <= 24.24)// TH1 : Số ngày thuê < 1 ngày
                {
                    count = 1;
                    SoNgayThue = 1;

                }
                else if (SLNgayThue.TotalHours > 24.24 && SLNgayThue.TotalHours <= (SoNgayThueDatTruoc.TotalHours + 0.24)) // TH2 : Số ngày thuê nhiều hơn 1 ngày nhưng ít hơn tổng số ngày đặt trước
                {
                    count = 2;
                    int soNgayTinhToan = (int)SLNgayThue.TotalHours / 24;
                    double GioLe = SLNgayThue.TotalHours - soNgayTinhToan * 24;// Giờ lẻ của giờ thực tế thuê
                    if (GioLe <= 1)
                    {
                        SoNgayThue = soNgayTinhToan;
                    }
                    else if (GioLe > 1 && GioLe <= 13)
                    {
                        SoNgayThue = soNgayTinhToan + 0.5;
                    }
                    else
                    {
                        SoNgayThue = soNgayTinhToan + 1;
                    }
                }
                else// SLNgayThue.ToTalHours > SoNgayThueDatTruoc.TotalHours + 0.24 -- TH3 : Số ngày thuê vượt quá số ngày đã đặt
                {
                    count = 3;
                    double SoGioQua = SLNgayThue.TotalHours - SoNgayThueDatTruoc.TotalHours;
                    if (SoGioQua <= 1)  // OK
                    {
                        SoNgayThue = Math.Round(SoNgayThueDatTruoc.TotalHours / 24);
                    }
                    else if (SoGioQua > 1 && SoGioQua <= 11)
                    {
                        SoNgayThue = Math.Round(SoNgayThueDatTruoc.TotalHours / 24) + 0.5;
                    }
                    else if (SoGioQua > 11 && SoGioQua <= 24.24)
                    {
                        SoNgayThue = Math.Round(SoNgayThueDatTruoc.TotalHours / 24) + 1;
                    }
                    else//SoGioQua > 24
                    {
                        SoNgayTinhToan = SoGioQua / 24;
                        double GioQuaLe = SoGioQua - SoNgayTinhToan * 24;
                        if (GioQuaLe <= 1)
                        {
                            SoNgayTinhToan = (int)SoGioQua / 24;
                        }
                        else if (GioQuaLe > 1 && GioQuaLe <= 12)
                        {
                            SoNgayTinhToan += 0.5;
                        }
                        else
                        {
                            SoNgayTinhToan += 1;
                        }
                        SoNgayThue = Math.Round(SLNgayThue.TotalHours / 24);
                    }
                }
                if (count == 1 || count == 2)
                {
                    tienPhong = x.GiaNgay * SoNgayThue;
                }
                else if (count == 3)
                {
                    //tienPhong = x.GiaNgay * SoNgayThue + (x.GiaNgay + GiaTienTraPhongMuon) * SoNgayTinhToan;
                    tienPhong = x.GiaNgay * Math.Round(SoNgayThueDatTruoc.TotalHours / 24) + (x.GiaNgay + GiaTienTraPhongMuon) * SoNgayTinhToan;
                }
            }
            foreach (var x in _qlHoadon.GetCTHoaDon(Id))
            {
                tienDV += x.DonGia * x.SoLuongDichVu;
            }

            tongTien = tienDV + tienPhong;
            return tongTien;
        }

        private void cmb_Nam_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
            tongTien = 0;
        }
    }
}
