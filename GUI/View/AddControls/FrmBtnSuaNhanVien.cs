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
using GUI.View.AddControls;
using GUI.View.UserControls;
using BUS.Ultilities;


namespace GUI.View.AddControls
{
    public partial class FrmBtnSuaNhanVien : Form
    {
        public send_nv _send;
        IQLNhanVienServices _iqLNhanVien;
        IChucVuService _iqLChucVu;
        Validations VAL;

        public Guid ID { get; set; }
        public string MaNV { get; set; }
        public string TenNV { get; set; }
        public DateTime NgaySinh { get; set; }
        public int GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public string SDT { get; set; }
        public string CCCD { get; set; }
        public int Luong { get; set; }
        public Guid IDCv { get; set; }
        public string TenCV { get; set; }
        public FrmBtnSuaNhanVien()
        {
            InitializeComponent();
            _iqLNhanVien= new QLNhanVienServices();
            _iqLChucVu= new ChucVuService();
            loadcbb(_iqLChucVu.GetAll());
            
        }
        public FrmBtnSuaNhanVien(send_nv send)
        {
            InitializeComponent();
            this._send = send;
            _iqLNhanVien = new QLNhanVienServices();
            _iqLChucVu = new ChucVuService();
            loadcbb(_iqLChucVu.GetAll());
            VAL = new Validations();
        }

        public void loadcbb(List<ChucVuView> list)
        {
            foreach (var item in list)
            {
                cbo_chucvuNV.Items.Add(item.TenCV);
            }
            cbo_gioitinhNV.Items.Add("Nam");
            cbo_gioitinhNV.Items.Add("Nữ");
            cbo_gioitinhNV.Items.Add("Khác");
        }
        private void FrmBtnSuaNhanVien_Load(object sender, EventArgs e)
        {
            txt_tenNV.Text = TenNV;
            cbo_gioitinhNV.Text = (GioiTinh==1)?"Nam":(GioiTinh==2)?"Nữ":"Khác";
            txt_luongNV.Text = Luong.ToString();
            txt_sdtNV.Text=SDT.ToString();
            txt_cccdNV.Text = CCCD.ToString();
            dte_ngaysinhNv.Text=NgaySinh.ToString();
            cbo_chucvuNV.Text = TenCV;
            txt_diachiNV.Text = DiaChi;
        }

        private void btn_SuaNV_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn cập nhật nhân viên này không", "Thông Báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                    
                    Guid IDCV = _iqLChucVu.GetAll().FirstOrDefault(c => c.TenCV == cbo_chucvuNV.Text).ID;
                    NhanVienView nhanVienView = new NhanVienView();
                    nhanVienView.ID = ID;
                    nhanVienView.MaNV = MaNV;
                    nhanVienView.IDCv = IDCV;
                    nhanVienView.TenNV = txt_tenNV.Text;
                    nhanVienView.NgaySinh = DateTime.Parse(dte_ngaysinhNv.Text.ToString());
                    nhanVienView.CCCD = txt_cccdNV.Text;
                    nhanVienView.TenCV = cbo_chucvuNV.Text;
                    nhanVienView.GioiTinh = (cbo_gioitinhNV.Text == "Nam") ? 1 : (cbo_gioitinhNV.Text == "Nữ") ? 2 : 3;
                    nhanVienView.SDT = txt_sdtNV.Text;
                    nhanVienView.DiaChi = txt_diachiNV.Text;
                    nhanVienView.Luong = Convert.ToInt32(txt_luongNV.Text);
                    MessageBox.Show(_iqLNhanVien.Update(nhanVienView));
                    this._send(_iqLNhanVien.GetAll());
            }
        }

        private void btn_HuySuaNV_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
