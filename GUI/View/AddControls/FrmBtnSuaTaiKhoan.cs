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

    public partial class FrmBtnSuaTaiKhoan : Form
    {
        public send_tk _send;
        IQLTaiKhoanServices _iqLTaiKhoan;
        IQLNhanVienServices _iqLNhanVien;
        public Guid ID ;
        public string TenTaiKhoan ;
        public string MatKhau ;
        public int CapDoQuyen ;
        public Guid? IDNv ;
        public string? TenNV;
        public string MaNv;
        public FrmBtnSuaTaiKhoan()
        {
            InitializeComponent();
            _iqLNhanVien = new QLNhanVienServices();
            _iqLTaiKhoan = new QLTaiKhoanServices();
            txt_maNV.Enabled= false;
            txt_tenTK.Enabled= false;
            loadcbocapdoquyen();
        }
        public FrmBtnSuaTaiKhoan(send_tk send)
        {
            InitializeComponent();
            this._send = send;
            _iqLNhanVien = new QLNhanVienServices();
            _iqLTaiKhoan = new QLTaiKhoanServices();
            txt_maNV.Enabled = false;
            txt_tenTK.Enabled = false;
            loadcbocapdoquyen();
        }

        public void loadcbocapdoquyen()
        {
            cbb_capdoquyenTK.Items.Add("1");
            cbb_capdoquyenTK.Items.Add("2");
            cbb_capdoquyenTK.Items.Add("3");
        }
        private void FrmBtnSuaTaiKhoan_Load(object sender, EventArgs e)
        {
            
            txt_tenTK.Text = TenTaiKhoan;
            cbb_capdoquyenTK.Text=CapDoQuyen.ToString();
            txt_matkhaucuTK.Text=MatKhau.ToString();
            txt_maNV.Text=MaNv;
        }

        private void btn_capnhatTK_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn cập nhật nhân viên này không", "Thông Báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                TaiKhoanView taiKhoanView = new TaiKhoanView();
                taiKhoanView.ID = ID;

                //taiKhoanView.IDNv= IDNv;
                taiKhoanView.MatKhau = txt_matkhaucuTK.Text;
                taiKhoanView.CapDoQuyen = int.Parse(cbb_capdoquyenTK.Text);
                // taiKhoanView.TenNV = TenNV;
                taiKhoanView.TenTaiKhoan = txt_tenTK.Text;
                MessageBox.Show(_iqLTaiKhoan.Update(taiKhoanView));
                _send(_iqLTaiKhoan.GetAll());
                
            }
        }

        private void btn_huy(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
