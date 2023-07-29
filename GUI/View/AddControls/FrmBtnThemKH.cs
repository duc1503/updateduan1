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
using BUS.Ultilities;
using System.Windows.Forms;

namespace GUI.View.AddControls
{
    public partial class FrmBtnThemKH : Form
    {
        public send_kh _send;
        private Validations val;
        private IQLKhachHangService _iQLKhachHangService;
        
        public FrmBtnThemKH()
        {
            InitializeComponent();
            _iQLKhachHangService = new QLKhachHangService();
            LoadCbb();
        }
        public FrmBtnThemKH(send_kh send)
        {
            InitializeComponent();
            this._send= send;
            _iQLKhachHangService = new QLKhachHangService();
            this._send = send;
            LoadCbb();
            val= new Validations();
            
        }
        private void LoadCbb()
        {
            cbb_GioiTinh.Items.Add("Nam");
            cbb_GioiTinh.Items.Add("Nữ");
        }
        private void btn_ThemKH_Click(object sender, EventArgs e)
        {
            if (val.CheckRong(tbt_CCCD.Text) == false || val.CheckRong(tbt_DiaChiKH.Text) == false || val.CheckRong(tbt_HoTenKH.Text) == false || val.CheckRong(tbt_QuocTichKH.Text) == false || val.CheckRong(tbt_QuocTichKH.Text) == false || val.CheckRong(tbt_SDTKh.Text) == false)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông Báo");
                return;
            } else if (val.CheckSDT(tbt_SDTKh.Text) == false)
            {

            } else if (val.CheckCCCD(tbt_CCCD.Text) == false)
            {
                MessageBox.Show("Căn Cước công dân không hợp lệ, vui lòng nhập lại", "Thông báo");
            }
            DialogResult dls = MessageBox.Show("Bạn có muốn thêm khách hàng này không?", "Thông báo", MessageBoxButtons.YesNo);
            if (dls == DialogResult.Yes)
            {
                var somkh = _iQLKhachHangService.GetAll().OrderBy(p => p.MaKH).Select(p => p.MaKH).ToList();
                
                var kh = new KhachHangView()
                {
                    ID = Guid.NewGuid(),
                    HovaTen = tbt_HoTenKH.Text,
                    //MaKH = tbt_MaKh.Text,
                    CCCD = tbt_CCCD.Text,
                    SDT = tbt_SDTKh.Text,
                    DiaChi = tbt_DiaChiKH.Text,
                    QuocTich = tbt_QuocTichKH.Text,
                    GioiTinh = cbb_GioiTinh.Text == "Nam" ? 1 : cbb_GioiTinh.Text == "Nữ" ? 2 : 3,
                };
                if (somkh.Count == 0)
                {
                    kh.MaKH = "KH1";
                }
                else
                {
                    int soduoima = somkh.Max(p => Convert.ToInt32(p.Substring(2, p.Length - 2))) + 1;
                    kh.MaKH = "KH" + soduoima;
                }
                MessageBox.Show(_iQLKhachHangService.Add(kh));
                _send(_iQLKhachHangService.GetAll());
            }
            else
            {
                MessageBox.Show("Bạn đã không thên khách hàng này");
            }
        }

        private void btn_HuyThemKH_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void tbt_MaKh_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
