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

    public partial class FrmBtnThemLoaiPhong : Form
    {
        public send_Lphong _send;
        private IQLLoaiPhongService _iqlLoaiPhongService;
        public FrmBtnThemLoaiPhong()
        {
            InitializeComponent();
            _iqlLoaiPhongService = new ILoaiPhongService();
        }
        public FrmBtnThemLoaiPhong(send_Lphong send)
        {
            InitializeComponent();
            _send = send;
            _iqlLoaiPhongService = new ILoaiPhongService();
        }

        private void btn_ThemLoaiPhong_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thêm loại phòng này không?", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                var lpv = new LoaiPhongView()
                {
                    ID = Guid.NewGuid(),
                    TenLoaiPhong = tb_TenLoaiPhong.Text,
                    MaLoaiPhong = tb_MaLoaiPhong.Text,
                    SoGiuong = int.Parse(tb_SoGiuong.Text),
                    GiaNgay = int.Parse(tb_GiaNgay.Text)
                };
                MessageBox.Show(_iqlLoaiPhongService.Add(lpv));
                _send(_iqlLoaiPhongService.GetAll());
            }
            else
            {
                MessageBox.Show("Bạn đã không thên loại phòng này");
            }
        }

        private void btn_HuyThemLoaiPhong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
