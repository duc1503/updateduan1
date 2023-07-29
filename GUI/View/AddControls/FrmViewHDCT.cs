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
using GUI.View.UserControls;

namespace GUI.View.AddControls
{
    public partial class FrmViewHDCT : Form
    {
        public List<HoaDonView> _lstHoaDon;
        public List<HoaDonView> _lstHoaDonCT;
        public List<HoaDonView> _lstGiaPhong;

        public Guid IdPTCTEdit { get; set; }
        public DateTime NgayThanhToanHD { get; set; }
        public IQLChiTietPhieuThueService _iqlCTPTService;
        public IHoaDonService _iqlHDService;
        public IPhongService _iqlPhongService;
        
        public int GiaTienTraPhongMuon = 50000;
        double SoNgayThue = 0;
        double tienPhong = 0;
        int tienDV = 0;
        public int TongTienPhaiTra { get; set; }
        public double tongTien { get; set; }
        public FrmPhong _main;
        public FrmViewHDCT(FrmPhong main)
        {
            InitializeComponent();
            _lstHoaDon = new List<HoaDonView>();
            _lstHoaDonCT = new List<HoaDonView>();
            _lstGiaPhong = new List<HoaDonView>();
            _iqlCTPTService = new QLChiTietPhieuThueService();
            _iqlHDService = new HoaDonService();
            _iqlPhongService = new IPhongService();
            LoadData();
            _main=main;
        }
        public FrmViewHDCT()
        {
            InitializeComponent();
            _lstHoaDon = new List<HoaDonView>();
            _lstHoaDonCT = new List<HoaDonView>();
            _lstGiaPhong = new List<HoaDonView>();
            _iqlCTPTService = new QLChiTietPhieuThueService();
            _iqlHDService = new HoaDonService();
            _iqlPhongService = new IPhongService();
            LoadData();
        }
        private void LoadData()
        {
            
            dgrid_HDCT.ColumnCount = 5;
            dgrid_HDCT.Columns[0].Name = "STT";
            dgrid_HDCT.Columns[1].Name = "Ten";
            dgrid_HDCT.Columns[2].Name = "Don Gia";
            dgrid_HDCT.Columns[3].Name = "So Luong";
            dgrid_HDCT.Columns[4].Name = "So Tien";
            dgrid_HDCT.Rows.Clear();
        }


        
        private void FrmViewHDCT_Load(object sender, EventArgs e)
        {
            TinhTienThanhToan();
            foreach (var item in _lstHoaDon)
            {
                //if (item.TrangThai == 1)//Trạng thái đã thanh toán
                //{
                //    btn_ThanhToan.Visible = false;
                //}
                //else
                //{
                //    btn_ThanhToan.Visible=true;
                //}
            }
            lb_NgayBD.Text = _lstGiaPhong[0].NgayBatDau.ToString();
            lb_NgayKT.Text = _lstGiaPhong[0].NgayKetThuc.ToString();
        }

        private void TinhTienThanhToan()
        {
            int stt = 1;
           double  SoNgayTinhToan = 0;
            foreach (var x in _lstGiaPhong)
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
               
                dgrid_HDCT.Rows.Add(stt++, x.TenLoaiPhong, x.GiaNgay, SoNgayThue, tienPhong);
               
                
            }
            foreach (var x in _lstHoaDonCT)
            {
                dgrid_HDCT.Rows.Add(stt++, x.TenDichVu, x.DonGia, x.SoLuongDichVu, x.DonGia * x.SoLuongDichVu);
                tienDV += x.DonGia * x.SoLuongDichVu;
            }

