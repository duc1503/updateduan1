using BUS.IServices;
using BUS.Services;
using BUS.ViewModels;
using GUI.View.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.View.AddControls
{
    public partial class FrmTrangThaiPhong : Form
    {
        public FrmPhong _main;
        public string MaPhong { get; set; }
        public string TenKH { get; set; }
        public Guid IdPTCT { get; set; }
        private List<DichVuView> lstDVV;
 

        private IQLChiTietPhieuThueService _iqlCTPTService;
        private IQLPhongService _iqlPhongService;
        private IHoaDonService _iqlHDService;
        private IQLDichVuService _iqlDVService;
        private IQLHoaDonChiTietView _iqlHDCTService;
        public FrmTrangThaiPhong(FrmPhong main)
        {
            InitializeComponent();
            _iqlCTPTService = new QLChiTietPhieuThueService();
            _iqlPhongService = new IPhongService();
            _iqlHDService = new HoaDonService();
            _iqlDVService = new QLDichVuService();
            _iqlHDCTService = new QLHoaDonChiTietView();
            lstDVV = new List<DichVuView>();
            LoadDataCbbDV();
            LoadDataListDichVu();
            _main = main;
        }
        // truyền ngày BD và ngày ngày KT load lên form
        // dựa theo đó làm chức năng nhận phòng
        // chuyển trạng thái phòng từ xám => đỏ =  sự kiện click button Nhận phòng
        // chuyển trạng thái từ đỏ => vàng = sự kiện click butotn thanh toán
        private void FrmTrangThaiPhong_Load(object sender, EventArgs e)
        {
            dtp_NgayBatDau.Format = DateTimePickerFormat.Custom;
            dtp_NgayBatDau.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            dtp_NgayKetThuc.Format = DateTimePickerFormat.Custom;
            dtp_NgayKetThuc.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            lb_MaPhong.Text = MaPhong;
            lb_TenKH.Text = TenKH;
            if (IdPTCT == Guid.Empty)
            {
                dtp_NgayBatDau.Value = DateTime.Now;
                dtp_NgayKetThuc.Value = DateTime.Now;
                return;
            }
            else
            {
                dtp_NgayBatDau.Value = _iqlCTPTService.GetAll().FirstOrDefault(p => p.ID == IdPTCT).NgayBatDau;
                dtp_NgayKetThuc.Value = _iqlCTPTService.GetAll().FirstOrDefault(p => p.ID == IdPTCT).NgayKetThuc;
            }        
        }

        private void btn_NhanPhong_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn nhận phòng cho khách hàng này không ? ", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (IdPTCT == null)
                {
                    MessageBox.Show("Vui lòng đặt 1 phòng trước khi nhận phòng");
                    return;
                }               
                HoaDonView hdv = new HoaDonView();
                //hdv.MaHD = "HD1";
                var lstMaHD = _iqlHDService.GetAll();
                var soMaHD = _iqlHDService.GetAll().Select(p => p.MaHD).ToList();
                if (soMaHD.Count == 0)
                {
                    hdv.MaHD = "HD1";
                }    
                else
                {
                    int STTHD = lstMaHD.Max(p => Convert.ToInt32(p.MaHD.Substring(2, p.MaHD.Length - 2)) + 1);
                    hdv.MaHD = "HD" + STTHD;
                }             
                hdv.TrangThai = 0;
                hdv.NgayTT = null;
                hdv.NgayTaoHD = DateTime.Now;
                hdv.IdCTPhieuThue = IdPTCT;
                if (_iqlPhongService.GetAll().FirstOrDefault(p => p.MaPhong == MaPhong).TinhTrang != 3)
                {
                    MessageBox.Show("Bạn không thể nhận phòng này vì phòng này chưa có ai thuê !!");
                    return;
                }
                MessageBox.Show(_iqlHDService.Add(hdv));
                
                // Sau khi nhan phong => update trang thai phong = co khach dang thue
                PhongView pv = new PhongView();
                pv.Id = _iqlCTPTService.GetAll().FirstOrDefault(p => p.ID == IdPTCT).IdPhong;
                pv.MaPhong = MaPhong;
                pv.IDLoaiPhong = _iqlPhongService.GetAll().FirstOrDefault(p => p.MaPhong == MaPhong).IDLoaiPhong;
                pv.TinhTrang = 1;
                _iqlPhongService.Update(pv);
                _main.LoadItemRooms_search(_iqlPhongService.GetAll());
                MessageBox.Show("Nhận phòng thành công");
            }
            if (result == DialogResult.No)
            {
                MessageBox.Show("Bạn vừa hủy nhận phòng này");
            }
        }

        private void LoadDataListDichVu()
        {
            dtg_DSDichVu.ColumnCount = 4;
            dtg_DSDichVu.Rows.Clear();
            dtg_DSDichVu.Columns[0].Name = "ID dịch vụ";
            dtg_DSDichVu.Columns[0].Visible = false;
            dtg_DSDichVu.Columns[1].Name = "Mã dịch vụ";
            dtg_DSDichVu.Columns[2].Name = "Tên dịch vụ";
            dtg_DSDichVu.Columns[3].Name = "Giá dịch vụ";

            foreach (var x in lstDVV)
            {
                dtg_DSDichVu.Rows.Add(x.Id, x.MaDichVu, x.TenDichVu, x.Gia, x.IDLoaiDichVu, x.TenLoaiDV);
            }
        }
        private void LoadDataCbbDV()
        {
            var lstDichVu = _iqlDVService.GetAll();
            cbb_TenDV.Items.Clear();
            //cbb_TenDV.SelectedIndex = 0;
            foreach (var item in lstDichVu)
            {
                cbb_TenDV.Items.Add(item.TenDichVu);
            }
        }

        private void cbb_TenDV_SelectedValueChanged(object sender, EventArgs e)
        {
            var idDVChoose = _iqlDVService.GetIdDvByName(cbb_TenDV.Text);
            var DVChoose = _iqlDVService.GetAll().FirstOrDefault(p => p.Id == idDVChoose);
            tb_GiaTienDV.Text = DVChoose.Gia.ToString();
        }

        // Frm này sẽ hiển thị danh sách dịch vụ
        // click button thêm dịch vụ sẽ thêm dịch vụ vào 1 list tạm thời
        // Bấm lưu để chạy hàm Tạo hóa đơn chi tiết với các dịch vụ đã chọn. Nếu lst = null thì vẫn ghi lưu thành công
        // Sau đó click button thanh toán để chạy sự kiện btn thanh toán click
        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            // clicl button này sẽ hiển thị lên FrmPrintHoaDon
            // FrmPrintHoaDon sẽ hiển thị lên giá tiền của phòng đã thuê, số dịch vụ đã sử dụng
            // Mỗi phòng sẽ chỉ có 1 hóa đơn duy nhất == Mỗi CPPT sẽ có 1 hóa đơn cho riêng nó
            if (_iqlPhongService.GetAll().FirstOrDefault(p => p.MaPhong == MaPhong).TinhTrang != 1)
            {
                MessageBox.Show("Bạn không thể xem hóa đơn của phòng này vì phòng này chưa có khách sử dụng !!");
                return;
            }
            FrmViewHDCT frmViewHoaDon = new FrmViewHDCT(_main);
            frmViewHoaDon._lstHoaDonCT = _iqlHDService.GetCTHoaDon(_iqlHDService.GetAll().FirstOrDefault(p => p.IdCTPhieuThue == IdPTCT).Id);
            frmViewHoaDon._lstHoaDon = _iqlHDService.GetListHD(_iqlHDService.GetAll().FirstOrDefault(p => p.IdCTPhieuThue == IdPTCT).Id);
            frmViewHoaDon._lstGiaPhong = _iqlHDService.GetCTPhong(_iqlHDService.GetAll().FirstOrDefault(p => p.IdCTPhieuThue == IdPTCT).Id);
            frmViewHoaDon.NgayThanhToanHD = DateTime.Now;
            frmViewHoaDon.IdPTCTEdit = IdPTCT;
            frmViewHoaDon.ShowDialog();
        }

        //private void AddDVToFlexList(Guid idDVChoose)
        //{
        //    var DVChoose = _iqlDVService.GetAll().FirstOrDefault(p => p.Id == idDVChoose);
        //    var DVinListFlex = lstDVV.FirstOrDefault(p => p.Id == DVChoose.Id);
        //    if (DVinListFlex == null)
        //    {
        //        lstDVV.Add(DVinListFlex);
        //    }
        //}

        private void btn_ThemDichVu_Click(object sender, EventArgs e)
        {
            if (cbb_TenDV.Text == "")
            {
                MessageBox.Show("Vui lòng chọn dịch vụ muốn sử dụng !");
                return;
            }
            for (int i = 1; i <= Convert.ToInt32(tb_SL.Value); i++)
            {
                var idDVChoose = _iqlDVService.GetIdDvByName(cbb_TenDV.Text);
                var DVChoose = _iqlDVService.GetAll().FirstOrDefault(p => p.Id == idDVChoose);
                lstDVV.Add(DVChoose);               
            }
            LoadDataListDichVu();
        }

        private void btn_LuuDichVu_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có xác nhận muốn sử dụng các dịch vụ đã chọn không ? Lưu ý dịch vụ sau khi chọn sẽ không thế hoàn tác", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (IdPTCT == null)
                {
                    MessageBox.Show("Vui lòng đặt 1 phòng để có thể sử dụng các dịch vụ của khách sạn !");
                    return;
                }
                if (_iqlPhongService.GetAll().FirstOrDefault(p => p.MaPhong == MaPhong).TinhTrang != 1)
                {
                    MessageBox.Show("Bạn không thể sử dụng dịch vụ vì chưa nhận phòng !!");
                    return;
                }
                // null here
                //foreach (var item in lstDVV)
                //{               
                //    if (_iqlHDCTService.GetAll().FirstOrDefault(p => p.IdDichVu == item.Id) == null)
                //    {
                //        HoaDonChiTietView hdctv = new HoaDonChiTietView();
                //        hdctv.IdHoaDon = _iqlHDService.GetAll().FirstOrDefault(p => p.IdCTPhieuThue == IdPTCT).Id;
                //        hdctv.SoLuong = 1;
                //        hdctv.DonGia = item.Gia;
                //        hdctv.IdDichVu = item.Id;
                //        MessageBox.Show(_iqlHDCTService.Add(hdctv));
                //    }
                //    else if (_iqlHDCTService.GetAll().FirstOrDefault(p => p.IdDichVu == item.Id) != null)
                //    {
                //        HoaDonChiTietView hdctv = new HoaDonChiTietView();
                //        hdctv.IdHoaDon = _iqlHDService.GetAll().FirstOrDefault(p => p.IdCTPhieuThue == IdPTCT).Id;
                //        var slHdct = _iqlHDCTService.GetAll().FirstOrDefault(p => p.IdDichVu == item.Id);
                //        int soMax = slHdct.SoLuong + 1;
                //        hdctv.SoLuong =  soMax;
                //        hdctv.DonGia = item.Gia;
                //        hdctv.IdDichVu = item.Id;
                //        MessageBox.Show(_iqlHDCTService.Update(hdctv));
                //    }

                //}
                //

                int SoLuongThem = lstDVV.Count;
                foreach (var item in lstDVV)
                {
                    var idHD = _iqlHDService.GetAll().FirstOrDefault(p => p.IdCTPhieuThue == IdPTCT).Id;
                    if (_iqlHDCTService.GetAll().FirstOrDefault(p => p.IdDichVu == item.Id && p.IdHoaDon == idHD) == null)
                    {
                        HoaDonChiTietView hdctv = new HoaDonChiTietView();
                        hdctv.IdHoaDon = _iqlHDService.GetAll().FirstOrDefault(p => p.IdCTPhieuThue == IdPTCT).Id;
                        hdctv.SoLuong = Convert.ToInt32(tb_SL.Value);
                        hdctv.DonGia = item.Gia;
                        hdctv.IdDichVu = item.Id;
                        _iqlHDCTService.Add(hdctv);
                        //MessageBox.Show("TH1");
                        MessageBox.Show("Thêm thành công");
                        return;
                    }
                    else if (_iqlHDCTService.GetAll().FirstOrDefault(p => p.IdDichVu == item.Id && p.IdHoaDon == idHD) != null)
                    {
                        HoaDonChiTietView hdctv = new HoaDonChiTietView();
                        hdctv.IdHoaDon = _iqlHDService.GetAll().FirstOrDefault(p => p.IdCTPhieuThue == IdPTCT).Id;
                        hdctv.IdDichVu = item.Id;
          
                        var slHdct = _iqlHDCTService.GetAll().FirstOrDefault(p => p.IdDichVu == item.Id && p.IdHoaDon == idHD);
                        int soMax = slHdct.SoLuong;
                        //hdctv.SoLuong = soMax;
                        hdctv.SoLuong = soMax + Convert.ToInt32(tb_SL.Value);  
                        hdctv.DonGia = item.Gia;
                        _iqlHDCTService.Update(hdctv);
                        MessageBox.Show("Thêm thành công");                 
                        return;
                    }

                }

            }
            if (result == DialogResult.No)
            {
                List<DichVuView> lstEmpty = new List<DichVuView>();
                lstDVV = lstEmpty;
                MessageBox.Show("Bạn đã hủy toàn bộ dịch vụ đã chọn");
            }
        }


        private void btn_ChuyenTTPhongTrong_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Vui lòng xác nhận chuyển trạng thái về phòng trống", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                PhongView pv = new PhongView();
                pv.Id = _iqlPhongService.GetAll().FirstOrDefault(p => p.MaPhong == MaPhong).Id;
                pv.MaPhong = MaPhong;
                pv.IDLoaiPhong = _iqlPhongService.GetAll().FirstOrDefault(p => p.MaPhong == MaPhong).IDLoaiPhong;
                pv.TinhTrang = 0;

                if (_iqlPhongService.GetAll().FirstOrDefault(p => p.MaPhong == MaPhong).TinhTrang != 2)//2
                {
                    MessageBox.Show("Bạn không thể chuyển trạng thái phòng này vì phòng này đang có khách thuê !! hoặc phòng đang trống");
                    return;
                }
                _iqlPhongService.Update(pv);
                _main.LoadItemRooms_search(_iqlPhongService.GetAll());
                MessageBox.Show("Chuyển trạng thái thành công");
            }
            if (result == DialogResult.No)
            {
                MessageBox.Show("Bạn đã hủy thay đổi trạng thái phòng này !");
            }
            //FrmPhong frmPhong = new FrmPhong();
            //frmPhong.FrmPhong_Load(object sender, EventArgs e);
        
        }
        private void btn_HuyLuuDV_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
