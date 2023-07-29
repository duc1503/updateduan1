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
using GUI.View.UserControls;
using BUS.Ultilities;

namespace GUI.View.AddControls
{
    public partial class FrmBtnSuaLoaiDichVu : Form
    {
        public send_ldv _send;
        private IQLLoaiDichVuService _iQLLoaiDichVuService;
        public Guid IdLoaiDichVu { get; set; }

        public string MaLoaiDichVu { get; set; }
        public string TenLoaiDichVu { get; set; }
        public FrmBtnSuaLoaiDichVu()
        {
            InitializeComponent();
            _iQLLoaiDichVuService = new QLLoaiDichVuService();
        }
        public FrmBtnSuaLoaiDichVu(send_ldv send)
        {
            InitializeComponent();
            this._send = send;
            _iQLLoaiDichVuService = new QLLoaiDichVuService();
        }

        private void btn_SuaLoaiDichVu_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn sửa loại dịch vụ này không ?", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                LoaiDichVuView ltn = new LoaiDichVuView();
                ltn.ID = IdLoaiDichVu;
                ltn.MaLoaiDichVu = tb_MaLoaiDichVu.Text;
                ltn.TenLoaiDichVu = tb_TenLoaiDichVu.Text;
                MessageBox.Show(_iQLLoaiDichVuService.Update(ltn));
                _send(_iQLLoaiDichVuService.GetAll());
            }
            if (result == DialogResult.No)
            {
                MessageBox.Show("Bạn đã hủy sửa loại dịch vụ này");
            }
        }

        private void FrmBtnSuaLoaiDichVu_Load(object sender, EventArgs e)
        {
            tb_MaLoaiDichVu.Text = MaLoaiDichVu;
            tb_TenLoaiDichVu.Text = TenLoaiDichVu;
        }

        private void btn_HuySuaLoaiDichVu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
