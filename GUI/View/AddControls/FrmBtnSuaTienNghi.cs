using BUS.IServices;
using BUS.Services;
using BUS.ViewModels;
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
    public partial class FrmBtnSuaTienNghi : Form
    {
        private IQLChiTietTienNghiService _iqlCTTNService;
        private IQLLoaiTienNghiService _iqlLoaiTNService;
        private IQLPhongService _iqlPhongService;
        public Guid IdSelect { get; set; }
        public string MaCTTNSelect { get; set; }
        public string TenCTTNSelect { get; set; }
        public string TenLoaiCTTNSelect { get; set; }
        public string MaPhongSelect { get; set; }

        public FrmBtnSuaTienNghi()
        {
            InitializeComponent();
            _iqlCTTNService = new QLChiTietTienNghiService();
            _iqlLoaiTNService = new QLLoaiTienNghiService();
            _iqlPhongService = new IPhongService();

            LoadDataCBB();
        }

        private void LoadDataCBB()
        {
            var lstLtn = _iqlLoaiTNService.GetAll();
            cbb_TenLoaiTienNghi.Items.Clear();
            foreach (var item in lstLtn)
            {
                cbb_TenLoaiTienNghi.Items.Add(item.TenLoaiTienNghi);
            }

            var lstMaPhong = _iqlPhongService.GetAll();
            cbb_MaPhong.Items.Clear();
            foreach (var item in lstMaPhong)
            {
                cbb_MaPhong.Items.Add(item.MaPhong);
            }
        }

        private void btn_SuaCTTienNghi_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn sửa tiện nghi này không ? ", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                ChiTietTienNghiView ctnv = new ChiTietTienNghiView();
                ctnv.ID = IdSelect;
                ctnv.MaCTTienNghi = tb_MaCTTNSua.Text;
                ctnv.TenCTTienNghi = tb_TenCTTNSua.Text;
                ctnv.IDLoaiTienNghi = _iqlLoaiTNService.GetIdByName(cbb_TenLoaiTienNghi.Text);
                ctnv.IdPhong = _iqlCTTNService.GetIdByRoomCode(cbb_MaPhong.Text);
                MessageBox.Show(_iqlCTTNService.Update(ctnv));

            }
            if (result == DialogResult.No)
            {
                MessageBox.Show("Bạn đã hủy sửa tiện nghi");
            }
        }

        private void btn_HuySuaCTTienNghi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmBtnSuaTienNghi_Load(object sender, EventArgs e)
        {
            tb_MaCTTNSua.Text = MaCTTNSelect;
            tb_TenCTTNSua.Text = TenCTTNSelect;
            cbb_TenLoaiTienNghi.Text = TenLoaiCTTNSelect;
            cbb_MaPhong.Text = MaPhongSelect;
        }
    }
}
