using BUS.IServices;
using BUS.Services;
using BUS.ViewModels;
using DAL.Models;
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
    public partial class FrmBtnSuaKH : Form
    {
        public send_kh _send;
        private IQLKhachHangService _iQLKhachHangService;

        private Validations val;

        public Guid IdKH { get; set; }
        public string MaKH { get; set; }
        public string HoTenKH { get; set; }
        public string CCCDKH { get; set; }
        public string SDTKH { get; set; }
        public string DiaChiKH { get; set; }
        public string GioiTinhKH { get; set; }
        public string QuocTich { get; set; }
        public FrmBtnSuaKH()
        {
            InitializeComponent();
            _iQLKhachHangService = new QLKhachHangService();
        }
        public FrmBtnSuaKH(send_kh send)
        {
            InitializeComponent();
            this._send = send;
            _iQLKhachHangService = new QLKhachHangService();
            val= new Validations();
        }

        private void btn_SuaKH_Click(object sender, EventArgs e)
        {
            DialogResult hoi = MessageBox.Show("Bạn có chắc chắn sửa khách hàng này không ?", "Thông báo", MessageBoxButtons.YesNo);
            if (hoi == DialogResult.Yes)
            {
                if (val.CheckRong(tbt_CCCD.Text) == false||val.CheckRong(tbt_DiaChiKH.Text)==false||val.CheckRong(tbt_SDTKh.Text)==false||val.CheckRong(cbb_GioiTinh.Text)==false||val.CheckRong(tbt_HoTenKH.Text)==false)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo");
                    return;
                } else if (val.CheckSDT(tbt_CCCD.Text) == false)
                {
                    MessageBox.Show("Căn cước công dân không hợp lệ, vui lòng nhập lại", "Thông báo");
                    return;
                } else if(val.CheckSDT(tbt_SDTKh.Text).Equals(false))
                {
                    MessageBox.Show("Số điện thoại không hợp lệ, Vui lòng nhập lại");
                    return;
                }

                KhachHangView khN = new KhachHangView();
                khN.ID = IdKH;
                khN.MaKH = tbt_MaKh.Text;
                khN.HovaTen = tbt_HoTenKH.Text;
                khN.CCCD = tbt_CCCD.Text;
                khN.SDT = tbt_SDTKh.Text;
                khN.GioiTinh = cbb_GioiTinh.Text == "Nam" ? 1 : cbb_GioiTinh.Text == "Nữ" ? 2 : 3;
                khN.QuocTich = tbt_QuocTichKH.Text;
                khN.DiaChi = tbt_DiaChiKH.Text;
                MessageBox.Show(_iQLKhachHangService.Update(khN));
                _send(_iQLKhachHangService.GetAll());
            }
            else
            {
                MessageBox.Show("Bạn đã hủy sửa khách hàng này");
            }
        }

        private void FrmBtnSuaKH_Load(object sender, EventArgs e)
        {
            tbt_MaKh.Text = MaKH;
            tbt_HoTenKH.Text = HoTenKH;
            tbt_CCCD.Text = CCCDKH;
            tbt_SDTKh.Text = SDTKH;
            tbt_DiaChiKH.Text = DiaChiKH;
            cbb_GioiTinh.Text = GioiTinhKH;
            tbt_QuocTichKH.Text = QuocTich;
        }

        private void btn_HuySuaKH_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
