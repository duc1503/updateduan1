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
using BUS.Ultilities;
using GUI.View.UserControls;

namespace GUI.View.AddControls
{
    public partial class FrmBtnThemTienNghi : Form
    {
        private send_cttn _send;
        private IQLChiTietTienNghiService _iqlCTTNService;
        private IQLLoaiTienNghiService _iqlLoaiTNService;
        private IQLPhongService _iqLPhongService;
        private Validations val;
     
        public FrmBtnThemTienNghi(send_cttn send)
        {
            InitializeComponent();
            _send = send;
            _iqlCTTNService = new QLChiTietTienNghiService();
            _iqlLoaiTNService = new QLLoaiTienNghiService();
            _iqLPhongService = new IPhongService();
            val = new Validations();
            LoadDataCBB();
        }

        private void LoadDataCBB()
        {
            var lstLoaiPhong = _iqlLoaiTNService.GetAll();
            cbb_TenLoaiTienNghi.Items.Clear();
            foreach (var item in lstLoaiPhong)
            {
                cbb_TenLoaiTienNghi.Items.Add(item.TenLoaiTienNghi);
            }

            var lstMaPhong = _iqLPhongService.GetAll();
            cbb_MaPhong.Items.Clear();
            foreach (var item in lstMaPhong)
            {
                cbb_MaPhong.Items.Add(item.MaPhong);
            }

        }

        private void btn_ThemCTTienNghi_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thêm tiện nghi này không ? ", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (val.CheckRong(tb_MaCTTNThem.Text) == false||val.CheckRong(tb_TenCTTNThem.Text)==false)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo");
                    return;
                }
                ChiTietTienNghiView ctnv = new ChiTietTienNghiView();
                ctnv.MaCTTienNghi = tb_MaCTTNThem.Text;
                ctnv.TenCTTienNghi = tb_TenCTTNThem.Text;
                ctnv.IDLoaiTienNghi = _iqlLoaiTNService.GetIdByName(cbb_TenLoaiTienNghi.Text);

                if (cbb_MaPhong.Text=="" || cbb_MaPhong.Text == "Mã phòng")
                {
                    ctnv.IdPhong = null;
                }
                else
                {
                    ctnv.IdPhong = _iqlCTTNService.GetIdByRoomCode(cbb_MaPhong.Text);
                }
                
                MessageBox.Show(_iqlCTTNService.Add(ctnv));
                _send(_iqlCTTNService.GetAll());

            }
            if (result == DialogResult.No)
            {
                MessageBox.Show("Bạn đã hủy thêm tiện nghi");
            }
        }

        private void FrmBtnThemTienNghi_Load(object sender, EventArgs e)
        {

        }

        private void btn_HuyThemCTTienNghi_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
