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
using BUS.Ultilities;

namespace GUI.View.AddControls
{
    public partial class FrmBtnThemNhanVien : Form
    {
        public send_nv _send;
        IQLNhanVienServices _iqLNhanVien;
        IChucVuService _iqLChucVu;
        Validations VAL;
        public FrmBtnThemNhanVien()
        {
            InitializeComponent();
            _iqLNhanVien = new QLNhanVienServices();
            _iqLChucVu= new ChucVuService();
            loadcbo();
        }
        public FrmBtnThemNhanVien(send_nv send)
        {
            InitializeComponent();
            VAL= new Validations();
            _send = send;
            _iqLNhanVien = new QLNhanVienServices();
            _iqLChucVu = new ChucVuService();
            txt_maNV.Visible= false;
            pictureBox8.Visible= false;
            loadcbo();
        }
        public void loadcbo()
        {
            
            foreach( var item in _iqLChucVu.GetAll())
            {
                cbo_chucvuNV.Items.Add(item.TenCV);
            }
            cbo_gioitinhNV.Items.Add("Nam");
            cbo_gioitinhNV.Items.Add("Nữ");
            cbo_gioitinhNV.Items.Add("Khác");
            
        }
        private void btn_ThemKH_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thêm nhân viên này không", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {

                if (VAL.CheckSDT(txt_sdtNV.Text) == false)
                {
                    MessageBox.Show("Số điện thoại không hợp lệ");
                }
                else if (VAL.CheckCCCD(txt_cccdNV.Text) == false)
                {
                    MessageBox.Show("Số căn cước công dân không hợp lệ");
                }

                else if (VAL.CheckRong(txt_tenNV.Text) == false || VAL.CheckRong(txt_diachiNV.Text)==false || VAL.CheckRong(txt_luongNV.Text.ToString())==false)

                {
                    MessageBox.Show("Vui Lòng nhập đầy đủ thông tin");
                } else
                {
                    var somnv=_iqLNhanVien.GetAll().OrderBy(p=>p.MaNV).Select(p=>p.MaNV).ToList();

                    NhanVienView nhanVienView = new NhanVienView();

                    nhanVienView.ID = Guid.NewGuid();
                    if(somnv.Count == 0)
                    {
                        nhanVienView.MaNV = "NV1";
                    }
                    else
                    {
                        int sodnv = somnv.Max(p => Convert.ToInt32(p.Substring(2, p.Length - 2))) + 1;
                        nhanVienView.MaNV = "NV" + sodnv.ToString();
                    }
                    //nhanVienView.MaNV = txt_maNV.Text;
                    nhanVienView.TenNV = txt_tenNV.Text;
                    nhanVienView.CCCD = txt_cccdNV.Text;
                    nhanVienView.NgaySinh = DateTime.Parse(dte_ngaysinhNV.Text);
                    nhanVienView.GioiTinh = (cbo_gioitinhNV.Text == "Nam") ? 1 : (cbo_gioitinhNV.Text == "Nữ") ? 2 : 3;
                    nhanVienView.SDT = txt_sdtNV.Text;
                    nhanVienView.DiaChi = txt_diachiNV.Text;
                    nhanVienView.Luong = int.Parse(txt_luongNV.Text);
                    nhanVienView.IDCv = _iqLChucVu.GetAll().FirstOrDefault(c => c.TenCV == cbo_chucvuNV.Text).ID;
                    nhanVienView.TenCV = cbo_chucvuNV.Text;
                    MessageBox.Show(_iqLNhanVien.Add(nhanVienView));
                    _send(_iqLNhanVien.GetAll());
                }

                
            }
        }

        private void btn_HuyThemKH_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