            tongTien = tienDV + tienPhong;
            foreach (var x in _lstHoaDon)
            {
                lbl_MaHD.Text = x.MaHD;
                lbl_TenNV.Text = x.TenNV;
                //lb_NgayBD.Text = _iqlCTPTService.GetAll().FirstOrDefault(p => p.ID == x.IdCTPhieuThue).NgayBatDau.ToString();
                //lb_NgayKT.Text = _iqlCTPTService.GetAll().FirstOrDefault(p => p.ID == x.IdCTPhieuThue).NgayBatDau.ToString();
                lbl_HoVaTen.Text = x.TenKH;
                lbl_MaPhong.Text = x.MaPhong;
                lbl_NgayThanhToan.Text = x.NgayTT.ToString();
                lbl_TongTien.Text = tongTien.ToString() + " Đồng";
            }


        }

        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            // thanh toán sẽ cập nhật trạng thái hóa đơn , chuyển trạng thái phòng sang phòng đang dọn dẹp
            DialogResult result = MessageBox.Show("Vui lòng xác nhận thanh toán !!", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                foreach (var item in _lstHoaDon)
                {
                    HoaDonView hdv = new HoaDonView();
                    hdv.Id = item.Id;
                    hdv.MaHD = item.MaHD;
                    hdv.NgayTaoHD = item.NgayTaoHD;
                    hdv.IdCTPhieuThue = item.IdCTPhieuThue;
                    hdv.NgayTT = item.NgayTT;
                    hdv.TrangThai = 1;
                    _iqlHDService.Update(hdv);
                    //MessageBox.Show(_iqlHDService.Update(hdv));
                   // MessageBox.Show(_iqlHDService.Update(_lstHoaDon.FirstOrDefault(c => c.Id == item.Id)));

                    PhongView pv = new PhongView();
                    pv.Id = _iqlPhongService.GetAll().FirstOrDefault(p => p.MaPhong == item.MaPhong).Id;
                    pv.MaPhong = item.MaPhong;
                    pv.IDLoaiPhong = _iqlPhongService.GetAll().FirstOrDefault(p => p.MaPhong == item.MaPhong).IDLoaiPhong;
                    pv.TinhTrang = 2;
                    _iqlPhongService.Update(pv);
                    //MessageBox.Show(_iqlPhongService.Update(pv));

        

                    ChiTietPhieuThueView ctptview = new ChiTietPhieuThueView();
                    //null
                    ctptview.ID = IdPTCTEdit;
                    ctptview.NgayBatDau = Convert.ToDateTime(lb_NgayBD.Text);
                    ctptview.NgayKetThuc = DateTime.Now;
                    ctptview.IdPhong = _iqlPhongService.GetAll().FirstOrDefault(p => p.MaPhong == lbl_MaPhong.Text).Id;
                    //
                    // co
                    var CTPT = _iqlCTPTService.GetAll().FirstOrDefault(p => p.ID == IdPTCTEdit);
                    Guid IdPhieuThue = CTPT.IdPhieuThue;
                    ctptview.IdPhieuThue = IdPhieuThue;
                    _iqlCTPTService.Update(ctptview);
                    //MessageBox.Show();

                    //var slHdct = _iqlHDCTService.GetAll().FirstOrDefault(p => p.IdDichVu == item.Id);
                    //int soMax = slHdct.SoLuong + 1;
                    //hdctv.SoLuong = soMax;
                    //var CTPT = _iqlCTPTService.GetAll().FirstOrDefault(p => p.ID == item.IdCTPhieuThue);
                    //Guid IdPhieuThue = CTPT.IdPhieuThue;
                    //ctptview.IdPhieuThue = IdPhieuThue;
                    //MessageBox.Show(_iqlCTPTService.Update(ctptview));
                    //_iqlCTPTService.Update(ctptview);
                    // MessageBox.Show(item.IdCTPhieuThue.ToString());
                    _main.LoadItemRooms_search(_iqlPhongService.GetAll());

                    // //var slHdct = _iqlHDCTService.GetAll().FirstOrDefault(p => p.IdDichVu == item.Id);
                    // //int soMax = slHdct.SoLuong + 1;
                    // //hdctv.SoLuong = soMax;
                    // var CTPT = _iqlCTPTService.GetAll().FirstOrDefault(p => p.ID == IdPTCTEdit);
                    // Guid IdPhieuThue = CTPT.IdPhieuThue;
                    // ctptview.IdPhieuThue = IdPhieuThue;
                    // //MessageBox.Show(_iqlCTPTService.Update(ctptview));
                    // _iqlCTPTService.Update(ctptview);
                    //// MessageBox.Show(item.IdCTPhieuThue.ToString());
                    MessageBox.Show("Thanh toán thành công");


                }
                
                
            }
            if (result == DialogResult.No)
            {
                MessageBox.Show("Bạn đã hủy thanh toán phòng này!");
            }
            
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            foreach(var item in _lstHoaDon)
            {
                e.Graphics.DrawString("\t\t Hóa Đơn", new Font("Arial", 30, FontStyle.Bold), Brushes.Green, new Point(10, 10));
                
                e.Graphics.DrawString("\t Address : Cao đăng FPT PolyTechnic,Trịnh Văn Bô,Xuân Phương, Nam Từ Liêm, Hà Nội", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(10, 80));
                
                e.Graphics.DrawString("\t Số HĐ : " + item.MaHD + "\t\tNgày Bắt Đầu : " + item.NgayBatDau, new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(10, 150));
                
                e.Graphics.DrawString("\t Thu Ngân : " + item.TenNV + "\t\tNgày Kết Thúc : " + item.NgayKetThuc, new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(10, 220));
                
                e.Graphics.DrawString("\t Tên Khách Hàng : " + item.TenKH + "\t\tNgày Thanh Toán : " + item.NgayTT, new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(10, 290));
                
                //
                e.Graphics.DrawString("\t Số Phòng Thuê : " + item.MaPhong , new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(10, 360));
                e.Graphics.DrawString($"Tên             \t||", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(100, 430));
                e.Graphics.DrawString($"Đơn Giá         \t||", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(300, 430));
                e.Graphics.DrawString($"Số Lượng        \t||", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(500, 430));
                e.Graphics.DrawString($"Số Tiền         ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(700, 430));

                Pen p = new Pen(Brushes.Black, 2);
                Point point1 = new Point(50, 430);
                Point point2 = new Point(800, 430);
                e.Graphics.DrawLine(p, point1, point2);

           
                Point point3 = new Point(50, point1.Y + 16);
                Point point4 = new Point(800, point2.Y + 16);
                e.Graphics.DrawLine(p, point3, point4);
                int z = point3.Y + 20;
                foreach (var y in _lstGiaPhong)
                {

                    e.Graphics.DrawString($"{y.TenLoaiPhong}", new Font("Arial", 10, FontStyle.Bold), Brushes.Blue, new Point(100, z));
                    
                    e.Graphics.DrawString($"{y.GiaNgay}", new Font("Arial", 10, FontStyle.Bold), Brushes.Blue, new Point(300, z));
                    
                    e.Graphics.DrawString($"{SoNgayThue}", new Font("Arial", 10, FontStyle.Bold), Brushes.Blue, new Point(500, z));
                    
                    e.Graphics.DrawString($"{tienPhong}", new Font("Arial", 10, FontStyle.Bold), Brushes.Blue, new Point(700, z));
                                        Point point5 = new Point(50, point1.Y + 65);
                    Point point6 = new Point(800, point2.Y + 65);
                    e.Graphics.DrawLine(p, point5, point6);
                    z += 26;
                }
                foreach (var x in _lstHoaDonCT)
                {

                    e.Graphics.DrawString($"{x.TenDichVu}", new Font("Arial", 10, FontStyle.Bold), Brushes.Blue, new Point(100, z +  25));

                    e.Graphics.DrawString($"{x.DonGia}", new Font("Arial", 10, FontStyle.Bold), Brushes.Blue, new Point(300, z +  25));

                    e.Graphics.DrawString($"{x.SoLuongDichVu}", new Font("Arial", 10, FontStyle.Bold), Brushes.Blue, new Point(500, z +  25));

                    e.Graphics.DrawString($"{x.DonGia}", new Font("Arial", 10, FontStyle.Bold), Brushes.Blue, new Point(700, z + 25));
                    Point point7 = new Point(50, z  + 50);
                    Point point8 = new Point(800, z + 50);
                    e.Graphics.DrawLine(p, point7, point8);
                    z += 50;
                }


                //foreach (var x in _lstGiaPhong)
                //{
                //    e.Graphics.DrawString($"{x.TenLoaiPhong}"  , new Font("Arial", 10, FontStyle.Bold), Brushes.Blue, new Point(10, 460));
                //}


                //e.Graphics.DrawString("---------------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(10, 460));



                //foreach (var y in _lstHoaDonCT)
                //{

                //    e.Graphics.DrawString($"\t\t          {y.TenDichVu}\t\t       { y.DonGia}\t\t\t      { y.SoLuongDichVu}\t\t             {y.DonGia}" , new Font("Arial", 10, FontStyle.Bold), Brushes.Blue, new Point(10, z));
                //    z += 40;
                //}
                //e.Graphics.DrawString("\t\t         --------------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 9, FontStyle.Regular), Brushes.Red, new Point(10, 500 + _lstGiaPhong.Count * 40 + _lstHoaDonCT.Count * 40 ));
                e.Graphics.DrawString("\t\t\t Tổng Tiền : " + tongTien.ToString() + " VNĐ", new Font("Arial", 25, FontStyle.Regular), Brushes.Red, new Point(10, z + _lstGiaPhong.Count * 25 + _lstHoaDonCT.Count * 25 + 25));




            }

        }

        private void btn_HuySuaChucVu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_inHD_Click(object sender, EventArgs e)
        {
            PrintDialog prd = new PrintDialog();
                prd.Document = printDocument1;
                DialogResult dls = prd.ShowDialog();
                if(dls == DialogResult.OK)
                {
                    printDocument1.Print();
                }
        }
    }
}
