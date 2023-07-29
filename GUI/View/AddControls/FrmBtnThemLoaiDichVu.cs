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
    public partial class FrmBtnThemLoaiDichVu : Form
    {
        public send_ldv _send;
        private IQLLoaiDichVuService _iQLLoaiDichVuService;
        Validations val;
        public FrmBtnThemLoaiDichVu()
        {
            InitializeComponent();
            _iQLLoaiDichVuService = new QLLoaiDichVuService();
        }
        public FrmBtnThemLoaiDichVu(send_ldv send)
        {
            InitializeComponent();
            this._send = send;
            _iQLLoaiDichVuService = new QLLoaiDichVuService();
            val= new Validations();
        }

        private void btn_ThemLoaiDichVu_Click(object sender, EventArgs e)
        {
            DialogResult dls = MessageBox.Show("Bạn có muốn thêm loai dịch vụ này không?", "Thông báo", MessageBoxButtons.YesNo);
            if (dls == DialogResult.Yes)
            {
                if(val.CheckRong(tb_TenLoaiDichVu.Text)==false||val.CheckRong(tb_MaLoaiDichVu.Text)==false)
                {
                    MessageBox.Show("Vui Lòng nhập đầy đủ thông tin", "Thông báo");
                    return;
                }
                var ldv = new LoaiDichVuView()
                {
                    ID = Guid.NewGuid(),
                    TenLoaiDichVu = tb_TenLoaiDichVu.Text,
                    MaLoaiDichVu = tb_MaLoaiDichVu.Text
                };
                MessageBox.Show(_iQLLoaiDichVuService.Add(ldv));
                _send(_iQLLoaiDichVuService.GetAll());
            }
            else
            {
                MessageBox.Show("Bạn đã không thên loại dịch vụ này");
            }
        }

        private void btn_HuyThemLoaiDichVu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
