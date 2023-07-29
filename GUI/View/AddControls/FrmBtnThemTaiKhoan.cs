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
    public partial class FrmBtnThemTaiKhoan : Form
    {
        public send_tk _send;
        IQLTaiKhoanServices _iqLTaiKhoan;
        IQLNhanVienServices _iqLNhanVien;
        Validations VAL;

        public string? TenNV { get; set; }
        public FrmBtnThemTaiKhoan(send_tk send )
        {
            InitializeComponent();
            this._send= send;
            _iqLNhanVien = new QLNhanVienServices();
            _iqLTaiKhoan = new QLTaiKhoanServices();
            VAL = new Validations();
            loadcbb(_iqLNhanVien.GetAll());
        }
        public FrmBtnThemTaiKhoan()
        {
            InitializeComponent();
            _iqLNhanVien = new QLNhanVienServices();
            _iqLTaiKhoan=new QLTaiKhoanServices();
            loadcbb(_iqLNhanVien.GetAll());

        }
        public void loadcbb(List<NhanVienView> list)
        {
             foreach( var item in list.OrderByDescending(c=>c.MaNV))
            {
                cbo_maNV.Items.Add(item.MaNV);
            }
            cbb_capdoquyenTK.Items.Add("1");
            cbb_capdoquyenTK.Items.Add("2");
            cbb_capdoquyenTK.Items.Add("3");
        }

        public bool checktrung(string mk1,string mk2)
        {
            if(mk1!=mk2) return false;
            else return true;
        }
        

        private void btn_ThemTK_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thêm tài khoản này không", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (VAL.CheckRong(txt_tenTK.Text)==false||VAL.CheckRong(txt_matkhauTK.Text)==false||VAL.CheckRong(txt_nhaplaimatkhauTK.Text)==false)
                {
                    MessageBox.Show("Vui lòng nhập đầu đủ thông tin");
                }
                else
                {
                    if (checktrung(txt_matkhauTK.Text, txt_nhaplaimatkhauTK.Text) == false)
                    {
                        MessageBox.Show("Nhập khẩu nhập lại sai");
                        return;
                    };
                    var tennv = _iqLNhanVien.GetAll().FirstOrDefault(c => c.MaNV == cbo_maNV.Text);

                    TaiKhoanView taiKhoanView = new TaiKhoanView();
                    if (cbo_maNV.Text == "" || cbo_maNV.Text == "Chọn mã nhân viên")
                    {
                        taiKhoanView.IDNv = null;
                        taiKhoanView.TenNV = null;
                    }
                    else
                    {
                        taiKhoanView.IDNv = _iqLNhanVien.GetAll().FirstOrDefault(c => c.MaNV == cbo_maNV.Text).ID;
                        taiKhoanView.TenNV = _iqLNhanVien.GetAll().FirstOrDefault(c => c.MaNV == cbo_maNV.Text).TenNV;
                    }
                    taiKhoanView.ID = Guid.NewGuid();

                    taiKhoanView.TenTaiKhoan = txt_tenTK.Text;
                    taiKhoanView.MatKhau = txt_matkhauTK.Text;
                    taiKhoanView.CapDoQuyen = int.Parse(cbb_capdoquyenTK.Text);

                    MessageBox.Show(_iqLTaiKhoan.Add(taiKhoanView));
                    _send(_iqLTaiKhoan.GetAll());
                }
                
                
            }
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
