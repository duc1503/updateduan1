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
    public partial class FrmBtnThemPhong : Form
    {
        public send_phong _send;
        private IQLPhongService _iqlPhongService;
        private IQLLoaiPhongService _iqlLoaiPhongService;
        private Validations val;
        public FrmBtnThemPhong()
        {
            InitializeComponent();
            _iqlPhongService = new IPhongService();
            _iqlLoaiPhongService = new ILoaiPhongService();

            LoadDataCbb();
        }
        public FrmBtnThemPhong(send_phong send)
        {
            InitializeComponent();
            this._send = send;
            _iqlPhongService = new IPhongService();
            _iqlLoaiPhongService = new ILoaiPhongService();
            val= new Validations();

            LoadDataCbb();
        }

        private void LoadDataCbb()
        {
            var lstLoaiPhong = _iqlLoaiPhongService.GetAll();
            cbb_TenLoaiPhong.Items.Clear();
            foreach (var item in lstLoaiPhong)
            {
                cbb_TenLoaiPhong.Items.Add(item.TenLoaiPhong);
            }

            cbb_TinhTrangPhong.Items.Clear();
            cbb_TinhTrangPhong.Items.Add("Phòng trống");
            cbb_TinhTrangPhong.Items.Add("Phòng có khách");
            cbb_TinhTrangPhong.Items.Add("Phòng đang dọn dẹp");
        }

        private void btn_ThemPhong_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thêm loại phòng không ? ", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if(val.CheckRong(tb_MaPhongThem.Text)==false)
                {
                    MessageBox.Show("vui lòng nhập đầy đủ thông tin", "Thông báo");
                    return;
                }

                PhongView pv = new PhongView();
                pv.MaPhong = tb_MaPhongThem.Text;
                if (cbb_TinhTrangPhong.Text == "Phòng có khách")
                {
                    MessageBox.Show("Bạn không thể thêm phòng với trạng thái có khách đang thuê");
                    return;
                }
                pv.TinhTrang = cbb_TinhTrangPhong.Text == "Phòng trống" ? 0 : cbb_TinhTrangPhong.Text == "Phòng có khách" ? 1 : 2;
                pv.IDLoaiPhong = _iqlPhongService.GetIdLoaiPhongByName(cbb_TenLoaiPhong.Text);

                MessageBox.Show(_iqlPhongService.Add(pv));
                _send(_iqlPhongService.GetAll());
            }
            if (result == DialogResult.No)
            {
                MessageBox.Show("Bạn đã hủy thêm loại phòng");
            }
        }

        private void btn_HuyThemPhong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
